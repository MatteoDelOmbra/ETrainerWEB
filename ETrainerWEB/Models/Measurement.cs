﻿using System;

namespace ETrainerWEB.Models
{
    public class Measurement
    {
        public int Id { set; get; }
        public string Properties { set; get; }
        public DateTime Date { set; get; }
        public User User { set; get; }
    }
}