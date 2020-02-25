using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using WorkoutManagingService.Data.Entities;
using WorkoutManagingService.Data.Enums;
using System.Linq;
namespace WorkoutManagingService.Data.Seed
{
    internal class MoodLevelSeed
    {
        public IEnumerable<MoodLevel> MoodLevels()
        {
            return typeof(MoodLevelEnum)
                .GetEnumNames()
                .Select(x => new MoodLevel { Id = (int)Enum.Parse(typeof(MoodLevelEnum), x), Name = x });
        }
    }
}
