﻿namespace ETrainerWEB.Models.DTO
{
    public class MealsDishesDTO
    {
        public int Id { set; get; }
        public int MealId { set; get; }
        public int DishId { set; get; }
        public double Amount { set; get; }
    }
}