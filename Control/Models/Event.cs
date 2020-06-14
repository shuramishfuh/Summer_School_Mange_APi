using System;
using System.ComponentModel.DataAnnotations;
using Control.Interfaces;

namespace Control.Models
{
   public class Event : IEvent
    {
        public short EventId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(550, MinimumLength = 5, ErrorMessage = "Name Should be minimum 5 characters and a maximum of 550 characters")]
        public string EventName { get; set; }
        [DataType(DataType.Url)]
        public string Url { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(2000, MinimumLength = 20, ErrorMessage = "Name Should be minimum 20 characters and a maximum of 2000 characters")]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EventDate { get; set; }
    }
}
