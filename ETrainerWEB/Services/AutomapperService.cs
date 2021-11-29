﻿using AutoMapper;
using ETrainerWEB.Models;
using ETrainerWEB.Models.DTO;

namespace ETrainerWEB.Services
{
    public class AutomapperService
    {
        public readonly IMapper Mapper;
        public AutomapperService()
        {
            var configuration = new MapperConfiguration(cfg => 
            {
            
                cfg.CreateMap<Workout, WorkoutDTO>();
                cfg.CreateMap<WorkoutDTO, Workout>();
                cfg.CreateMap<Exercise, ExerciseDTO>();
                cfg.CreateMap<ExerciseDTO, Exercise>();
                cfg.CreateMap<ExerciseType, ExerciseTypeDTO>();
                cfg.CreateMap<ExerciseTypeDTO, ExerciseType>();
                cfg.CreateMap<ExerciseSchema, ExerciseSchemaDTO>();
                cfg.CreateMap<ExerciseSchemaDTO, ExerciseSchema>();
                cfg.CreateMap<WorkoutSchema, WorkoutSchemaDTO>();
                cfg.CreateMap<WorkoutSchemaDTO, WorkoutSchema>();
                cfg.CreateMap<WorkoutSchemaExerciseSchema, WorkoutSchemaExerciseSchemaDTO>();
                cfg.CreateMap<WorkoutSchemaExerciseSchemaDTO, WorkoutSchemaExerciseSchema>();
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<Measurement, MeasurementDTO>();
                cfg.CreateMap<MeasurementDTO, Measurement>(); 
                cfg.CreateMap<Meal, MealDTO>();
                cfg.CreateMap<MealDTO, Meal>();
                cfg.CreateMap<Dish, DishDTO>();
                cfg.CreateMap<DishDTO, Dish>();
                cfg.CreateMap<MealsDishes, MealsDishesDTO>();
                cfg.CreateMap<MealsDishesDTO, MealsDishes>();

            });

            Mapper = configuration.CreateMapper();
        }
        
    }
}