using QUANLYNHAHANG.DAO;
using QUANLYNHAHANG.DTO;
using System.Text;

namespace QUANLYNHAHANG
{
    public partial class fTables : Form
    {

        Table tb;
        DanhMucTable dmTable;
        private string tenFile = "table.txt";
        private int viTriHienTai = 0;
        public fTables()
        {
            InitializeComponent();
        }
        private void hienthi(DataGridView dgv, List<Table> ds)
        {
            dataGridViewTables.DataSource = ds;
        }

        private void btnAddT_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtIDT.Text, out int tableId))
            {
                Table tb = new Table(tableId, txtNameT.Text, txtStatusT.Text);

                if (dmTable.kiemTraTrungMa(txtIDT.Text))
                {
                    MessageBox.Show("Mã này đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDT.Focus();
                }
                else
                {
                    dmTable.them(tb);
                    hienthi(dataGridViewTables, dmTable.DSTaBle);
                    LuuFileText(tenFile);
                }
            }
            else
            {
                MessageBox.Show("Mã bàn phải là số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDT.Focus();
            }
        }

        private void btnDeleteT_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Ban chac chua?", "Thoong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ketQua == DialogResult.Yes)
            {
                dmTable.xoa(viTriHienTai);
                hienthi(dataGridViewTables, dmTable.DSTaBle);
                LuuFileText(tenFile);
            }

        }

        private void btnFixT_Click(object sender, EventArgs e)
        {
            Table tbMoi;
            if (int.TryParse(txtIDT.Text, out int tableId))
            {
                tbMoi = new Table(tableId, txtNameT.Text, txtStatusT.Text);

                DialogResult ketQua = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (ketQua == DialogResult.Yes)
                {
                    dmTable.sua(tbMoi);
                    hienthi(dataGridViewTables, dmTable.DSTaBle);
                    LuuFileText(tenFile);
                }
            }
            else
            {
                MessageBox.Show("Mã bàn phải là số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDT.Focus();
            }
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            tb = new Table();
            dmTable = new DanhMucTable();
            //DocFileText(tenFile);
            hienthi(dataGridViewTables, dmTable.DSTaBle);
        }

        private void dataGridViewTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTables.Rows.Count)
            {
                string id = dataGridViewTables.Rows[e.RowIndex].Cells[0].Value.ToString();
                string name = dataGridViewTables.Rows[e.RowIndex].Cells[1].Value.ToString();
                string status = dataGridViewTables.Rows[e.RowIndex].Cells[2].Value.ToString();

                txtIDT.Text = id;
                txtNameT.Text = name;
                txtStatusT.Text = status;
                viTriHienTai = e.RowIndex;
            }
        }

        public void LuuFileText(string tenFile)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(tenFile, false, Encoding.UTF8))
                {
                    foreach (Table table in dmTable.DSTaBle)
                    {
                        string dong = $"{table.ID}\t{table.Name}\t{table.Status}";
                        sw.WriteLine(dong);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}