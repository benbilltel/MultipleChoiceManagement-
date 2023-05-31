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
    public partial class FClass : Form
    {
        public FClass()
        {
            InitializeComponent();
        }
        DAL_Class dalClass = new DAL_Class();
        DAL_Subject dalSubject = new DAL_Subject();
        DAL_ListSubject dalLsSb = new DAL_ListSubject();
        DAL_Exam dalExam = new DAL_Exam();
        void LoadDataClass()
        {
            dtGVClass.DataSource = dalClass.GetClass();
            dtGVClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVClass.Columns["ID"].Visible = false;
        }
        DataTable dtSubject = null;
        void LoadCBSubject(List <ComboBox> lscbSubject)
        {
            dtSubject = dalSubject.GetSubject();
            if (dtSubject.Rows.Count > 0)
            {
                foreach (ComboBox c in lscbSubject)
                {
                    foreach (DataRow row in dtSubject.Rows)
                    {
                        c.Items.Add(row[1].ToString().Trim());
                    }
                    c.Text = c.Items[0].ToString().Trim();  
                }
            }
            else
            {
                foreach (ComboBox c in lscbSubject)
                {
                    c.Items.Clear();
                    c.Text = string.Empty;
                }
            }
            
        }
        private void FClass_Load(object sender, EventArgs e)
        {
            LoadDataClass();
            List<ComboBox> lsCB = new List<ComboBox>();
            lsCB.AddRange(new ComboBox[] { cbSubjectName1, cbSubjectName2 });
            LoadCBSubject(lsCB);
            if (dtGVClass.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtGVClass.SelectedRows[0];
                DTO_Class cl = new DTO_Class((int)row.Cells[0].Value);
                LoadDataLsSb(cl);
            }
            LoadExamInfo();
        }
        void LoadExamInfo()
        {
            if (dtGVExam.Rows.Count > 0)
            {
                DataGridViewRow row = dtGVExam.Rows[0];
                txtIDExam.Text = row.Cells[0].Value.ToString().Trim();
                if ((bool)row.Cells[1].Value == true)
                {
                    rdChecked.Checked = true;
                }
                else
                {
                    rdUnchecked.Checked = true;
                }
            }
            else
            {
                txtIDExam.Text = string.Empty;
                rdChecked.Checked = false;
                rdUnchecked.Checked = false;
            }
        }
        void RefreshClass()
        {
            txtClassName.Text = string.Empty;
            LoadDataClass();
        }
        bool CheckEmptyClass()
        {
            if(txtClassName.Text == string.Empty) { 
                MessageBox.Show("Class name is required!")
                    ; return false;
            }
            return true;
        }
        void LoadDataLsSb(DTO_Class cl)
        {
            dtGVLsSb.DataSource = dalLsSb.GetListSubjectByClassID(cl);
            dtGVLsSb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVLsSb.Columns["ID"].Visible = false;
        }
        private void dtGVClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dtGVClass.Rows[e.RowIndex];
                txtClassName.Text = row.Cells[1].Value.ToString().Trim();
                DTO_Class cl = new DTO_Class((int)row.Cells[0].Value);
                LoadDataLsSb(cl);
            }
        }

        private void btnRefreshClass_Click(object sender, EventArgs e)
        {
            RefreshClass();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if(!CheckEmptyClass()) { return; }
            DTO_Class cl = new DTO_Class(txtClassName.Text.Trim());
            if (dalClass.AddClass(cl) > 0)
            {
                RefreshClass();
                MessageBox.Show("Successful!");
            }
            else
            {
                MessageBox.Show("Unsuccessful!");
            }
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyClass()) { return; }
            DataGridViewRow row = dtGVClass.SelectedRows[0];
            int idCl = (int)row.Cells[0].Value;
            DTO_Class cl = new DTO_Class(idCl,txtClassName.Text.Trim());
            if (dalClass.UpdateClass(cl) > 0)
            {
                RefreshClass();
                MessageBox.Show("Successful!");
            }
            else
            {
                MessageBox.Show("Unsuccessful!");
            }
        }

        private void btnAddLsSb_Click(object sender, EventArgs e)
        {
            if(cbSubjectName1.Text.Trim() == string.Empty) {
                MessageBox.Show("Select one subject to add!");
                return; }
            DataGridViewRow row = dtGVClass.SelectedRows[0];
            int idCl = (int)row.Cells[0].Value;
            DTO_Class cl = new DTO_Class(idCl, txtClassName.Text.Trim());
            int idSB = -1;
            foreach(DataRow dr in dtSubject.Rows)
            {
                if (cbSubjectName1.Text.Trim().Equals(dr[1].ToString().Trim())) {
                    idSB = (int)dr[0];
                }
            }
            if (idSB == -1)
            {
                MessageBox.Show("Subject does not existed to handle!");
                return;
            }
            DTO_Subject sb = new DTO_Subject(idSB);
            DTO_ListSubject lsSb = new DTO_ListSubject(cl, sb);
            if (dalLsSb.AddListSubject(lsSb) > 0)
            {
                LoadDataLsSb(cl);
                MessageBox.Show("Successful!");
            }
            else
            {
                MessageBox.Show("Unsuccessful!");
            }


        }
        void LoadDataExamBySubject(DTO_Subject sb)
        {
            dtGVExam.DataSource = dalExam.GetExamBySubject(sb);
            dtGVExam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dtGVLsSb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVLsSb.Rows[e.RowIndex];
                cbSubjectName1.Text = row.Cells[1].Value.ToString().Trim();
                cbSubjectName2.Text = row.Cells[1].Value.ToString().Trim();
                int idSB = -1;
                foreach (DataRow dr in dtSubject.Rows)
                {
                    if (row.Cells[1].Value.ToString().Trim().Equals(dr[1].ToString().Trim()))
                    {
                        idSB = (int)dr[0];
                    }
                }
                if (idSB == -1)
                {
                    MessageBox.Show("Subject does not existed to handle!");
                    return;
                }
                DTO_Subject sb = new DTO_Subject(idSB);
                LoadDataExamBySubject(sb);
            }
            LoadExamInfo();
        }

        private void cbSubjectName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSubjectName2.Items.Count > 0) {
                int idSB = -1;
                foreach (DataRow dr in dtSubject.Rows)
                {
                    if (cbSubjectName2.Text.Trim().Equals(dr[1].ToString()))
                    {
                        idSB = (int)dr[0];
                    }
                }
                if (idSB == -1)
                {
                    MessageBox.Show("Subject does not existed to handle!");
                    return;
                }
                DTO_Subject sb = new DTO_Subject(idSB);
                LoadDataExamBySubject(sb);
                LoadExamInfo() ;
            }
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            if(cbSubjectName2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Subject name is required!");
                return ;
            }
            if (cbSubjectName2.Items.Count > 0)
            {
                int idSB = -1;
                foreach (DataRow dr in dtSubject.Rows)
                {
                    if (cbSubjectName2.Text.Trim().Equals(dr[1].ToString()))
                    {
                        idSB = (int)dr[0];
                    }
                }
                if(idSB == -1)
                {
                    MessageBox.Show("Subject does not existed to handle!");
                    return;
                }
                DTO_Subject sb = new DTO_Subject(idSB);
                if (dalExam.AddExam(sb) > 0)
                {
                    LoadDataExamBySubject(sb);
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unsuccessful!");
                }
            }
            else
            {
                MessageBox.Show("No subject existed to handle!");
            }
        }
        void RefreshExam()
        {
            txtIDExam.Text = string.Empty;
            rdChecked.Checked = false;
            rdUnchecked.Checked = false;
            
        }
        private void btnRefreshExam_Click(object sender, EventArgs e)
        {
            RefreshExam();
        }

        private void dtGVExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dtGVExam.Rows[e.RowIndex];
                txtIDExam.Text = row.Cells[0].Value.ToString().Trim();
                if ((bool)row.Cells[1].Value == true)
                {
                    rdChecked.Checked = true;
                }
                else
                {
                    rdUnchecked.Checked = true;
                }
            }
           
        }

        private void btnUpdateExam_Click(object sender, EventArgs e)
        {
            if (dtGVExam.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtGVExam.SelectedRows[0];
                if (rdChecked.Checked)
                {
                    if (dalExam.UpdateStatusExam((int)row.Cells[0].Value, true) > 0)
                    {
                        RefreshExam();
                        int idSB = -1;
                        foreach (DataRow dr in dtSubject.Rows)
                        {
                            if (cbSubjectName2.Text.Trim().Equals(dr[1].ToString()))
                            {
                                idSB = (int)dr[0];
                            }
                        }
                        if (idSB == -1)
                        {
                            MessageBox.Show("Subject does not existed to handle!");
                            return;
                        }
                        DTO_Subject sb = new DTO_Subject(idSB);
                        LoadDataExamBySubject(sb);
                          
                        
                        MessageBox.Show("Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Unuccessful!");
                    }
                }
                if (rdUnchecked.Checked)
                {
                    if (dalExam.UpdateStatusExam((int)row.Cells[0].Value, false) > 0)
                    {
                        RefreshExam();
                        int idSB = -1;
                        foreach (DataRow dr in dtSubject.Rows)
                        {
                            if (cbSubjectName2.Text.Trim().Equals(dr[1].ToString()))
                            {
                                idSB = (int)dr[0];
                            }
                        }
                        if (idSB == -1)
                        {
                            MessageBox.Show("Subject does not existed to handle!");
                            return;
                        }
                        DTO_Subject sb = new DTO_Subject(idSB);
                        LoadDataExamBySubject(sb);
                        MessageBox.Show("Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Unuccessful!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select one exam to handle!");
            }
        }

        private void btnRemoveExam_Click(object sender, EventArgs e)
        {
            if(dtGVExam.SelectedRows.Count > 0) {
                List<DTO_Exam> exs = new List<DTO_Exam>();
                foreach(DataGridViewRow row in dtGVExam.SelectedRows)
                {
                    DTO_Exam ex = new DTO_Exam((int)row.Cells[0].Value);
                    exs.Add(ex);
                }
                if(dalExam.RemoveExam(exs)>0) {
                    RefreshExam();
                    int idSB = -1;
                    foreach (DataRow dr in dtSubject.Rows)
                    {
                        if (cbSubjectName2.Text.Trim().Equals(dr[1].ToString()))
                        {
                            idSB = (int)dr[0];
                        }
                    }
                    if (idSB == -1)
                    {
                        MessageBox.Show("Subject does not existed to handle!");
                        return;
                    }
                    DTO_Subject sb = new DTO_Subject(idSB);
                    LoadDataExamBySubject(sb);
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unuccessful!");
                }
            } else
            {
                MessageBox.Show("Select exams to handle!");
            }
        }

        private void btnRemoveLsSb_Click(object sender, EventArgs e)
        {
            if(dtGVLsSb.SelectedRows.Count > 0)
            {
                List<DTO_ListSubject> lssb = new List<DTO_ListSubject>(); 
                foreach (DataGridViewRow row in dtGVLsSb.SelectedRows)
                {
                    DTO_ListSubject ls = new DTO_ListSubject((int)row.Cells[0].Value);
                    lssb.Add(ls);
                }
                if (dalLsSb.RemoveLsSb(lssb) > 0)
                {
                    if (dtGVClass.SelectedRows.Count > 0)
                    {
                        DataGridViewRow row = dtGVClass.SelectedRows[0];
                        DTO_Class cl = new DTO_Class((int)row.Cells[0].Value);
                        LoadDataLsSb(cl);
                    }
                    else
                    {
                        FClass_Load(sender, e);
                    }

                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unuccessful!");
                }
            }
            else
            {
                MessageBox.Show("Select subjects to handle!");
            }
        }

        private void btnRemoveClass_Click(object sender, EventArgs e)
        {
            if(dtGVClass.SelectedRows.Count > 0)
            {
                List<DTO_Class> cls = new List<DTO_Class> ();
                foreach(DataGridViewRow row in dtGVClass.SelectedRows) {
                    DTO_Class cl = new DTO_Class((int)row.Cells[0].Value);
                    cls.Add(cl);
                }
                if (dalClass.RemoveClass(cls) > 0)
                {
                    FClass_Load(sender, e);
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unuccessful!");
                }
            }
            else
            {
                MessageBox.Show("Select class to handle!");
            }
        }

        private void btnAddClass_MouseEnter(object sender, EventArgs e)
        {
            btnAddClass.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAddLsSb_MouseEnter(object sender, EventArgs e)
        {
            btnAddLsSb.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAddExam_MouseEnter(object sender, EventArgs e)
        {
            btnAddExam.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAddClass_MouseLeave(object sender, EventArgs e)
        {
            btnAddClass.ForeColor = ColorTranslator.FromHtml("99, 180, 86");
        }

        private void btnAddLsSb_MouseLeave(object sender, EventArgs e)
        {
            btnAddLsSb.ForeColor = ColorTranslator.FromHtml("99, 180, 86");
        }

        private void btnAddExam_MouseLeave(object sender, EventArgs e)
        {
            btnAddExam.ForeColor = ColorTranslator.FromHtml("99, 180, 86");
        }

        private void btnRemoveClass_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveClass.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnRemoveLsSb_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveLsSb.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnRemoveExam_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveExam.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnRemoveExam_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveExam.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }

        private void btnRemoveLsSb_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveLsSb.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }

        private void btnRemoveClass_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveClass.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }

        private void btnUpdateClass_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateClass.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnUpdateExam_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateExam.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnUpdateClass_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateClass.ForeColor = ColorTranslator.FromHtml("82, 146, 199");
        }

        private void btnUpdateExam_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateExam.ForeColor = ColorTranslator.FromHtml("82, 146, 199");
        }

        private void btnRefreshClass_MouseEnter(object sender, EventArgs e)
        {
            btnRefreshClass.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnRefreshExam_MouseEnter(object sender, EventArgs e)
        {
            btnRefreshExam.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

        private void btnRefreshClass_MouseLeave(object sender, EventArgs e)
        {
            btnRefreshClass.ForeColor = ColorTranslator.FromHtml("81, 63, 102");

        }

        private void btnRefreshExam_MouseLeave(object sender, EventArgs e)
        {
            btnRefreshExam.ForeColor = ColorTranslator.FromHtml("81, 63, 102");

        }
    }
}
