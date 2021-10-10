using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Controllers
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options)
            : base(options)  
        {
            
        }

        public DbSet<Note> Notes { get; set; }
    }
}
