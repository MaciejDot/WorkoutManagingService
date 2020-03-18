using MediatR;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorkoutManagingService.Data;
using WorkoutManagingService.Data.Entities;
using WorkoutManagingService.Domain.Command;
using WorkoutManagingService.Models;

namespace WorkoutManagingService.Configuration.UsersStartUpConfiguration
{
    public class UsersStartUp
    {
        private readonly IRestClient _restClient;
        private readonly WorkoutManagingServiceContext _context;
        public UsersStartUp(IRestClient restClient, WorkoutManagingServiceContext context)
        {
            _restClient = restClient;
            _context = context;
        }

        public IEnumerable<UserDTO> DownloadUsers(string tokenServiceUsersEndpoint)//, //string oAuthToken) 
        {
            var request = new RestRequest(tokenServiceUsersEndpoint, Method.GET);
            //request.AddHeader("Authorization", $"Bearer {oAuthToken}");
            return _restClient.Execute<IEnumerable<UserDTO>>(request).Data;
        }

        public Task<int> SaveUsers(IEnumerable<UserDTO> users)
        {
            users
                .ToList()
                .ForEach(x =>
                {
                    if (!_context.Users.Any(y => y.Id == x.Id))
                    {
                        _context.Users.Add(new User { Id = x.Id, Username = x.Username });
                    }
                });
            return _context.SaveChangesAsync();
        }

    }
}
