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
    public class CreateWorkoutPlanCommandHandler : IRequestHandler<CreateWorkoutPlanCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;

        public CreateWorkoutPlanCommandHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateWorkoutPlanCommand command, CancellationToken token)
        {
            await _context.WorkoutPlans
                .AddAsync(new WorkoutPlan
                {
                    UserId = command.UserId,
                    User = _context.Users.Find(command.UserId),
                    Created = DateTime.Now,
                    Name = command.Name,
                    Description = command.Description,
                    ExerciseExecutionPlans = command.Exercises
                        .Select(x => new ExerciseExecutionPlan
                        {
                            Order = x.Order,
                            Series = x.Series,
                            Description = x.Description,
                            Break = x.Break,
                            ExerciseId = x.ExerciseId,
                            Exercise = _context.Exercises.Find(x.ExerciseId),
                            MaxAdditionalKgs = x.MaxAdditionalKgs,
                            MinAdditionalKgs = x.MinAdditionalKgs,
                            MaxReps = x.MaxReps,
                            MinReps = x.MinReps
                        })
                        .ToList()
                },
                token);
            await _context.SaveChangesAsync(token);
            return new Unit();
        }

    }
}
