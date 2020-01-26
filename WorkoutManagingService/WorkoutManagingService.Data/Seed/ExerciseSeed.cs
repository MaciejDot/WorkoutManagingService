using System;
using System.Collections.Generic;
using System.Text;
using WorkoutManagingService.Data.Entities;

namespace WorkoutManagingService.Data.Seed
{
    public class ExerciseSeed
    {
        public IEnumerable<Exercise> Exercises()
        {
            yield return new Exercise { Id = 1, Name = "Full Planche", IsHold = true };
            yield return new Exercise { Id = 2, Name = "Full Front Lever", IsHold = true };
            yield return new Exercise { Id = 3, Name = "Regular Pull Ups", IsHold = true };
            yield return new Exercise { Id = 3, Name = "Regular Chin Ups", IsHold = true };
        }
    }
}
