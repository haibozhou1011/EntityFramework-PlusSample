using System;
using System.Windows.Forms;
using EntityFrameworkPlus.DbContext;
using Z.EntityFramework.Plus;

namespace EntityFrameworkPlus.QueryCache.Demo
{
    public partial class AbsoluteExpirationQueryCache : Form
    {
        public AbsoluteExpirationQueryCache()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new EntityFrameworkPlusDbContext())
            {
                var second = Convert.ToDouble(txtAbsoluteExpiration.Text.Trim());
                var absoluteExpirationSecond = DateTime.Now.AddSeconds(second);
                var orders = db.Goodses.FromCache(absoluteExpirationSecond);
                dgList.DataSource = null;
                dgList.DataSource = orders;
            }
        }
    }
}
