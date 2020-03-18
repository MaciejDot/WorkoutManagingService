using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public class UpdateWorkoutCommandHandler : IRequestHandler<UpdateWorkoutCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;

        public UpdateWorkoutCommandHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateWorkoutCommand command, CancellationToken token)
        {
            var workoutId = (await _context.Workouts.FirstAsync(r => r.Name == command.WorkoutName && r.UserId == command.UserId && r.DeactivationDate == null)).Id;
            await _context.WorkoutVersions.AddAsync(new WorkoutVersion
            {
                Created = DateTime.Now,
                Executed = command.ExecutionTime,
                FatigueLevelId = (int)command.FatigueLevel,
                MoodLevelId = (int)command.MoodLevel,
                ExerciseExecutions = command.ExerciseExecutions
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
                     .ToList()
            }, token);
            await _context.SaveChangesAsync(token);
            return new Unit();
        }
    }
}
