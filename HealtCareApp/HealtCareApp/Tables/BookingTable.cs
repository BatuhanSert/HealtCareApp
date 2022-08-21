using System;
namespace HealtCareApp.Tables
{
    public class BookingTable
    {
        public Guid UserId { get; set; }
        public String ProfilePhoto { get; set; }
        public String Speciality { get; set; }
        public String Name { get; set; }
        public String Rating { get; set; }
    }
}
