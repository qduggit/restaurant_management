using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHAHANG
{
    public partial class fManagement : Form
    {
        public fManagement()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildform(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void fManagement_Load(object sender, EventArgs e)
        {

        }
        private void ptrHome_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            labelHome.Text = "Home";
        }

        private void lbTable_Click(object sender, EventArgs e)
        {
            OpenChildform(new fTables());
            labelHome.Text = lbTable.Text;
        }

        private void lbEmployee_Click(object sender, EventArgs e)
        {
            OpenChildform(new fEmployees());
            labelHome.Text = lbEmployee.Text;
        }

        private void lbFood_Click(object sender, EventArgs e)
        {
            OpenChildform(new fFoods());
            labelHome.Text = lbFood.Text;
        }

        private void lbCategory_Click(object sender, EventArgs e)
        {
            OpenChildform(new fCategory());
            labelHome.Text = lbCategory.Text;
        }

        private void lbRevenue_Click(object sender, EventArgs e)
        {
            OpenChildform(new fRevenue());
            labelHome.Text = lbRevenue.Text;
        }

        private void lbOrder_Click(object sender, EventArgs e)
        {
            OpenChildform(new fOrder());
            labelHome.Text = lbOrder.Text;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
