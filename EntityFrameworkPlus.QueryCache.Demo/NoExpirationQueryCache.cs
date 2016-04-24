using System;
using System.Windows.Forms;
using EntityFrameworkPlus.DbContext;
using Z.EntityFramework.Plus;

namespace EntityFrameworkPlus.QueryCache.Demo
{
    public partial class NoExpirationQueryCache : Form
    {
        public NoExpirationQueryCache()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new EntityFrameworkPlusDbContext())
            {
                var orders = db.Goodses.FromCache();
                dgList.DataSource = null;
                dgList.DataSource = orders;
            }
        }
    }
}
