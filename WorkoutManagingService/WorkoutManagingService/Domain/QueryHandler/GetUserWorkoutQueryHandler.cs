using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorkoutManagingService.Data;
using WorkoutManagingService.Domain.DTO;
using WorkoutManagingService.Domain.Query;

namespace WorkoutManagingService.Domain.QueryHandler
{
    public class GetUserWorkoutQueryHandler : IRequestHandler<GetUserWorkoutQuery, WorkoutDTO>
    {
        private readonly WorkoutManagingServiceContext _context;
        public GetUserWorkoutQueryHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public Task<WorkoutDTO> Handle(GetUserWorkoutQuery query, CancellationToken token)
        {
            return _context.Workouts
                .Where(x => x.DeactivationDate == null &&
                    x.Name == query.WorkoutName &&
                    x.UserId == query.UserId && 
                    (x.IsPublic || x.UserId == query.RequesterId))
                .Select(x => new WorkoutDTO
                {
                    Mood = (int) x.WorkoutVersions.OrderByDescending(r=>r.Created).First().MoodLevelId,
                    Fatigue = (int) x.WorkoutVersions.OrderByDescending(r => r.Created).First().FatigueLevelId,
                    Name = x.Name,
                    Description = x.Description,
                    DateOfWorkout = x.WorkoutVersions.OrderByDescending(r => r.Created).First().Executed,
                    Exercises = x.WorkoutVersions.OrderByDescending(r => r.Created).First().ExerciseExecutions
                    .Select(x => new SendExerciseExecutionDTO
                    {
                        AdditionalKgs = x.AdditionalKgs,
                        Break = x.Break,
                        Description = x.Description,
                        ExerciseId = x.ExerciseId,
                        Order = x.Order,
                        Reps = x.Repetitions,
                        Series = x.Series,
                        Name = x.Exercise.Name
                    })
                })
                .FirstAsync(token);
        }
    }
}
