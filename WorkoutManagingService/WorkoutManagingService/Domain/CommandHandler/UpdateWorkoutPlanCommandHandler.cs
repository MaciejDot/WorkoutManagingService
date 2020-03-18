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
    public class UpdateWorkoutPlanCommandHandler : IRequestHandler<UpdateWorkoutPlanCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;

        public UpdateWorkoutPlanCommandHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateWorkoutPlanCommand command, CancellationToken token)
        {
            var workoutId = (await _context.WorkoutPlans.FirstAsync(r => r.Name == command.WorkoutName && r.UserId == command.UserId && r.DeactivationDate == null)).Id;
            await _context.WorkoutPlanVersions.AddAsync(new WorkoutPlanVersion
            {
                Created = DateTime.Now,
                ExerciseExecutionPlans = command.Exercises
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
                     .ToList()
            }, token);
            await _context.SaveChangesAsync(token);
            return new Unit();
        }
    }
}
