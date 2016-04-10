using System;

namespace EntityFrameworkPlus.Models
{
    public class OrderModel
    {
        public Guid OrderGuid { get; set; }
        public string OrderNo { get; set; }
        public string OrderCreator { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string OrderStatus { get; set; }
        public string Description { get; set; }
        public string Creator { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastModifier { get; set; }
        public DateTime? LastModifiedDateTime { get; set; } 
    }
}