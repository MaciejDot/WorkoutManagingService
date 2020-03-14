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
    public class DeleteWorkoutCommandHandler : IRequestHandler<DeleteWorkoutCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;
        public DeleteWorkoutCommandHandler(WorkoutManagingServiceContext context) {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteWorkoutCommand command, CancellationToken token) {
            _context.ExerciseExecutions.RemoveRange(_context.ExerciseExecutions.Where(x => x.WorkoutId == command.WorkoutId));
            _context.Workouts.RemoveRange(_context.Workouts.Where(x => x.Id == command.WorkoutId));
            await _context.SaveChangesAsync(token);
            return new Unit();
        }
    }
}
