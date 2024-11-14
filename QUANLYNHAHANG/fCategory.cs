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
    public partial class fCategory : Form
    {
        Category dm;
        DanhMucCategory dmCategr;
        private string tenFile = "Category.txt";
        private int viTriHienTai = 0;
        public fCategory()
        {
            InitializeComponent();
        }

        private void hienthi(DataGridView dgv, List<Category> ds)
        {
            dgvCategory.DataSource = ds;
        }



        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Ban chac chua?", "Thoong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ketQua == DialogResult.Yes)
            {
                dmCategr.xoa(viTriHienTai);

                hienthi(dgvCategory, dmCategr.DSCategory);
                LuuFileText(tenFile);
            }
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIDC.Text, out int id))
            {
                MessageBox.Show("Invalid value for phone number. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDC.Focus();
                return;
            }
            Category ct = new Category(id, txtC.Text);
            dmCategr.them(ct);
            hienthi(dgvCategory, dmCategr.DSCategory);
            LuuFileText(tenFile);

        }

        private void btnFixC_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIDC.Text, out int id))
            {
                MessageBox.Show("Invalid value for price. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDC.Focus();
                return;
            }

            Category ctMoi = new Category(id, txtC.Text);

            DialogResult ketQua = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ketQua == DialogResult.Yes)
            {
                dmCategr.sua(ctMoi);

                hienthi(dgvCategory, dmCategr.DSCategory);
                LuuFileText(tenFile);
            }
        }

        public void LuuFileText(string tenFile)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(tenFile, false, Encoding.UTF8))
                {
                    foreach (Category ct in dmCategr.DSCategory)
                    {
                        string dong = $"{ct.ID}\t{ct.DanhMuc}";
                        sw.WriteLine(dong);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void fCategory_Load(object sender, EventArgs e)
        {
            dm = new Category();
            dmCategr = new DanhMucCategory();
            hienthi(dgvCategory, dmCategr.DSCategory);
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTriHienTai = e.RowIndex;

            if (viTriHienTai >= 0 && viTriHienTai < dmCategr.DSCategory.Count)
            {
                Category selectedct = dmCategr.DSCategory[viTriHienTai];

                txtIDC.Text = selectedct.ID.ToString();
                txtC.Text = selectedct.DanhMuc;

            }

        }
    }
}
