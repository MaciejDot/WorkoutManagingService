using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManagingService.Domain.DTO;

namespace WorkoutManagingService.Domain.Query
{
    public class GetExercisesQuery : IRequest<List<ExerciseDTO>>
    {
    }
}
