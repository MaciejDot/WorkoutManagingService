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
    public class IsUserWorkoutOwnerQueryHandler : IRequestHandler<IsUserWorkoutOwnerQuery, bool>
    {
        private readonly WorkoutManagingServiceContext _context;
        public IsUserWorkoutOwnerQueryHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public Task<bool> Handle(IsUserWorkoutOwnerQuery query, CancellationToken token)
        {
            return _context.Workouts.AnyAsync(x => x.Id == query.WorkoutId && x.UserId == query.UserId, token);
        }
    }
}
