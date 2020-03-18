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
            return _context.WorkoutPlans
                .Where(x => x.DeactivationDate == null && x.UserId == query.UserId)
                .Select(x => new WorkoutPlanThumbnailDTO {
                    Name = x.Name,
                    Description = x.Description,
                    Created = x.Created
                })
                .ToListAsync(token);
        }
    }
}
