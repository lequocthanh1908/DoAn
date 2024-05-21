using System;
using System.Collections.Generic;

namespace QuanLyCongViec.Models
{
    public partial class LogWork
    {
        public int Id { get; set; }
        public int? IdStaff { get; set; }
        public DateTime? Date { get; set; }
        public int? IdTask { get; set; }

        public virtual staff? IdStaffNavigation { get; set; }
        public virtual Task? IdTaskNavigation { get; set; }
    }
}
