using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorkoutManagingService.Data;
using WorkoutManagingService.Data.Entities;
using WorkoutManagingService.Domain.Command;
using Microsoft.EntityFrameworkCore;
namespace WorkoutManagingService.Domain.CommandHandler
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, Unit>
    {
        private readonly WorkoutManagingServiceContext _context;
        public AddUserCommandHandler(WorkoutManagingServiceContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(AddUserCommand command, CancellationToken token)
        {
            await _context.Users.AddAsync(new User { Id = command.UserId, Username = command.Username }, token);
            await _context.SaveChangesAsync(token);
            return new Unit();
        }
    }
}
