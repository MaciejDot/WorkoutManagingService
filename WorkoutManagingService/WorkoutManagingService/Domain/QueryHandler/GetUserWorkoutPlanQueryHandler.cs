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
            return _context.WorkoutPlans
                .Where(x => 
                    x.Id == query.WorkoutPlanName && 
                    x.UserId == query.UserId &&
                    x.DeactivationDate == null &&
                    (x.UserId == query.RequesterId || x.IsPublic))
                .Select(x => new WorkoutPlanDTO
                {
                    Name = x.Name,
                    Created = x.Created,
                    Description = x.Description,
                    Exercises = x.WorkoutPlanVersions.OrderByDescending(x=>x.Created).First().ExerciseExecutionPlans.Select(y => new ExercisePlanViewModel
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
                .OrderBy(y => y.Order)
                }).FirstAsync(cancellationToken);
        }
    }
}
