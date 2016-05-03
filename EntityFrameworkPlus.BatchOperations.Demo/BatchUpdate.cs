using System;
using System.Linq;
using System.Windows.Forms;
using EntityFrameworkPlus.DbContext;
using EntityFrameworkPlus.Models;
using Z.EntityFramework.Plus;

namespace EntityFrameworkPlus.BatchOperations.Demo
{
    public partial class BatchUpdate : Form
    {
        public BatchUpdate()
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

        private void btnUpdateWithSearch_Click(object sender, EventArgs e)
        {
            var creator = txtCreator.Text.Trim();
            var unitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim()) ;
            using (var db = new EntityFrameworkPlusDbContext())
            {
                db.Goodses.Where(c => c.Creator.Equals(creator)).Update(c => new GoodsModel {UnitPrice = unitPrice});
            }
            SearchGood();
        }
    }
}
