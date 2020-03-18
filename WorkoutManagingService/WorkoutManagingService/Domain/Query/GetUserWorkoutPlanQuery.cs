using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManagingService.Domain.DTO;

namespace WorkoutManagingService.Domain.Query
{
    public class GetUserWorkoutPlanQuery : IRequest<WorkoutPlanDTO>
    {
        public string UserId { get; set; }
        public string WorkoutPlanName { get; set; }
        public string RequesterId { get; set; }
    }
}
