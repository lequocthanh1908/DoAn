using System;
using System.Collections.Generic;

namespace QuanLyCongViec.Models
{
    public partial class Task
    {
        public Task()
        {
            Comments = new HashSet<Comment>();
            LogWorks = new HashSet<LogWork>();
        }

        public int Id { get; set; }
        public string? NameTask { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Effort { get; set; }
        public int? IdProject { get; set; }
        public int? IdStaff { get; set; }
        public string? Description { get; set; }
        public string? Img { get; set; }
        public string? Status { get; set; }

        public virtual Project? IdProjectNavigation { get; set; }
        public virtual staff? IdStaffNavigation { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<LogWork> LogWorks { get; set; }
    }
}
