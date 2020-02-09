using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManagingService.Domain.Models;

namespace WorkoutManagingService.Domain.Command
{
    public class CreateWorkoutPlanCommand : IRequest<Unit>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public IEnumerable<ExercisePlanModel> Exercises { get; set; }
    }
}
