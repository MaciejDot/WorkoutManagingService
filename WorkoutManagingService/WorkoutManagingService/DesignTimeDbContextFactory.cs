using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManagingService.Data;

namespace WorkoutManagingService
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<WorkoutManagingServiceContext>
    {
        public WorkoutManagingServiceContext CreateDbContext(string[] args) 
        {
            return new WorkoutManagingServiceContext(new DbContextOptionsBuilder<WorkoutManagingServiceContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WorkoutManagingService;Trusted_Connection=True;")
                .Options);
        }
    }
}
