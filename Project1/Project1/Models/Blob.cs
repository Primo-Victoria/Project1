using System;
namespace Project1.Models
{
    public class Blob
    {
        public int Id { get; set; }
        public byte[] Content { get; set; }
        public string Extension { get; set; }
    }
}
