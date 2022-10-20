using System;
using System.Collections.Generic;

namespace DeviceManagement.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public string? Password { get; set; }
    }
}
