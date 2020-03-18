using MediatR;
using Microsoft.EntityFrameworkCore;
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
            var workout = await _context.Workouts.FirstAsync(w => w.UserId == command.UserId && w.Name == command.WorkoutName && w.DeactivationDate == null, token);
            workout.DeactivationDate = DateTime.Now;
            await _context.SaveChangesAsync(token);
            return new Unit();
        }
    }
}
