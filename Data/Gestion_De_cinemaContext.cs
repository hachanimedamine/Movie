
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gestion_De_cinema.Models;

namespace Gestion_De_cinema.Data
{
    public class Gestion_De_cinemaContext : DbContext
    {
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        public Gestion_De_cinemaContext(DbContextOptions<Gestion_De_cinemaContext> options)
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
            : base(options)
        {
        }

        public DbSet<Gestion_De_cinema.Models.Movie> Movie { get; set; }
    }
}
