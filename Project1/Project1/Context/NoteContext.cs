using System;
using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Context
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }
    }
}
