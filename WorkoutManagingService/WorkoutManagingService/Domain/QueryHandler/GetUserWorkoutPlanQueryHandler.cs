using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorkoutManagingService.Data;
using WorkoutManagingService.Domain.DTO;
using WorkoutManagingService.Domain.Models;
using WorkoutManagingService.Domain.Query;

namespace WorkoutManagingService.Domain.QueryHandler
{
    public class GetUserWorkoutPlanQueryHandler : IRequestHandler<GetUserWorkoutPlanQuery, WorkoutPlanDTO>
    {
        private readonly WorkoutManagingServiceContext _context;
        public GetUserWorkoutPlanQueryHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public Task<WorkoutPlanDTO> Handle(GetUserWorkoutPlanQuery query, CancellationToken cancellationToken)
        {
            return _context.WorkoutPlans.Select(x => new WorkoutPlanDTO
            {
                Id = x.Id,
                Name = x.Name,
                Created = x.Created,
                Description = x.Description,
                Exercises = x.ExerciseExecutionPlans.Select(y => new ExercisePlanViewModel
                {
                    Series = y.Series,
                    MinReps = y.MinReps,
                    MaxReps = y.MaxReps,
                    MinAdditionalKgs = y.MinAdditionalKgs,
                    MaxAdditionalKgs = y.MaxAdditionalKgs,
                    ExerciseId = y.ExerciseId,
                    ExerciseName = y.Exercise.Name,
                    Order = y.Order,
                    Description = y.Description,
                    Break = y.Break
                })
            }).FirstAsync(cancellationToken);
        }
    }
}
