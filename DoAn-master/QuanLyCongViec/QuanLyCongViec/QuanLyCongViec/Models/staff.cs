using System;
using System.Collections.Generic;

namespace QuanLyCongViec.Models
{
    public partial class staff
    {
        public staff()
        {
            LogWorks = new HashSet<LogWork>();
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string? StaffName { get; set; }
        public int? IdPosition { get; set; }
        public string? Gmail { get; set; }
        public string? NumberPhone { get; set; }
        public string? AddressStaff { get; set; }

        public virtual Position? IdPositionNavigation { get; set; }
        public virtual ICollection<LogWork> LogWorks { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
