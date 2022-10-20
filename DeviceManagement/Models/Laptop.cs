using System;
using System.Collections.Generic;

namespace DeviceManagement.Models
{
    public partial class Laptop
    {
        public int LapId { get; set; }
        public string Model { get; set; } = null!;
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public string? Description { get; set; }
    }
}
