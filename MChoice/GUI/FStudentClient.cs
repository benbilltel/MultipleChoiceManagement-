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
    public partial class FStudentClient : Form
    {
        public FStudentClient()
        {
            InitializeComponent();
        }
        public FStudentClient(int idStudent)
        {
            InitializeComponent();
            this.idStudent = idStudent;
            this.dtStudentInfo = dalStudent.GetStudentById(idStudent);
            if (dtStudentInfo.Rows.Count > 0)
            {
                this.rowSTInfo = dtStudentInfo.Rows[0];
            }
           
            
        }
        DAL_Student dalStudent = new DAL_Student();
        DAL_ListSubject dalLsSb = new DAL_ListSubject();    
        private int idStudent;
        DataTable dtStudentInfo;
        DataRow rowSTInfo;
        void LoadInfoStudent()
        {
            
            lblIDStudent.Text = rowSTInfo[0].ToString().Trim();
            lblStudentName.Text = rowSTInfo[1].ToString().Trim()+" "+ rowSTInfo[2].ToString().Trim();
            lblClassName.Text = rowSTInfo[6].ToString().Trim();
            lblGender.Text = rowSTInfo[3].ToString().Trim();
            lblPhoneContact.Text = rowSTInfo[4].ToString().Trim();    

        }
        private void FStudentClient_Load(object sender, EventArgs e)
        {
            LoadInfoStudent();
            DTO_Class cl = new DTO_Class((int)rowSTInfo[5]);
            DTO_Student student = new DTO_Student(idStudent, cl);
            dtGVSubjectAvailable.DataSource = dalLsSb.GetListSubjectAvailable(student);
            if (dtGVSubjectAvailable.Rows.Count > 0)
            {
                dtGVSubjectAvailable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtGVSubjectAvailable.Columns[0].Visible = false;
            }
            dtGVSubjectAvailable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
        bool isOut = true;
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            isOut = false;
            this.Close();
            FLogin fLog = new FLogin();
            fLog.Show();
        }

        private void FStudentClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isOut)
            {
                Application.Exit();
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if(dtGVSubjectAvailable.Rows.Count <= 0)
            {
                MessageBox.Show("No subject to take exam!");
                return;
            }
            if(dtGVSubjectAvailable.SelectedRows.Count ==1)
            {
                DataGridViewRow row = dtGVSubjectAvailable.SelectedRows[0];
                FComp fComp = new FComp((int)row.Cells[0].Value,idStudent);
                fComp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select one subject to enroll!");
            }
        }

        private void btnEnroll_MouseEnter(object sender, EventArgs e)
        {
            btnEnroll.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnEnroll_MouseLeave(object sender, EventArgs e)
        {
            btnEnroll.ForeColor = ColorTranslator.FromHtml("82, 146, 199");
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }
    }
}
