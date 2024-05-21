using System;
using System.Collections.Generic;

namespace QuanLyCongViec.Models
{
    public partial class Project
    {
        public Project()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string? NameProject { get; set; }
        public string? NamePm { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
