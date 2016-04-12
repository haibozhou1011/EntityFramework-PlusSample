using System;

namespace EntityFrameworkPlus.Models
{
    public class GoodsModel
    {
        public System.Guid GoodsGuid { get; set; }
        public string GoodsNo { get; set; }
        public string GoodsName { get; set; }
        public string GoodsBrand { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDateTime { get; set; }
        public string LastModifier { get; set; }
        public DateTime? LastModifiedDateTime { get; set; } 
    }
}