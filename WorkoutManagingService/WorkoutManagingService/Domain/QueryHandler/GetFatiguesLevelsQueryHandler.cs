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
    public class GetFatiguesLevelsQueryHandler : IRequestHandler<GetFatiguesLevelsQuery, List<FatigueLevelDTO>>
    {
        private readonly WorkoutManagingServiceContext _context;
        public GetFatiguesLevelsQueryHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public Task<List<FatigueLevelDTO>> Handle(GetFatiguesLevelsQuery query, CancellationToken token)
        {
            return _context.FatigueLevels
                .Select(x => new FatigueLevelDTO { Id = x.Id, Name = x.Name })
                .ToListAsync(token);
        }
    }
}
