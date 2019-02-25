﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<VideoGame> VideoGames { get; set; }
    }
}