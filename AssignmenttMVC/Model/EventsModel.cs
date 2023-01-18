using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AssignmenttMVC.Model
{
    public class EventsModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId { get; set; }

        public int EventId { get; set; }

     
        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Location")]
        [Required]
        public string Location { get; set; }

        [Display(Name = "Start Time")]
        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm }", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }


        
        [Display(Name = "Public/Private")]
        public string Type { get; set; }

        [Display(Name = "Duration In Hours")]
        [Range(0, 4)]
        public int? Duration { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(500)]
        [Display(Name = "Other Details")]
        public string OtherDetails { get; set; }

        [Display(Name = "Invite Others")]
        public string InviteByEmail { get; set; }

        public int Count { get; set; }

        public string CommentAdded { get; set; }

        
    }
}
