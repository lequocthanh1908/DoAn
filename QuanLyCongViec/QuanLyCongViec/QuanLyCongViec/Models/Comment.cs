using System;
using System.Collections.Generic;

namespace QuanLyCongViec.Models
{
    public partial class Comment
    {
        public Comment()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }
        public int? IdTask { get; set; }
        public string? Description { get; set; }

        public virtual Task? IdTaskNavigation { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
