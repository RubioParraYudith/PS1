using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Musica.Models
{
    public class MusicDbContext:DbContext
    {
        public MusicDbContext() : base("MyConnection")
        {

        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<User> Users { get; set; }

    }
}