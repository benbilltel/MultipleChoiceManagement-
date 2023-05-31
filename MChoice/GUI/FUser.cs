using MChoice.DAL;
using MChoice.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MChoice.GUI
{
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
        }
        DAL_UserAdmin dalUserAdmin  = new DAL_UserAdmin();
        DAL_Class dalClass = new DAL_Class();
        DAL_Student dalStudent = new DAL_Student();
        DataTable dtClass = new DataTable();
        private void FUser_Load(object sender, EventArgs e)
        {
            LoadDataUserAdmin();
            LoadCBClass();
            if (dtClass.Rows.Count > 0)
            {
                DataRow row = dtClass.Rows[0];
                DTO_Class cl = new DTO_Class((int)row[0]);
                LoadDataStudent(cl);
            }
            if (dtGVStudent.Rows.Count > 0)
            {
                DataGridViewRow row = dtGVStudent.Rows[0];
                DTO_Student student = new DTO_Student((int)row.Cells[0].Value);
                LoadDataUserStudent(student);

            }
        }
        void LoadDataStudent(DTO_Class cl)
        {
            dtGVStudent.DataSource = dalStudent.GetStudentByClass(cl);
            dtGVStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVStudent.Columns["NAME_CLASS"].Visible = false;
            dtGVStudent.Columns["ID"].Visible = false;
            dtGVStudent.Columns[3].Visible = false;
            dtGVStudent.Columns[4].Visible = false;
        }
        void LoadDataUserAdmin()
        {
            dtGVUserAdmin.DataSource = dalUserAdmin.GetUserAdmin();
            dtGVUserAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVUserAdmin.Columns["ID"].Visible = false;    
        }
        void RefreshUserAdmin()
        {
            txtUserAdmin.Text = string.Empty;
            txtPassAdmin.Text = string.Empty;
            LoadDataUserAdmin();
        }
        private void dtGVUserAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVUserAdmin.Rows[e.RowIndex];
                txtUserAdmin.Text = row.Cells[1].Value.ToString().Trim();
                txtPassAdmin.Text = row.Cells[2].Value.ToString().Trim();
            }
        }
        bool CheckEmptyUserAdmin()
        {
            if(txtUserAdmin.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username is required!");
                return false;   
            }
            if(txtPassAdmin.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required!");
                return false;
            }
            return true;
        }
        private void btnRefreshUserAdmin_Click(object sender, EventArgs e)
        {
            RefreshUserAdmin();
        }

        private void btnAddUserAdmin_Click(object sender, EventArgs e)
        {
            if(!CheckEmptyUserAdmin())
            {
                return;
            }
            DTO_UserAdmin admin = new DTO_UserAdmin(txtUserAdmin.Text.Trim(),txtPassAdmin.Text.Trim());
            if(dalUserAdmin.AddUserAdmin(admin)>0 )
            {
                RefreshUserAdmin();
                MessageBox.Show("Successful!");
            }
            else
            {
                MessageBox.Show("Unsuccessful!");
            }
        }

        private void btnUpdateUserAdmin_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyUserAdmin())
            {
                return;
            }
            if (dtGVUserAdmin.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtGVUserAdmin.SelectedRows[0];
                DTO_UserAdmin admin = new DTO_UserAdmin((int)row.Cells[0].Value,txtUserAdmin.Text.Trim(), txtPassAdmin.Text.Trim());
                if (dalUserAdmin.UpdateUserAdmin(admin) > 0)
                {
                    RefreshUserAdmin();
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }
            }
            else
            {
                MessageBox.Show("Select one user admin to handle!");
            }
        }

        private void btnRemoveUserAdmin_Click(object sender, EventArgs e)
        {
            if(dtGVUserAdmin.SelectedRows.Count> 0)
            {
                List<DTO_UserAdmin> ads = new List<DTO_UserAdmin>();
                foreach (DataGridViewRow row in dtGVUserAdmin.SelectedRows)
                {
                    DTO_UserAdmin ad = new DTO_UserAdmin((int)row.Cells[0].Value);
                    ads.Add(ad);    
                }
                if(dalUserAdmin.RemoveUserAdmin(ads) > 0)
                {
                    RefreshUserAdmin();
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }
            }
            else
            {
                MessageBox.Show("Select one user admin to handle!");
            }
        }



        void LoadCBClass()
        {
            dtClass = dalClass.GetClass();
            cbClass.Items.Clear();
          
            if (dtClass.Rows.Count > 0)
            {
                foreach (DataRow row in dtClass.Rows)
                {
                    cbClass.Items.Add(row[1].ToString());
                 
                }
                cbClass.Text = cbClass.Items[0].ToString().Trim();
              
            }
            else
            {
                cbClass.Text = string.Empty;
             
            }
        }
        int GetIDClassByCBClass(ComboBox cb)
        {
            if (cb.Items.Count > 0)
            {
                int idCl = -1;
                foreach (DataRow row in dtClass.Rows)
                {
                    if (cb.Text.Trim().Equals(row[1].ToString().Trim()))
                    {
                        idCl = (int)row[0];
                        break;
                    }
                }
                return idCl;
            }
            return -1;
        }
        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCL = GetIDClassByCBClass(cbClass);
            if (idCL != -1)
            {
                DTO_Class cl = new DTO_Class(idCL);
                LoadDataStudent(cl);
            }

        }
        DAL_UserStudent dalUserStudent = new DAL_UserStudent();
        void LoadDataUserStudent(DTO_Student st)
        {
            dtGVUserStudent.DataSource = dalUserStudent.GetUserStudentByIdStudent(st);
            dtGVUserStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVUserStudent.Columns["ID"].Visible = false;
        }
        private void dtGVStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0) {
                DataGridViewRow row = dtGVStudent.Rows[e.RowIndex];
                DTO_Student student = new DTO_Student((int)row.Cells[0].Value);
                LoadDataUserStudent(student);
            } 
            
        }
        void RefreshUserStudent()
        {
            txtUsernameStudent.Text = string.Empty;
            txtPassStudent.Text = string.Empty;
            int idCL = GetIDClassByCBClass(cbClass);
            if (idCL != -1)
            {
                DTO_Class cl = new DTO_Class(idCL);
                LoadDataStudent(cl);
            }
            if (dtGVStudent.Rows.Count > 0)
            {
                DataGridViewRow row = dtGVStudent.Rows[0];
                DTO_Student student = new DTO_Student((int)row.Cells[0].Value);
                LoadDataUserStudent(student);

            }

        }
        bool CheckEmptyUserStudent()
        {
            if (txtUsernameStudent.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username is required!");
                return false;
            }
            if (txtPassStudent.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required!");
                return false;
            }
            return true;

        }
        private void dtGVUserStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = dtGVUserStudent.Rows[e.RowIndex];
                txtUsernameStudent.Text = row.Cells[1].Value.ToString().Trim();
                txtPassStudent.Text = row.Cells[2].Value.ToString().Trim();

            }
        }

        private void btnRefreshUserStudent_Click(object sender, EventArgs e)
        {
            RefreshUserStudent();
        }

        private void btnAddUserStudent_Click(object sender, EventArgs e)
        {
            if(!CheckEmptyUserStudent()) { return; }
            int idCl = GetIDClassByCBClass(cbClass);
            DTO_Class cl = new DTO_Class(idCl);
            DataGridViewRow row = dtGVStudent.SelectedRows[0];
            DTO_Student st = new DTO_Student((int)row.Cells[0].Value);
            DTO_UserStudent usSt = new DTO_UserStudent(txtUsernameStudent.Text.Trim(),txtPassStudent.Text.Trim(),st,cl);
            if (dalUserStudent.AddUserStudent(usSt) > 0)
            {
                RefreshUserStudent();
                MessageBox.Show("Successful!");
            }
            else
            {
                MessageBox.Show("Unuccessful!");
            }
        }

        private void btnUpdateUserStudent_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyUserStudent()) { return; }
            if (dtGVUserStudent.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtGVUserStudent.SelectedRows[0];
                DTO_UserStudent usSt = new DTO_UserStudent((int)row.Cells[0].Value, txtUsernameStudent.Text.Trim(), txtPassStudent.Text.Trim());
                if (dalUserStudent.UpdateUserStudent(usSt) > 0)
                {
                    RefreshUserStudent();
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unuccessful!");
                }

            }
            else
            {
                MessageBox.Show("Select one user student to handle!");
            }
            
        }

        private void btnRemoveUserStudent_Click(object sender, EventArgs e)
        {
            if (dtGVUserStudent.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtGVUserStudent.SelectedRows[0];
                DTO_UserStudent usSt = new DTO_UserStudent((int)row.Cells[0].Value);
                if (dalUserStudent.RemoveUserStudent(usSt) > 0)
                {
                    RefreshUserStudent();
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unuccessful!");
                }

            }
            else
            {
                MessageBox.Show("Select one user student to handle!");
            }
        }

        private void btnRemoveUserAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveUserAdmin.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }

        private void btnRemoveUserAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveUserAdmin.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAddUserAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnAddUserAdmin.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAddUserAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnAddUserAdmin.ForeColor = ColorTranslator.FromHtml("99, 180, 86");
        }

        private void btnUpdateUserAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateUserAdmin.ForeColor = ColorTranslator.FromHtml("82, 146, 199");
            
        }

        private void btnUpdateUserAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateUserAdmin.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnRefreshUserAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnRefreshUserAdmin.ForeColor = ColorTranslator.FromHtml("81, 63, 102");
        }

        private void btnRefreshUserAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnRefreshUserAdmin.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnAddUserStudent_MouseEnter(object sender, EventArgs e)
        {
            btnAddUserStudent.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAddUserStudent_MouseLeave(object sender, EventArgs e)
        {
            btnAddUserStudent.ForeColor = ColorTranslator.FromHtml("99, 180, 86");
        }

        private void btnRemoveUserStudent_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveUserStudent.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }
        private void btnRemoveUserStudent_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveUserStudent.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }

        private void btnUpdateUserStudent_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateUserStudent.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnUpdateUserStudent_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateUserStudent.ForeColor = ColorTranslator.FromHtml("82, 146, 199");
        }

        private void btnRefreshUserStudent_MouseEnter(object sender, EventArgs e)
        {
            btnRefreshUserStudent.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnRefreshUserStudent_MouseLeave(object sender, EventArgs e)
        {
            btnRefreshUserStudent.ForeColor = ColorTranslator.FromHtml("81, 63, 102");
        }

        private void txtUsernameStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtUserAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPassAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPassStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
