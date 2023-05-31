using MChoice.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChoice.GUI
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool CheckEmptyLogin()
        {
            if(txtUserName.Text.Trim()== string.Empty)
            {
                
                MessageBox.Show("Username is required!");
                return false;
            }
            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required!");
                return false;
            }
            return true;
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(!CheckEmptyLogin()) { return; }
            bool flag = false;
            if (rdAdmin.Checked)
            {

                DAL_UserAdmin dalUserAdmin = new DAL_UserAdmin();
                DataTable dt = dalUserAdmin.GetUserAdmin();
                
                foreach(DataRow dr in dt.Rows)
                {
                    if (txtUserName.Text.Trim().Equals(dr[1].ToString().Trim()))
                    {
                        if (txtPassword.Text.Trim().Equals(dr[2].ToString().Trim()))
                        {
                            flag = true;
                            break;
                        }
                    }
                }
               if(flag)
                {
                    FAdmin fAdmin = new FAdmin();
                    fAdmin.Show();
                    this.Hide();
                }
                
               
            }
            if(rdStudent.Checked)
            {
                DAL_UserStudent dalUserStudent = new DAL_UserStudent(); 
                DataTable dt = dalUserStudent.GetUserStudent();
                int idST = -1;
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtUserName.Text.Trim().Equals(dr[1].ToString().Trim()))
                    {
                        if (txtPassword.Text.Trim().Equals(dr[2].ToString().Trim()))
                        {
                            flag = true;
                            idST = (int)dr[3];
                            break;
                        }
                    }
                }
                if (flag&&idST!=-1)
                {
                    FStudentClient fStudentClient = new FStudentClient(idST);
                    fStudentClient.Show();
                    this.Hide();
                }

            }
            if(flag == false)
            {
                MessageBox.Show("Username or password is nor correct!");
            }
        }

        private void FLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = ColorTranslator.FromHtml("99, 180, 86");
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
