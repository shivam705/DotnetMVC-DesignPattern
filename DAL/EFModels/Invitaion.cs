using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.EFModels
{
    public partial class Invitaion
    {
        public int InvitationId { get; set; }
        public string Email { get; set; }
        public int? EventId { get; set; }
    }
}
