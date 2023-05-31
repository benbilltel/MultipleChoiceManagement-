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

namespace MChoice.GUI
{
    public partial class FStudent : Form
    {
        public FStudent()
        {
            InitializeComponent();
        }
        DAL_Class dalClass = new DAL_Class();   
        DAL_Student dalStudent  = new DAL_Student();
        DataTable dtClass = null;
        private void FStudent_Load(object sender, EventArgs e)
        {
            LoadCBClass();
            if(dtClass.Rows.Count > 0)
            {
                DataRow row = dtClass.Rows[0];
                DTO_Class cl = new DTO_Class((int)row[0]);
                LoadDataStudent(cl);
            }
            cbGender.Text = cbGender.Items[0].ToString().Trim();
        }
        void LoadDataStudent(DTO_Class cl)
        {
            dtGVStudent.DataSource = dalStudent.GetStudentByClass(cl);
            dtGVStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVStudent.Columns["NAME_CLASS"].Visible = false;
            dtGVStudent.Columns["ID"].Visible = false;
        }
        void LoadCBClass()
        {
            dtClass = dalClass.GetClass();
            cbClass.Items.Clear();
            cbClass2.Items.Clear();
            if (dtClass.Rows.Count > 0 )
            {
                foreach(DataRow row in dtClass.Rows)
                {
                    cbClass.Items.Add(row[1].ToString());
                    cbClass2.Items.Add(row[1].ToString());
                }
                cbClass.Text = cbClass.Items[0].ToString().Trim();
                cbClass2.Text = cbClass.Items[0].ToString().Trim();
            }
            else
            {
                cbClass.Text = string.Empty;
                cbClass2.Text = string.Empty;
            }
        }
        void RefreshStudent()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhoneContact.Text = string.Empty;
            cbGender.Text = cbGender.Items[0].ToString().Trim();
            if(cbClass2.Items.Count > 0 )
            {
                cbClass2.Text = cbClass2.Items[0].ToString().Trim();
            }
            else
            {
                cbClass2.Text = string.Empty;
            }
            int idCL = GetIDClassByCBClass(cbClass);
            if (idCL != -1)
            {
                DTO_Class cl = new DTO_Class(idCL);
                LoadDataStudent(cl);
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

        private void btnRefreshStudent_Click(object sender, EventArgs e)
        {
            RefreshStudent();
        }

        private void dtGVStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVStudent.Rows[e.RowIndex];
                txtFirstName.Text = row.Cells[1].Value.ToString().Trim();
                txtLastName.Text = row.Cells[2].Value.ToString().Trim();
                cbGender.Text = row.Cells[3].Value.ToString().Trim();
                txtPhoneContact.Text = row.Cells[4].Value.ToString().Trim();
                cbClass2.Text = row.Cells[5].Value.ToString().Trim();   
            }
        }
        bool CheckEmptyStudent()
        {
            if(txtFirstName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("First Name is required!");
                return false;
            }
            if (txtLastName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Last Name is required!");
                return false;
            }
            
            if (cbClass2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Class Name is required!");
                return false;
            }
            if (cbGender.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Gender is required!");
                return false;
            }
            return true;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyStudent())
            {
                return;
            }
            int idCL = GetIDClassByCBClass(cbClass2);
            if (idCL != -1)
            {
                DTO_Class cl = new DTO_Class(idCL);
                DTO_Student student = new DTO_Student(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), cbGender.Text.Trim(), txtPhoneContact.Text.Trim(),cl);
                if (dalStudent.AddStudent(student) > 0)
                {
                    int idCL2 = GetIDClassByCBClass(cbClass2);
                    if (idCL2 != -1)
                    {
                        DTO_Class cl2 = new DTO_Class(idCL2);
                        LoadDataStudent(cl);
                    }
                    cbClass.Text = cbClass2.Text;
                    RefreshStudent();
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }
            }
            else
            {
                MessageBox.Show("Class Name does not exist!");
            }
            
        }
       
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyStudent())
            {
                return;
            }
            if(dtGVStudent.SelectedRows.Count ==1)
            {
                int idCL = GetIDClassByCBClass(cbClass2);
                if (idCL != -1)
                {
                    DTO_Class cl = new DTO_Class(idCL);
                    DataGridViewRow row = dtGVStudent.SelectedRows[0];
                    int idST = (int)row.Cells[0].Value;
                    DTO_Student student = new DTO_Student(idST,txtFirstName.Text.Trim(), txtLastName.Text.Trim(), cbGender.Text.Trim(), txtPhoneContact.Text.Trim(), cl);
                    if (dalStudent.UpdateStudent(student) > 0)
                    {
                        int idCL2 = GetIDClassByCBClass(cbClass2);
                        if (idCL2 != -1)
                        {
                            DTO_Class cl2 = new DTO_Class(idCL2);
                            LoadDataStudent(cl);
                        }
                        cbClass.Text = cbClass2.Text;
                        RefreshStudent();
                        MessageBox.Show("Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful!");
                    }
                }
                else
                {
                    MessageBox.Show("Class Name does not exist!");
                }
            }
            else
            {
                MessageBox.Show("Select one student to handle!");
            }
            
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if(dtGVStudent.SelectedRows.Count > 0) {
                List<DTO_Student> stds = new List<DTO_Student>();   
                foreach (DataGridViewRow row in dtGVStudent.SelectedRows)
                {
                    DTO_Student std = new DTO_Student((int)row.Cells[0].Value);
                    stds.Add(std);
                }
                if (dalStudent.RemoveStudent(stds) > 0)
                {
                    int idCL = GetIDClassByCBClass(cbClass2);
                    DTO_Class cl = new DTO_Class(idCL);
                    LoadDataStudent(cl);
                    RefreshStudent();
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }
            } else
            {
                MessageBox.Show("Select Students to handle!");
            }
        }

        private void btnAddStudent_MouseEnter(object sender, EventArgs e)
        {
            btnAddStudent.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnAddStudent_MouseLeave(object sender, EventArgs e)
        {
            btnAddStudent.ForeColor = ColorTranslator.FromHtml("99, 180, 86");

        }

        private void btnRemoveStudent_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveStudent.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnRemoveStudent_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveStudent.ForeColor = ColorTranslator.FromHtml("215, 33, 52");

        }

        private void btnUpdateStudent_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateStudent.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnUpdateStudent_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateStudent.ForeColor = ColorTranslator.FromHtml("82, 146, 199");

        }

        private void btnRefreshStudent_MouseEnter(object sender, EventArgs e)
        {
            btnRefreshStudent.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnRefreshStudent_MouseLeave(object sender, EventArgs e)
        {
            btnRefreshStudent.ForeColor = ColorTranslator.FromHtml("81, 63, 102");

        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPhoneContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
