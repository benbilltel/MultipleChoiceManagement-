using MChoice.DAL;
using MChoice.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChoice.GUI
{
    public partial class FResult : Form
    {
        public FResult()
        {
            InitializeComponent();
        }
        DAL_Result dalResult = new DAL_Result();
        void LoadDataResult()
        {
            dtGVResult.DataSource = dalResult.GetResult();
            dtGVResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVResult.Columns[0].Visible = false;
        }
        private void FResult_Load(object sender, EventArgs e)
        {
            LoadDataResult();
        }

        private void btnRemoveResult_Click(object sender, EventArgs e)
        {
            if(dtGVResult.SelectedRows.Count > 0) {
                List<DTO_Result> results = new List<DTO_Result>();
                foreach(DataGridViewRow row in dtGVResult.SelectedRows)
                {
                    DTO_Result result = new DTO_Result((int)row.Cells[0].Value);
                    results.Add(result);
                }
                if (dalResult.RemoveResult(results) > 0)
                {
                    LoadDataResult();
                    MessageBox.Show("Successful!");
                }
                else
                {
                    MessageBox.Show("Unuccessful!");
                }
            }else { MessageBox.Show("Select results to remove"); }
        }

        private void btnRemoveResult_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveResult.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnRemoveResult_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveResult.ForeColor = ColorTranslator.FromHtml("215, 33, 52");
        }
    }
}
