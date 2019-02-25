using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class VideoGame
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Year { get; set; }
        //public string ImageURL { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}