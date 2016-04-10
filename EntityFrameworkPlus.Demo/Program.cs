using System;
using System.Data.Entity;
using System.Linq;
using EntityFrameworkPlus.DbContext;
using EntityFrameworkPlus.Models;
using Z.EntityFramework.Plus;

namespace EntityFrameworkPlus.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            AuditManager.DefaultConfiguration.AutoSavePreAction = (context, audit) =>
            {
                var customAuditEntries = audit.Entries.Select(x => Import(x));
                (context as EntityFrameworkPlusDbContext).AuditEntries.AddRange(customAuditEntries);
            };

            AddOrder();
        }
        public static void AddOrder()
        {
            using (var dbContext = new EntityFrameworkPlusDbContext())
            {
                var audit = new Audit { CreatedBy = "david" };
                dbContext.Orders.Add(new OrderModel
                {
                    OrderNo = "ORDER0001",
                    OrderCreator = "david",
                    OrderDateTime = DateTime.Now,
                    OrderStatus = "已出库",
                    Creator = "david",
                    CreateDateTime = DateTime.Now
                });
                dbContext.SaveChanges(audit);
            }
        }
        public static void UpdateOrder()
        {
            using (var dbContext = new EntityFrameworkPlusDbContext())
            {
                var audit = new Audit { CreatedBy = "david" };
                var orderAsync = dbContext.Orders.FirstAsync();
                var order = orderAsync.Result;
                order.LastModifier = "davidzhou";
                order.LastModifiedDateTime = DateTime.Now;
                order.OrderStatus = "已完成";
                dbContext.Entry(order);
                dbContext.SaveChanges(audit);
            }
        }
        public static void DeleteOrder()
        {
            using (var dbContext = new EntityFrameworkPlusDbContext())
            {
                var audit = new Audit { CreatedBy = "david" };
                var orderAsync = dbContext.Orders.FirstAsync();
                var order = orderAsync.Result;
                dbContext.Entry(order).State = EntityState.Deleted;
                dbContext.SaveChanges(audit);
            }
        }

        public static AuditEntry Import(AuditEntry entry)
        {
            var customAuditEntry = new AuditEntry
            {
                EntitySetName = entry.EntitySetName,
                EntityTypeName = entry.EntityTypeName,
                State = entry.State,
                StateName = entry.StateName,
                CreatedBy = entry.CreatedBy,
                CreatedDate = entry.CreatedDate
            };
            customAuditEntry.Properties = entry.Properties.Select(x => Import(x)).ToList();

            return customAuditEntry;
        }
        public static AuditEntryProperty Import(AuditEntryProperty property)
        {
            var customAuditEntry = new AuditEntryProperty
            {
                RelationName = property.RelationName,
                PropertyName = property.PropertyName,
                OldValue = property.OldValueFormatted,
                NewValue = property.NewValueFormatted
            };
            return customAuditEntry;
        }
    }
}
