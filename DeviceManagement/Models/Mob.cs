using System;
using System.Collections.Generic;

namespace DeviceManagement.Models
{
    public partial class Mob
    {
        public int MobId { get; set; }
        public string Model { get; set; } = null!;
        public int Quantity { get; set; }
        public int? Price { get; set; }
    }
}
