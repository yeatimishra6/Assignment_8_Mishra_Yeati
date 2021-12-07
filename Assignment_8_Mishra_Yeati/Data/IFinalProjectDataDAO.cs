using Assignment_8_Mishra_Yeati.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_8_Mishra_Yeati.Data
{
    public interface IFinalProjectDataDAO
    {
 
            List<Color> GetAllColors();
        List<Favoritebreakfastfoods> GetAllFoods();
        List<Hobby> GetAllHobby();
        List<Info> GetAllInfomation();



        Color GetColorById(int id);
        Color RemoveColorById(int id);
        int? UpdateColor(Color color);
        int? Add(Color color);
        Favoritebreakfastfoods GetFoodById(int id);
        int? UpdateFood(Favoritebreakfastfoods foods);
        int? Add(Favoritebreakfastfoods food);
        Favoritebreakfastfoods RemoveFoodById(int id);
        Hobby GetHobbyById(int id);
        int? UpdateHobby(Hobby muji);
        int? Add(Hobby hobbys);
        Info GetInfomationById(int id);
    }
}
