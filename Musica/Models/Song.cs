using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Musica.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Duration { get; set; }

        public  string Genero { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]

        public User User { get; set; }

    }
}