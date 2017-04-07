//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketApp_usingEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Ticket
    {
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Username must be minimum 5 characters.")]
        [Required(ErrorMessage = "{0} is mandatory.")]
        public string Username { get; set; }
        public string ProblemDescription { get; set; }
        [Required(ErrorMessage = "{0} is mandatory.")]
        public string Priority { get; set; }
        [Required(ErrorMessage = "{0} is mandatory.")]
        public string Status { get; set; }
        public string Comments { get; set; }
        public string Resolution { get; set; }
        public Nullable<System.DateTime> DateResolved { get; set; }
        public Nullable<System.DateTime> DateOpened { get; set; }
        public Nullable<System.DateTime> DateClosed { get; set; }
        public string IsClosed { get; set; }
    }
}
