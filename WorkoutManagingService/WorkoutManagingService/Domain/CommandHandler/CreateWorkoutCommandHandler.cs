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
    public class CreateWorkoutCommandHandler : IRequestHandler<CreateWorkoutCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;
        public CreateWorkoutCommandHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateWorkoutCommand command, CancellationToken token)
        {
            await _context.Workouts.AddAsync(new Workout {
                UserId = command.UserId,
                Name = command.WorkoutName,
                Created = command.CreatedTime,
                Description = command.Description,
                FatigueLevelId = (int)command.FatigueLevel,
                MoodLevelId = (int)command.MoodLevel,
                Executed = command.ExecutionTime,
                ExerciseExecutions = command.ExerciseExecutions
                    .Select(x=> new ExerciseExecution {
                        Order = x.Order,
                        AdditionalKgs = x.AdditionalKgs,
                        Break = x.Break,
                        Description = x.Description,
                        ExerciseId = x.ExerciseId,
                        Repetitions = x.Reps,
                        Series = x.Series
                    })
                    .ToList()
            }, token);
            await _context.SaveChangesAsync(token);
            return new Unit();
        }
    }
}
