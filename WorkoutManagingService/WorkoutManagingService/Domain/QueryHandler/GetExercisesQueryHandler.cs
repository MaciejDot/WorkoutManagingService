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
    public class GetExercisesQueryHandler : IRequestHandler<GetExercisesQuery, List<ExerciseDTO>>
    {
        private readonly WorkoutManagingServiceContext _context;

        public GetExercisesQueryHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }

        public Task<List<ExerciseDTO>> Handle(GetExercisesQuery request, CancellationToken token)
        {
            return _context
                .Exercises
                .AsNoTracking()
                .Select(x => new ExerciseDTO { Id = x.Id, Name = x.Name })
                .ToListAsync(token);
        }
    }
}
