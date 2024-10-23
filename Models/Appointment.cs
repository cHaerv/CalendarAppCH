using System;

namespace CalendarAppCH.Models
{
    public class Appointment
    {
        public int Id { get; set; } // Primary Key
        public DateTime Start {  get; set; } // start time of appointment
        public DateTime End { get; set; } // End of appointment time
        public string Text { get; set; } // event description or title
    }
}
