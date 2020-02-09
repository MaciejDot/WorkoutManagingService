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
    public class DeleteWorkoutPlanCommandHandler : IRequestHandler<DeleteWorkoutPlanCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;
        public DeleteWorkoutPlanCommandHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteWorkoutPlanCommand command, CancellationToken cancellationToken)
        {
            _context.ExerciseExecutionPlans.RemoveRange(_context.ExerciseExecutionPlans.Where(x => x.WorkoutPlanId == command.WorkoutId));
            _context.WorkoutPlans.RemoveRange(_context.WorkoutPlans.Where(x => x.Id == command.WorkoutId));
            await _context.SaveChangesAsync(cancellationToken);
            return new Unit();
        }

    }
}
