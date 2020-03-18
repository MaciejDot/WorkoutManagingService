using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManagingService.Domain.Command
{
    public class DeleteWorkoutCommand : IRequest<Unit>
    {
        public string WorkoutName { get; set; }
        public string UserId { get; set; }
    }
}
