using Microsoft.AspNetCore.Mvc.Rendering;
using Gestion_De_cinema.Models;
using System.Collections.Generic;

namespace Gestion_De_cinema.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
