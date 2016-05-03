using System;
using System.Windows.Forms;

namespace EntityFrameworkPlus.BatchOperations.Demo
{
    public partial class BatchOperations : Form
    {
        public BatchOperations()
        {
            InitializeComponent();
        }

        private void btnBatchUpdate_Click(object sender, EventArgs e)
        {
            new BatchUpdate().ShowDialog();
        }

        private void btnBatchDelete_Click(object sender, EventArgs e)
        {
            new BatchDelete().ShowDialog();
        }
    }
}
