using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManagingService.Domain.Query
{
    public class IsUserWorkoutPlanOwnerQuery : IRequest<bool>
    {
        public string UserId { get; set; }
        public int WorkoutId { get; set; }
    }
}
