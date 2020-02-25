﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutManagingService.Data.Entities
{
    public class WorkoutPlan
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; }
        public DateTime Created { get; set; }
       
        public ICollection<ExerciseExecutionPlan> ExerciseExecutionPlans { get; set; }
    }
}