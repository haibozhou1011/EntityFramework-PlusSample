using System;
using System.Runtime.Caching;
using System.Windows.Forms;
using EntityFrameworkPlus.DbContext;
using Z.EntityFramework.Plus;

namespace EntityFrameworkPlus.QueryCache.Demo
{
    public partial class SlidingExpirationQueryCache : Form
    {
        public SlidingExpirationQueryCache()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new EntityFrameworkPlusDbContext())
            {
                var second = Convert.ToDouble(txtSlidingExpiration.Text.Trim());
                var options = new CacheItemPolicy() { SlidingExpiration = TimeSpan.FromSeconds(second) };
                var orders = db.Goodses.FromCache(options);
                dgList.DataSource = null;
                dgList.DataSource = orders;
            }
        }
    }
}
