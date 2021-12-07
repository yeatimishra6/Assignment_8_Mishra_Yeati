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
                new Color { id = 1, schoolColor = "Blue", memberCommonFavColor = "Yellow", numberOfColorInSchoolLogo = 6, peopleInTheTeam = 8 },
                new Color { id = 2, schoolColor = "Red", memberCommonFavColor = "Blue", numberOfColorInSchoolLogo = 3, peopleInTheTeam = 2 }
                );
            builder.Entity<Hobby>().HasData(
                new Hobby { id = 4, favMovie = "muji", favPlaceToTravel = "Nepal", favSport = "Soccer", freeTimeActivity = "Drinking with friends"}
                );
            builder.Entity<Favoritebreakfastfoods>().HasData(
                new Favoritebreakfastfoods { id = 5, favBreakfastPlace = "Ihop", pancakeOrWaffle = "Waffle", typeOfDrink = "Coke", typeOfEggsYouLike = "raw"}
                );
            builder.Entity<Info>().HasData(
                new Info { id = 7, birthDay = "Fab-12", collegeProgram = "IT", collegeYear = "Senior", teamName = "YAAAAAAA"}

                );

        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Favoritebreakfastfoods> breakfastFood { get; set; }
        public DbSet<Hobby> hobbies { get; set; }

        public DbSet<Info> information { get; set; }
    }
}