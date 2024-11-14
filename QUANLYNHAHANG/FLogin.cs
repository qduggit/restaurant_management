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

namespace QUANLYNHAHANG
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textPass.Text;

            if (IsLoginvalid(username, password))
            {
                fManagement f = new fManagement();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra tên đăng nhập và mật khẩu.");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //fSignup f = new fSignup();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
        }

        private bool IsLoginvalid(string enteredUsername, string enteredPassword)
        {
            string[] lines = File.ReadAllLines("data.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string username = parts[0];
                    string password = parts[1];

                    if (enteredUsername == username && enteredPassword == password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void phideclick_Click(object sender, EventArgs e)
        {
            if (textPass.PasswordChar == '*')
            {
                eyeClick.BringToFront();
                textPass.PasswordChar = '\0';
            }
        }

        private void eyeClick_Click(object sender, EventArgs e)
        {
            if (textPass.PasswordChar == '\0')
            {
                phideclick.BringToFront();
                textPass.PasswordChar = '*';
            }
        }
    }
}
