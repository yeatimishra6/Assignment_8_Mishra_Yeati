using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_8_Mishra_Yeati.Models
{
    public class FinalProjectData : DbContext 
    {
        public FinalProjectData(DbContextOptions<FinalProjectData> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Color>().HasData(
                new Color { Id = 1, schoolColor = "Blue", memberCommonFavColor = "Yellow", numberOfColorInSchoolLogo = 6, peopleInTheTeam = 8 },
                new Color { Id = 2, schoolColor = "Red", memberCommonFavColor = "Blue", numberOfColorInSchoolLogo = 3, peopleInTheTeam = 2 }
                );
            builder.Entity<Hobby>().HasData(
                new Hobby { }
                );
            builder.Entity<Favoritebreakfastfoods>().HasData(
                new Favoritebreakfastfoods { }
                );
            builder.Entity<Info>().HasData(
                new Info { }

                );

        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Favoritebreakfastfoods> breakfastFood { get; set; }
        public DbSet<Hobby> hobbies { get; set; }

        public DbSet<Info> information { get; set; }
    }
}