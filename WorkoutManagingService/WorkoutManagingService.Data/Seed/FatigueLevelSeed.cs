using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkoutManagingService.Data.Entities;
using WorkoutManagingService.Data.Enums;

namespace WorkoutManagingService.Data.Seed
{
    internal class FatigueLevelSeed
    {
        public IEnumerable<FatigueLevel> FatigueLevels() 
        {
            return typeof(FatigueLevelEnum)
                   .GetEnumNames()
                   .Select(x => new FatigueLevel { Id = (int) Enum.Parse(typeof(FatigueLevelEnum), x), Name = x });
        }
    }
}
