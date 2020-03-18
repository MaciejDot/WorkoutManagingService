using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutManagingService.Data.Entities
{
    public class Workout
    {
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public ICollection<WorkoutVersion> WorkoutVersions { get; set; }
        public bool IsPublic { get; set; }
    }
}
