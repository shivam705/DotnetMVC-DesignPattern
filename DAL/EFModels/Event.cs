using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.EFModels
{
    public partial class Event
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public string Type { get; set; }
        public int? Duration { get; set; }
        public string Description { get; set; }
        public string OtherDetails { get; set; }
        public string InviteByEmail { get; set; }
        public int Count { get; set; }
        public string CommentAdded { get; set; }
    }
}
