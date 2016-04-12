using System.Collections.Generic;
using System.Linq;
using EntityFrameworkPlus.DbContext;
using EntityFrameworkPlus.Models;
using Z.EntityFramework.Plus;

namespace EntityFrameworkPlus.QueryFuture.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.查询订单信息和商品信息
            //FindOrdersWithGoodsies();

            //2. 订单分页查询
            //var totalCount = 0;
            //FindPagerOrders(10, 1, out totalCount);

            //3.查询单价最大和最小的商品
            //FindGoodsMaxWithMinUnitPrice();
        }

        private static void FindOrdersWithGoodsies()
        {
            using (var dbContext = new EntityFrameworkPlusDbContext())
            {
                var futureOrders = dbContext.Orders.Future();
                var futureGoodsies = dbContext.Goodses.Future();
                var orders = futureOrders.ToList();
                var goodsies = futureGoodsies.ToList();
            }
        }

        private static IEnumerable<OrderModel> FindPagerOrders(int pageSize, int pageIndex, out int totalCount)
        {
            using (var dbContext = new EntityFrameworkPlusDbContext())
            {
                var orders = dbContext.Orders.OrderBy(o => o.CreateDateTime);

                var futureCount = orders.DeferredCount().FutureValue();

                var futurePagerOrders = orders.Skip((pageIndex - 1) * pageSize).Take(pageSize).Future();

                totalCount = futureCount.Value;

                return futurePagerOrders.ToList();
            }
        }

        private static void FindGoodsMaxWithMinUnitPrice()
        {
            using (var dbContext = new EntityFrameworkPlusDbContext())
            {
                var futureMaxGoodsUnitPrice = dbContext.Goodses.DeferredMax(g => g.UnitPrice).FutureValue<decimal>();
                var futureMinGoodsUnitPrice = dbContext.Goodses.DeferredMin(g => g.UnitPrice).FutureValue<decimal>();
                var maxGoodsUnitPrice = futureMaxGoodsUnitPrice.Value;
                var minGoodsUnitPrice = futureMaxGoodsUnitPrice.Value;
            }
        }

    }
}
