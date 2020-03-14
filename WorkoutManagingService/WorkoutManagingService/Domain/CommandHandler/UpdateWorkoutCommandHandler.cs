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
    public class UpdateWorkoutCommandHandler :IRequestHandler<UpdateWorkoutCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;

        public UpdateWorkoutCommandHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateWorkoutCommand command, CancellationToken token)
        {
            _context.ExerciseExecutions.RemoveRange(_context.ExerciseExecutions.Where(x => x.WorkoutId == command.WorkoutId));
            var workout = await _context.Workouts.FindAsync(new[] { command.WorkoutId }, token);
            workout.Executed = command.ExecutionTime;
            workout.FatigueLevelId = (int) command.FatigueLevel;
            workout.MoodLevelId = (int) command.MoodLevel;
            workout.Name = command.WorkoutName;
            workout.Description = command.Description;
            workout.ExerciseExecutions = command.ExerciseExecutions
                     .Select(x => new ExerciseExecution
                     {
                         Order = x.Order,
                         Series = x.Series,
                         Description = x.Description,
                         Break = x.Break,
                         ExerciseId = x.ExerciseId,
                         Repetitions = x.Reps,
                         AdditionalKgs = x.AdditionalKgs,
                     })
                     .ToList();
            await _context.SaveChangesAsync(token);
            return new Unit();
        }
    }
}
