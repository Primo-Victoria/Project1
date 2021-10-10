using System;
using Microsoft.EntityFrameworkCore;
using Project1.Models;
namespace Project1.Context
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<NoteContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
