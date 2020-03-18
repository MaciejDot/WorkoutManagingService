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
    public class GetUserWorkoutsQueryHandler : IRequestHandler<GetUserWorkoutsQuery, List<WorkoutThumbnailDTO>>
    {
        private readonly WorkoutManagingServiceContext _context;
        public GetUserWorkoutsQueryHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public Task<List<WorkoutThumbnailDTO>> Handle(GetUserWorkoutsQuery query, CancellationToken token)
        {
            return _context.Workouts
                .Where(x => x.DeactivationDate == null && x.UserId == query.UserId)
                .Select(x=> new WorkoutThumbnailDTO {
                    Created = x.Created,
                    Description = x.Description,
                    Executed = x.WorkoutVersions.OrderByDescending(d=>d.Created).First().Executed,
                    Name = x.Name,
                    Mood = x.WorkoutVersions.OrderByDescending(d => d.Created).First().MoodLevelId,
                    Fatigue = x.WorkoutVersions.OrderByDescending(d => d.Created).First().FatigueLevelId
                })
                .ToListAsync(token);
        }
    }
}
