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
    public class DeleteWorkoutPlanCommandHandler : IRequestHandler<DeleteWorkoutPlanCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;
        public DeleteWorkoutPlanCommandHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteWorkoutPlanCommand command, CancellationToken cancellationToken)
        {
            var workout = await _context.WorkoutPlans.FirstAsync(w => w.UserId == command.UserId && w.Name == command.WorkoutName && w.DeactivationDate == null, cancellationToken);
            workout.DeactivationDate = DateTime.Now; 
            await _context.SaveChangesAsync(cancellationToken);
            return new Unit();
        }

    }
}
