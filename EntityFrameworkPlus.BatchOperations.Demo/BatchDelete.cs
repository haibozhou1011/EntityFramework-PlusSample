using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using EntityFrameworkPlus.DbContext;
using EntityFrameworkPlus.Models;
using Z.EntityFramework.Plus;

namespace EntityFrameworkPlus.BatchOperations.Demo
{
    public partial class BatchDelete : Form
    {
        public BatchDelete()
        {
            InitializeComponent();
            SearchGood();
        }
        public void SearchGood()
        {
            using (var db = new EntityFrameworkPlusDbContext())
            {
                dgvList.DataSource = db.Goodses.ToList();
            }
        }
        private void btnDeleteWithSearch_Click(object sender, EventArgs e)
        {
            using (var db = new EntityFrameworkPlusDbContext())
            {
                var unitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                // ReSharper disable once NotAccessedVariable
                Expression<Func<GoodsModel, bool>> whereExpression = null;
                if (cbxOperation.Text.Equals("="))
                {
                    whereExpression = d => d.UnitPrice == unitPrice;
                }
                if (cbxOperation.Text.Equals(">="))
                {
                    whereExpression = d => d.UnitPrice >= unitPrice;
                }
                if (cbxOperation.Text.Equals(">"))
                {
                    whereExpression = d => d.UnitPrice > unitPrice;
                }
                if (cbxOperation.Text.Equals("<="))
                {
                    whereExpression = d => d.UnitPrice <= unitPrice;
                }
                if (cbxOperation.Text.Equals("<"))
                {
                    whereExpression = d => d.UnitPrice < unitPrice;
                }

                db.Goodses.Where(whereExpression).Delete();
            }
            SearchGood();
        }


    }
}
