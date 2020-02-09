using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorkoutManagingService.Data;
using WorkoutManagingService.Domain.Query;

namespace WorkoutManagingService.Domain.QueryHandler
{
    public class IsUserWorkoutPlanOwnerQueryHandler :IRequestHandler<IsUserWorkoutPlanOwnerQuery, bool>
    {
        private readonly WorkoutManagingServiceContext _context;
        public IsUserWorkoutPlanOwnerQueryHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public Task<bool> Handle(IsUserWorkoutPlanOwnerQuery query, CancellationToken token)
        {
            return _context.WorkoutPlans.AnyAsync(x => x.Id == query.WorkoutId && x.UserId == query.UserId, token);
        }
    }
}
