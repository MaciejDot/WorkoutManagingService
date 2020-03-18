using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManagingService.Domain.DTO
{
    public class WorkoutThumbnailDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Executed { get; set; }
        public int Mood { get; set; }
        public int Fatigue { get; set; }
    }
}
