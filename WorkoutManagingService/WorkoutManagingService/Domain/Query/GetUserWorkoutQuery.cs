﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManagingService.Domain.DTO;

namespace WorkoutManagingService.Domain.Query
{
    public class GetUserWorkoutQuery : IRequest<WorkoutDTO>
    {
        public string Username { get; set; }
        public string WorkoutName { get; set; }
        public string RequesterId { get; set; }
    }
}
