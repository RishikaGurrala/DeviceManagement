using System;
using System.Collections.Generic;

namespace DeviceManagement.Models
{
    public partial class Order
    {
        public int OrderDetailsId { get; set; }
        public string? OrderNo { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? UserId { get; set; }
        public string? Status { get; set; }

        public virtual Product? Product { get; set; }
        public virtual User? User { get; set; }
    }
}
