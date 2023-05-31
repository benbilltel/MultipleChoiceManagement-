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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private void btnOpenClass_Click(object sender, EventArgs e)
        {
            FClass fClass = new FClass();
            fClass.ShowDialog();
        }

        private void btnOpenSubject_Click(object sender, EventArgs e)
        {
            FSubject fSubject = new FSubject();
            fSubject.ShowDialog();
        }

        private void btnOpenStudent_Click(object sender, EventArgs e)
        {
            FStudent fStudent = new FStudent();
            fStudent.ShowDialog();
        }

        private void btnOpenQuizz_Click(object sender, EventArgs e)
        {
            FQuizz fQuizz = new FQuizz();
            fQuizz.ShowDialog();
        }

        private void btnOpenResult_Click(object sender, EventArgs e)
        {
            FResult fResult = new FResult();
            fResult.ShowDialog();
        }

        private void btnOpenUser_Click(object sender, EventArgs e)
        {
            FUser fUser = new FUser();
            fUser.ShowDialog();
        }

        private void FAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isOut)
            {
                Application.Exit();
            }
            
        }
        bool isOut = true;
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            isOut = false;
            this.Close();
            FLogin fLog = new FLogin(); 
            fLog.Show();
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
