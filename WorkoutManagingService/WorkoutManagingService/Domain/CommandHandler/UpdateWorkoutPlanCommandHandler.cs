using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorkoutManagingService.Data;
using WorkoutManagingService.Data.Entities;
using WorkoutManagingService.Domain.Command;

namespace WorkoutManagingService.Domain.CommandHandler
{
    public class UpdateWorkoutPlanCommandHandler : IRequestHandler<UpdateWorkoutPlanCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;

        public UpdateWorkoutPlanCommandHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateWorkoutPlanCommand command, CancellationToken token)
        {
            _context.ExerciseExecutionPlans.RemoveRange(_context.ExerciseExecutionPlans.Where(x => x.WorkoutPlanId == command.WorkoutId));
            var workout = await _context.WorkoutPlans.FindAsync(new[] { command.WorkoutId }, token);
            workout.Name = command.Name;
            workout.Description = command.Description;
            workout.ExerciseExecutionPlans = command.Exercises
                     .Select(x => new ExerciseExecutionPlan
                     {
                         Order = x.Order,
                         Series = x.Series,
                         Description = x.Description,
                         Break = x.Break,
                         ExerciseId = x.ExerciseId,
                         MaxAdditionalKgs = x.MaxAdditionalKgs,
                         MinAdditionalKgs = x.MinAdditionalKgs,
                         MaxReps = x.MaxReps,
                         MinReps = x.MinReps
                     })
                     .ToList();
            await _context.SaveChangesAsync(token);
            return new Unit();
        }
    }
}
