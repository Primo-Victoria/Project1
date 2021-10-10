using System;
namespace Project1.Models
{
    public class User
    {
        public int id { get; set; }

        public string Login { get; set; }
               
        public string Password { get; set; }

        public int age { get; set; }

        public Blob Avatar { get; set; }


    }
}
