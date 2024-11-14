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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO;

namespace QUANLYNHAHANG
{
    public partial class fFoods : Form
    {
        Food f;
        DanhMucFood dmFood;
        DanhMucCategory dmCate;
        private string tenFile = "Food.txt";
        private int viTriHienTai = 0;
        public fFoods()
        {
            InitializeComponent();
            dmCate = new DanhMucCategory();
            BindComboBox();
        }

        private void hienthi(DataGridView dgv, List<Food> ds)
        {
            dataGridViewFood.DataSource = ds;
        }
        private void BindComboBox()
        {
            cbxFood.DataSource = dmCate.DSCategory;
            cbxFood.DisplayMember = "DanhMuc";
        }

        private void Foods_Load(object sender, EventArgs e)
        {
            dmFood = new DanhMucFood();
            f = new Food();
            hienthi(dataGridViewFood, dmFood.DSFood);
        }

        private void btnAddF_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPriceF.Text, out double price))
            {
                MessageBox.Show("Invalid value for phone number. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDF.Focus();
                return;
            }
            Food nv = new Food(txtIDF.Text, txtName.Text, price, txtMota.Text);
            if (dmFood.kiemTraTrungMa(txtIDF.Text))
            {
                MessageBox.Show("Ma nay da co", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDF.Focus();
            }
            else
            {
                dmFood.them(nv);
                hienthi(dataGridViewFood, dmFood.DSFood);
                LuuFileText(tenFile);
            }
        }

        private void btnDeleteF_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Ban chac chua?", "Thoong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ketQua == DialogResult.Yes)
            {
                dmFood.xoa(viTriHienTai);

                hienthi(dataGridViewFood, dmFood.DSFood);
                LuuFileText(tenFile);
            }
        }

        private void dataGridViewFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            viTriHienTai = e.RowIndex;

            if (viTriHienTai >= 0 && viTriHienTai < dmFood.DSFood.Count)
            {
                Food selectedFood = dmFood.DSFood[viTriHienTai];

                txtIDF.Text = selectedFood.ID;
                txtName.Text = selectedFood.Name;
                txtPriceF.Text = selectedFood.Price.ToString();
                txtMota.Text = selectedFood.MoTa;
            }

        }

        private void btnFixF_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPriceF.Text, out double price))
            {
                MessageBox.Show("Invalid value for price. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDF.Focus();
                return;
            }

            Food foodMoi = new Food(txtIDF.Text, txtName.Text, price, txtMota.Text);

            DialogResult ketQua = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ketQua == DialogResult.Yes)
            {
                dmFood.sua(foodMoi);

                hienthi(dataGridViewFood, dmFood.DSFood);
                LuuFileText(tenFile);
            }
        }
        public void LuuFileText(string tenFile)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(tenFile, false, Encoding.UTF8))
                {
                    foreach (Food food in dmFood.DSFood)
                    {
                        string dong = $"{food.ID}\t{food.Name}\t{food.Price}\t{food.MoTa}";
                        sw.WriteLine(dong);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
