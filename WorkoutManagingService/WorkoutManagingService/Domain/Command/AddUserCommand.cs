using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManagingService.Domain.Command
{
    public class AddUserCommand : IRequest<Unit>
    {
        public string UserId { get; set; }
        public string Username { get; set; }
    }
}
