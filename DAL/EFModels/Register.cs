using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.EFModels
{
    public partial class Register
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public IEnumerable<Event> Events { get; internal set; }
    }
}
