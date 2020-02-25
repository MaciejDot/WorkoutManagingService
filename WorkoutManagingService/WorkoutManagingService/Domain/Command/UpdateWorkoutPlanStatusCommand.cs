using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManagingService.Domain.Command
{
    public class UpdateWorkoutPlanStatusCommand :IRequest<Unit>
    {
        public int WorkoutId { get; set; }
        public bool IsPublic { get; set; }
    }
}
