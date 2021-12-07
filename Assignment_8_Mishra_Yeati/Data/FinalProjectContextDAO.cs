using Assignment_8_Mishra_Yeati.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_8_Mishra_Yeati.Data
{
    public class FinalProjectContextDAO : IFinalProjectDataDAO
    {
        private FinalProjectData _context;
        public FinalProjectContextDAO(FinalProjectData context) 
        {
            _context = context;
        }

        public int? Add(Color color)
        {
            var colors = _context.Colors.Where(x => x.schoolColor.Equals(color.schoolColor) && x.schoolColor.Equals(color.id)).FirstOrDefault();
            if (color == null) 
            {
                return null;
            }
            try
            {
                _context.Colors.Add(color);
                _context.SaveChanges();
                return 1;
            }

            catch (Exception) 
            {
                return 0;
            }
        }

        public int? Add(Favoritebreakfastfoods food)
        {
            var foods = _context.breakfastFood.Where(x => x.typeOfEggsYouLike.Equals(food.typeOfEggsYouLike) && x.typeOfDrink.Equals(food.typeOfDrink) && x.pancakeOrWaffle.Equals(food.pancakeOrWaffle) && x.favBreakfastPlace.Equals(food.favBreakfastPlace) && x.id.Equals(food.id)).FirstOrDefault();
            if (foods == null)
            {
                return null;
            }
            try
            {
                _context.breakfastFood.Add(foods);
                _context.SaveChanges();
                return 1;
            }

            catch (Exception)
            {
                return 0;
            }
        }

        public int? Add(Hobby hobbys)
        {
            var result = _context.hobbies.Where(x => x.favMovie.Equals(hobbys.favMovie) && x.favPlaceToTravel.Equals(hobbys.favPlaceToTravel) && x.favSport.Equals(hobbys.favSport) && x.freeTimeActivity.Equals(hobbys.freeTimeActivity)).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            try
            {
                _context.hobbies.Add(result);
                _context.SaveChanges();
                return 1;
            }

            catch (Exception)
            {
                return 0;
            }
        }

        public List<Color> GetAllColors() 
        {
            return _context.Colors.ToList();
        }

        public List<Favoritebreakfastfoods> GetAllFoods()
        {
            return _context.breakfastFood.ToList();
        }

        public List<Hobby> GetAllHobby()
        {
            return _context.hobbies.ToList();
        }

        public List<Info> GetAllInfomation()
        {
            return _context.information.ToList();
        }

        public Color GetColorById(int id)
        {
            return _context.Colors.Where(X => X.id.Equals(id)).FirstOrDefault();
        }

        public Favoritebreakfastfoods GetFoodById(int id)
        {
            return _context.breakfastFood.Where(X => X.id.Equals(id)).FirstOrDefault();
        }

        public Hobby GetHobbyById(int id)
        {
            return _context.hobbies.Where(X => X.id.Equals(id)).FirstOrDefault();
        }

        public Info GetInfomationById(int id)
        {
            return _context.information.Where(X => X.id.Equals(id)).FirstOrDefault();
        }

        public Color RemoveColorById(int id)
        {
            var color = this.GetColorById(id);
            if (color == null) return null;
            try
            {
                _context.Colors.Remove(color);
                _context.SaveChanges();
                return color;
            }
           catch(Exception)
            {
                return new Color();
            }
        }

        public Favoritebreakfastfoods RemoveFoodById(int id)
        {
            var food = this.GetFoodById(id);
            if (food == null) return null;
            try
            {
                _context.breakfastFood.Remove(food);
                _context.SaveChanges();
                return food;
            }
            catch (Exception)
            {
                return new Favoritebreakfastfoods();
            }
        }

        public int? UpdateColor(Color color)
        {
            var colorToUpdate = this.GetColorById(color.id);
            if (colorToUpdate == null) 
            {
                return null;
                colorToUpdate.memberCommonFavColor = color.memberCommonFavColor;
                colorToUpdate.numberOfColorInSchoolLogo = color.numberOfColorInSchoolLogo;
                colorToUpdate.peopleInTheTeam = color.peopleInTheTeam;
                colorToUpdate.schoolColor = color.schoolColor;
                colorToUpdate.id = color.id;
            }
            colorToUpdate = color;
            try
            {
                _context.Colors.Update(colorToUpdate);
                _context.SaveChanges();
                return 1;
            }

            catch (Exception ex) 
            {
                return 0;
            }
        }

        public int? UpdateFood(Favoritebreakfastfoods foods)
        {
            var FoodToUpdate = this.GetFoodById(foods.id);
            if (FoodToUpdate == null)
            {
                return null;
                FoodToUpdate.favBreakfastPlace = foods.favBreakfastPlace;
                FoodToUpdate.pancakeOrWaffle = foods.pancakeOrWaffle;
                FoodToUpdate.typeOfDrink = foods.typeOfDrink;
                FoodToUpdate.typeOfEggsYouLike = foods.typeOfEggsYouLike;
                FoodToUpdate.id = foods.id;
            }
            FoodToUpdate = foods;
            try
            {
                _context.breakfastFood.Update(FoodToUpdate);
                _context.SaveChanges();
                return 1;
            }

            catch (Exception)
            {
                return 0;
            }

        }

        public int? UpdateHobby(Hobby muji)
        {
            var hobbyToUpdate = this.GetHobbyById(muji.id);
            if (hobbyToUpdate == null)
            {
                return null;
                hobbyToUpdate.favMovie = hobbyToUpdate.favMovie;
                hobbyToUpdate.favPlaceToTravel = hobbyToUpdate.favPlaceToTravel;
                hobbyToUpdate.favSport = hobbyToUpdate.favSport;
                hobbyToUpdate.freeTimeActivity = hobbyToUpdate.freeTimeActivity;
                hobbyToUpdate.id = hobbyToUpdate.id;
            }
            hobbyToUpdate = muji;
            try
            {
                _context.hobbies.Update(hobbyToUpdate);
                _context.SaveChanges();
                return 1;
            }

            catch (Exception )
            {
                return 0;
            }
        }
    }
}

