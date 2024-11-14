using QUANLYNHAHANG.DAO;
using QUANLYNHAHANG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace QUANLYNHAHANG
{
    public partial class fOrder : Form
    {
        OrderInfo od;
        DanhMucTable danhMucTable;
        DanhMucFood dmFood;
        DanhMucOrder dmOrder;
        private string tenFile = "Order.txt";
        public fOrder()
        {
            InitializeComponent();
            danhMucTable = new DanhMucTable();
            dmFood = new DanhMucFood();
            dmOrder = new DanhMucOrder();
            od = new OrderInfo();
            LoadTableButtons();
            BindComboBox();

        }


        private List<Food> GetFoodList()
        {
            return dmFood.DSFood;
        }

        private void BindComboBox()
        {
            cbxOrder1.DataSource = danhMucTable.DSTaBle;
            cbxOrder1.DisplayMember = "Name";
            comboBoxFooodd.DataSource = dmFood.DSFood;
            comboBoxFooodd.DisplayMember = "Name";
        }

        private void LoadTableButtons()
        {

            flowLayoutPanelTables.Controls.Clear();

            foreach (Table table in danhMucTable.DSTaBle)
            {
                Button btnTable = new Button();
                btnTable.Text = table.Name + "\n" + table.Status;
                btnTable.Size = new Size(90, 90);
                btnTable.Tag = table;

                btnTable.Click += BtnTable_Click;


                flowLayoutPanelTables.Controls.Add(btnTable);
            }
        }
 
        private void UpdateTableStatus(Table table)
        {
            bool coDonHang = dmOrder.CoDonHang(table.ID);
            table.Status = coDonHang ? "Có người" : "Trống";

            foreach (Control control in flowLayoutPanelTables.Controls)
            {
                if (control is Button btnTable)
                {
                    Table btnTableData = (Table)btnTable.Tag;

                    if (btnTableData != null && btnTableData.ID == table.ID)
                    {
                        btnTable.Text = table.Name + "\n" + table.Status;                       
                        break;
                    }
                }
            }
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            Button btnTable = (Button)sender;
            selectedTable = (Table)btnTable.Tag;
            if (selectedTable != null)
            {                                     
                DisplayDataInListView(selectedTable.ID);               
            }

        }
        private Table selectedTable;


        private void DisplayDataInListView(int tableId)
        {
            listView1.Items.Clear();
            double toTalPrice = 0;

            if (dmOrder != null && dmOrder.DSOrder != null)
            {
                foreach (OrderInfo order in dmOrder.DSOrder.Where(oi => oi.TableID == tableId))
                {
                    ListViewItem listViewItem = new ListViewItem(order.Name);
                    listViewItem.SubItems.Add(order.Count.ToString());
                    listViewItem.SubItems.Add(order.Price.ToString("C"));
                    listViewItem.SubItems.Add(order.ThanhTien.ToString("C"));
                    toTalPrice += order.ThanhTien;
                    listView1.Items.Add(listViewItem);
                }
                txtTongTien.Text = toTalPrice.ToString("C");
            }
        }
        private void btnThemmon_Click(object sender, EventArgs e)
        {
            if (selectedTable != null)
            {
                Food selectedFood = (Food)comboBoxFooodd.SelectedItem;
                int count = (int)numericUpDown1.Value;
                if (selectedFood != null)
                {
                    OrderInfo existingOrder = dmOrder.DSOrder.FirstOrDefault(o => o.Name == selectedFood.Name && o.TableID == selectedTable.ID);

                    if (existingOrder != null)
                    {
                        existingOrder.Count += count;
                    }
                    else
                    {
                        OrderInfo newOrder = new OrderInfo()
                        {
                            Name = selectedFood.Name,
                            Count = count,
                            Price = selectedFood.Price,
                            TableID = selectedTable.ID,
                        };

                        dmOrder.them(newOrder);
                    }
                    UpdateTableStatus(selectedTable);
                    DisplayDataInListView(selectedTable.ID);                  
                }
                else
                {
                    MessageBox.Show("Hãy chọn food", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn bàn", "Thông báo");
            }
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (selectedTable != null)
            {
                Table table = selectedTable as Table;
                int idbill = table.ID;
                if (idbill != -1)
                {
                    if (MessageBox.Show("Bạn có muốn thanh toán hoá đơn cho " + table.Name, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        dmOrder.XoaOrderTheoBan(selectedTable.ID);
                        DisplayDataInListView(selectedTable.ID);
                        UpdateTableStatus(selectedTable);                                      
                    }

                }   

            }
            else
            {
                MessageBox.Show("Hãy chọn bàn cần thanh toán", "Thông báo");
            }
        }

    
    }

}