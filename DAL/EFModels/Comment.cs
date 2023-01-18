using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.EFModels
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string CommentAdded { get; set; }
        public DateTime Date { get; set; }
        public int EventId { get; set; }
    }
}
