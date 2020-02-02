using System;
using System.Collections.Generic;
using System.Text;
using WorkoutManagingService.Data.Entities;

namespace WorkoutManagingService.Data.Seed
{
    internal class GroupOfExerciseSeed
    {
        public IEnumerable<GroupOfExercises> GroupsOfExercises()
        {
            yield return new GroupOfExercises { Id = 1, Name = "Handstand" };
            yield return new GroupOfExercises { Id = 2, Name = "Handstand Push Ups" };
            yield return new GroupOfExercises { Id = 3, Name = "Handstand Press" };
            yield return new GroupOfExercises { Id = 4, Name = "L-sit V-sit Manna" };
            yield return new GroupOfExercises { Id = 5, Name = "Back Lever" };
            yield return new GroupOfExercises { Id = 6, Name = "Back Lever Press" };
            yield return new GroupOfExercises { Id = 7, Name = "Back Lever Pull Ups" };
            yield return new GroupOfExercises { Id = 8, Name = "Front Lever" };
            yield return new GroupOfExercises { Id = 9, Name = "Front Lever Press" };
            yield return new GroupOfExercises { Id = 10, Name = "Front Lever Pull Ups" };

            yield return new GroupOfExercises { Id = 11, Name = "Rows" };
            yield return new GroupOfExercises { Id = 12, Name = "Pull Ups" };
            yield return new GroupOfExercises { Id = 13, Name = "Support Hold" };
            yield return new GroupOfExercises { Id = 14, Name = "Dips" };
            yield return new GroupOfExercises { Id = 15, Name = "Human Flag" };
            yield return new GroupOfExercises { Id = 16, Name = "Muscle Ups" };
            yield return new GroupOfExercises { Id = 17, Name = "Hefesto" };
            yield return new GroupOfExercises { Id = 18, Name = "High Pull Ups" };
            yield return new GroupOfExercises { Id = 19, Name = "Squats" };
            yield return new GroupOfExercises { Id = 20, Name = "Push Ups" };

            yield return new GroupOfExercises { Id = 21, Name = "Dead Hang" };
            yield return new GroupOfExercises { Id = 22, Name = "Reverse Hang" };
            yield return new GroupOfExercises { Id = 23, Name = "Victorian Cross" };
            yield return new GroupOfExercises { Id = 24, Name = "Dragon Flag" };
            yield return new GroupOfExercises { Id = 25, Name = "Dragon Flag Press" };
            yield return new GroupOfExercises { Id = 26, Name = "Dragon Press" };
            yield return new GroupOfExercises { Id = 27, Name = "Dragon Press Press" };
            yield return new GroupOfExercises { Id = 28, Name = "Front Lever Touch" };
            yield return new GroupOfExercises { Id = 29, Name = "Planche" };
            yield return new GroupOfExercises { Id = 30, Name = "Planche Push Ups" };

            yield return new GroupOfExercises { Id = 31, Name = "Planche Press" };
            yield return new GroupOfExercises { Id = 32, Name = "Maltese" };
            yield return new GroupOfExercises { Id = 33, Name = "Maltese Press" };
            yield return new GroupOfExercises { Id = 34, Name = "Inverted Cross" };
            yield return new GroupOfExercises { Id = 35, Name = "Inverted Cross Press" };
            yield return new GroupOfExercises { Id = 36, Name = "Handstand Flag" };
            yield return new GroupOfExercises { Id = 37, Name = "Planche Lean" };
            yield return new GroupOfExercises { Id = 38, Name = "Planche Lean Push Ups" };
            yield return new GroupOfExercises { Id = 39, Name = "Plank" };
            yield return new GroupOfExercises { Id = 40, Name = "Maltese Lean" };

            yield return new GroupOfExercises { Id = 41, Name = "Iron Cross" };
            yield return new GroupOfExercises { Id = 42, Name = "Inverted Cross Press" };
            yield return new GroupOfExercises { Id = 43, Name = "Reverse Planche" };
            yield return new GroupOfExercises { Id = 44, Name = "Victorian Cross Leans" };
            yield return new GroupOfExercises { Id = 45, Name = "Hollow Body" };
            yield return new GroupOfExercises { Id = 46, Name = "Superman" };
            yield return new GroupOfExercises { Id = 47, Name = "Leg Raises" };
            yield return new GroupOfExercises { Id = 48, Name = "Dynamic Hollow Body" };
            yield return new GroupOfExercises { Id = 49, Name = "Dynamic Superman" };
            yield return new GroupOfExercises { Id = 50, Name = "Impossible Dips" };

            yield return new GroupOfExercises { Id = 51, Name = "Neck Hold" };
            yield return new GroupOfExercises { Id = 52, Name = "Christo" };
            yield return new GroupOfExercises { Id = 53, Name = "Half Zanetti Flies" };
            yield return new GroupOfExercises { Id = 54, Name = "Zanetti Flies" };
            yield return new GroupOfExercises { Id = 55, Name = "Planche Hollow Body" };
            yield return new GroupOfExercises { Id = 56, Name = "Maltese Hollow Body" };
            yield return new GroupOfExercises { Id = 57, Name = "Bench Press" };
            yield return new GroupOfExercises { Id = 58, Name = "Incline Bench Press" };
            yield return new GroupOfExercises { Id = 59, Name = "OHP" };
            yield return new GroupOfExercises { Id = 60, Name = "Biceps Curls" };

            yield return new GroupOfExercises { Id = 61, Name = "Dead Lift" };
            yield return new GroupOfExercises { Id = 62, Name = "Bridge" };
        }
    }
}
