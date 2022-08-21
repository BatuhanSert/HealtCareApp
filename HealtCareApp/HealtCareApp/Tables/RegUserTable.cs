using System;
namespace HealtCareApp.Tables
{
    public class RegUserTable
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Dob { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
    }
}
