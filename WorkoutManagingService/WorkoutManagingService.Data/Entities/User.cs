using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutManagingService.Data.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public ICollection<Workout> Workouts { get; set; }
    }
}
