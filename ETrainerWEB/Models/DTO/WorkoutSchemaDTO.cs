﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ETrainerWEB.Models.DTO
{
    public class WorkoutSchemaDTO
    {
        public int Id { set; get; }
        public string Name{ set; get; }
        [JsonIgnore]
        public User User { set; get; }
        [JsonIgnore]
        public ICollection<WorkoutSchemaExerciseSchema> WorkoutSchemasExercisesSchemas { get; set; }
    }
}