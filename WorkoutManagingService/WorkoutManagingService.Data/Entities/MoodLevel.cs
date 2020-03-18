using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutManagingService.Data.Entities
{
    public class MoodLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<WorkoutVersion> WorkoutVersions { get; set; }
    }
}
