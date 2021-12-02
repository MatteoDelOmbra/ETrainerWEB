﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace ETrainerWEB.Models
{
    public class Workout
    {
        public Workout()
        {
            Exercises = new List<Exercise>();
        }
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public User User { set; get; }
        public ICollection<Exercise> Exercises { get; set; }

    }
}
