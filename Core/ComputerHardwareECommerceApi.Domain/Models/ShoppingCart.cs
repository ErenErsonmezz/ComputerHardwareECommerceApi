﻿

using ComputerHardwareECommerceApi.Domain.Models.Common;

namespace ComputerHardwareECommerceApi.Domain.Models
{
    public class ShoppingCart:BaseEntity
    {
        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

    }
}
