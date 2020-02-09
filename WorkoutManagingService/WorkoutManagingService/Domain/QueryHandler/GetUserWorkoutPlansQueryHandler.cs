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
    public class GetUserWorkoutPlansQueryHandler : IRequestHandler<GetUserWorkoutPlansQuery, List<WorkoutPlanThumbnailDTO>>
    {
        private readonly WorkoutManagingServiceContext _context;
        public GetUserWorkoutPlansQueryHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public Task<List<WorkoutPlanThumbnailDTO>> Handle(GetUserWorkoutPlansQuery query, CancellationToken token)
        {
            return _context.Users
                .Where(x => x.Id == query.UserId)
                .SelectMany(x => x.WorkoutPlans)
                .Select(x => new WorkoutPlanThumbnailDTO {
                    Name = x.Name,
                    Description = x.Description,
                    Id= x.Id,
                    Created = x.Created
                })
                .ToListAsync(token);
        }
    }
}
