using CalisthenicsEncyclpoedia.Contracts.Events;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorkoutManagingService.Domain.Command;

namespace WorkoutManagingService.MessageBroker.Consumers
{
    public class AddedUserEventConsumer : IConsumer<IAddedUserEvent>
    {
        private readonly IMediator _mediator;
        public AddedUserEventConsumer(IMediator mediator)
        {
            _mediator = mediator;
        }
        public Task Consume(ConsumeContext<IAddedUserEvent> context)
        {
            return _mediator.Send(new AddUserCommand
            {
                UserId = context.Message.Id,
                Username = context.Message.Username
            }, context.CancellationToken);
        }
    }
}
