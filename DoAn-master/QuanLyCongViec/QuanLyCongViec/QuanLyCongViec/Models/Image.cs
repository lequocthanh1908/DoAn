using System;
using System.Collections.Generic;

namespace QuanLyCongViec.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public string? PathImg { get; set; }
        public int? IdComment { get; set; }

        public virtual Comment? IdCommentNavigation { get; set; }
    }
}
