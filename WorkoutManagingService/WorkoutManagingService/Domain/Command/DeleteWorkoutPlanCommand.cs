using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManagingService.Domain.Command
{
    public class DeleteWorkoutPlanCommand : IRequest<Unit>
    {
        public int WorkoutId { get; set; }
    }
}
