using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorkoutManagingService.Data;
using WorkoutManagingService.Domain.Command;

namespace WorkoutManagingService.Domain.CommandHandler
{
    public class UpdateWorkoutPlanStatusCommandHandler : IRequestHandler<UpdateWorkoutPlanStatusCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;
        public UpdateWorkoutPlanStatusCommandHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateWorkoutPlanStatusCommand command, CancellationToken token)
        {
            var workoutPlan = await _context.WorkoutPlans.FindAsync(new[] { command.IsPublic }, token);
            workoutPlan.IsPublic = command.IsPublic;
            await _context.SaveChangesAsync(token);
            return new Unit();
        }

    }
}
