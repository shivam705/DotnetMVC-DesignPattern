﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmenttMVC.Model
{
    public class CommentModel
    {
        
        [Key]
        public int CommentId { get; set; }
       
        [Required]
        public string CommentAdded { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        public int EventId { get; set; }
    }
}
