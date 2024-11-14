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
using System.Xml.Linq;

namespace QUANLYNHAHANG
{
    public partial class fEmployees : Form
    {
        Employee nv;
        DanhMucEmployee dmEmploy;
        private string tenFile = "Employee.text";
        private int viTriHienTai = 0;
        public fEmployees()
        {
            InitializeComponent();
        }

        private void hienthi(DataGridView dgv, List<Employee> ds)
        {
            dataGridViewEmployees.DataSource = ds;
        }

        private void btnAddE_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (radioButton1.Checked == true)
                gioitinh = "Nam";
            else gioitinh = "Nữ";
            if (!double.TryParse(txtSDTE.Text, out double sdteValue))
            {
                MessageBox.Show("Invalid value for phone number. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDTE.Focus();
                return;
            }
            Employee nv = new Employee(txtIDE.Text, txtNameE.Text, txtAddressE.Text, gioitinh, sdteValue, txtPositionE.Text);
            if (dmEmploy.kiemTraTrungMa(txtIDE.Text))
            {
                MessageBox.Show("Ma nay da co", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDE.Focus();
            }
            else
            {
                dmEmploy.them(nv);
                hienthi(dataGridViewEmployees, dmEmploy.DSEmployee);
                LuuFileText(tenFile);
            }
        }


        private void Employees_Load(object sender, EventArgs e)
        {
            nv = new Employee();
            dmEmploy = new DanhMucEmployee();
            DocFileText(tenFile);
            hienthi(dataGridViewEmployees, dmEmploy.DSEmployee);
        }

        public void LuuFileText(string tenFile)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(tenFile, false, Encoding.UTF8))
                {
                    foreach (Employee employee in dmEmploy.DSEmployee)
                    {
                        string dong = $"{employee.ID}\t{employee.Name}\t{employee.Address}\t{employee.Sex}\t{employee.SDT}\t{employee.Position}";
                        sw.WriteLine(dong);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void DocFileText(string tenFile)
        {
            try
            {
                using (StreamReader sr = new StreamReader(tenFile, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] parts = sr.ReadLine().Split('\t');
                        if (parts.Length == 6)
                        {
                            string id = parts[0];
                            string name = parts[1];
                            string address = parts[2];
                            string gender = parts[3];
                            if (double.TryParse(parts[4], out double phoneNumber))
                            {
                                string position = parts[5];
                                Employee employee = new Employee(id, name, address, gender, phoneNumber, position);
                                dmEmploy.them(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTriHienTai = e.RowIndex;

            if (viTriHienTai >= 0 && viTriHienTai < dmEmploy.DSEmployee.Count)
            {
                Employee selectedEmployee = dmEmploy.DSEmployee[viTriHienTai];

                txtIDE.Text = selectedEmployee.ID;
                txtNameE.Text = selectedEmployee.Name;
                txtAddressE.Text = selectedEmployee.Address;
                if (selectedEmployee.Sex.Equals("Nam"))
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                txtSDTE.Text = selectedEmployee.SDT.ToString();
                txtPositionE.Text = selectedEmployee.Position;
            }
        }



        private void btnDeleteE_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Ban chac chua?", "Thoong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ketQua == DialogResult.Yes)
            {
                dmEmploy.xoa(viTriHienTai);
                hienthi(dataGridViewEmployees, dmEmploy.DSEmployee);
                LuuFileText(tenFile);
            }
        }

        private void btnFixE_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (radioButton1.Checked == true)
                gioitinh = "Nam";
            else gioitinh = "Nữ";
            if (!double.TryParse(txtSDTE.Text, out double sdt))
            {
                MessageBox.Show("Invalid value for price. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDE.Focus();
                return;
            }

            Employee nvMoi = new Employee(txtIDE.Text, txtNameE.Text, txtAddressE.Text, gioitinh, sdt, txtPositionE.Text);

            DialogResult ketQua = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ketQua == DialogResult.Yes)
            {
                dmEmploy.sua(nvMoi);

                hienthi(dataGridViewEmployees, dmEmploy.DSEmployee);
                LuuFileText(tenFile);

            }
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
