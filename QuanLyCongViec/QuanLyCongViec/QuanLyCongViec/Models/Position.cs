using System;
using System.Collections.Generic;

namespace QuanLyCongViec.Models
{
    public partial class Position
    {
        public Position()
        {
            staff = new HashSet<staff>();
        }

        public int Id { get; set; }
        public string? PositionName { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
