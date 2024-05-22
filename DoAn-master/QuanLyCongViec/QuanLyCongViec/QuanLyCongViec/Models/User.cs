using System;
using System.Collections.Generic;

namespace QuanLyCongViec.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? PasswordHash { get; set; }
        public bool? IsAdmin { get; set; }
        public int? IdSaffer { get; set; }
    }
}
