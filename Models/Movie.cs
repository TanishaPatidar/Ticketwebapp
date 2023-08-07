﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Ticketwebapp.Data;

namespace Ticketwebapp.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationships

        public List<Actor_Movie>Actor_Movies { get; set; }

        //cinema
   
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }

        //Producer

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]

        public Producer Producer { get; set; }
     
    }
}
