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
    public class GetMoodLevelsQueryHandler : IRequestHandler<GetMoodLevelsQuery, List<MoodLevelDTO>>
    {
        private readonly WorkoutManagingServiceContext _context;
        public GetMoodLevelsQueryHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public Task<List<MoodLevelDTO>> Handle(GetMoodLevelsQuery query, CancellationToken token)
        {
            return _context.MoodLevels
                .Select(x => new MoodLevelDTO { Id = x.Id, Name = x.Name })
                .ToListAsync(token);
        }
    }
}
