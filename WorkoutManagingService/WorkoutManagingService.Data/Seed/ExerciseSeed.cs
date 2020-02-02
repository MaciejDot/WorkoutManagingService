using System;
using System.Collections.Generic;
using System.Text;
using WorkoutManagingService.Data.Entities;

namespace WorkoutManagingService.Data.Seed
{
    internal class ExerciseSeed
    {
        public IEnumerable<Exercise> Exercises()
        {

            #region Handstand

            yield return new Exercise { Id = 100, Name = "Wall Handstand", IsHold = true, GroupId = 1 };
            yield return new Exercise { Id = 101, Name = "Free Handstand", IsHold = true, GroupId = 1 };
            yield return new Exercise { Id = 102, Name = "Handstand On Rings", IsHold = true, GroupId = 1 };
            yield return new Exercise { Id = 103, Name = "Wall One Arm Handstand", IsHold = true, GroupId = 1 };
            yield return new Exercise { Id = 104, Name = "Free One Arm Handstand", IsHold = true, GroupId = 1 };
            yield return new Exercise { Id = 105, Name = "Hollow Back", IsHold = true, GroupId = 1 };

            #endregion

            #region Handstand Push Ups

            yield return new Exercise { Id = 200, Name = "Pike Push Ups", IsHold = false, GroupId = 2 };
            yield return new Exercise { Id = 201, Name = "Elevated Pike Push Ups", IsHold = false, GroupId = 2 };
            yield return new Exercise { Id = 202, Name = "Wall Handstand Push Ups", IsHold = false, GroupId = 2 };
            yield return new Exercise { Id = 203, Name = "Free Handstand Push Ups", IsHold = false, GroupId = 2 };
            yield return new Exercise { Id = 204, Name = "Free Deep Handstand Push Ups", IsHold = false, GroupId = 2 };
            yield return new Exercise { Id = 205, Name = "Free Wide Handstand Push Ups", IsHold = false, GroupId = 2 };
            yield return new Exercise { Id = 206, Name = "Free 90 Degree Handstand Push Ups", IsHold = false, GroupId = 2 };
            yield return new Exercise { Id = 207, Name = "Free Deep 90 Degree Handstand Push Ups", IsHold = false, GroupId = 2 };

            #endregion

            #region Handstand Press

            yield return new Exercise { Id = 300, Name = "Bend Arm Tuck Press To Handstand", IsHold = false, GroupId = 3 };
            yield return new Exercise { Id = 301, Name = "Straigth Arm Tuck Press To Handstand", IsHold = false, GroupId = 3 };
            yield return new Exercise { Id = 302, Name = "Bend Arm Straddle Press To Handstand", IsHold = false, GroupId = 3 };
            yield return new Exercise { Id = 303, Name = "Straigth Arm Straddle Press To Handstand", IsHold = false, GroupId = 3 };
            yield return new Exercise { Id = 304, Name = "Bend Arm Pike Press To Handstand", IsHold = false, GroupId = 3 };
            yield return new Exercise { Id = 305, Name = "Straigth Arm Pike Press To Handstand", IsHold = false, GroupId = 3 };
            yield return new Exercise { Id = 306, Name = "Bend Arm L-sit To Handstand", IsHold = false, GroupId = 3 };
            yield return new Exercise { Id = 307, Name = "Straigth Arm L-sit To Handstand", IsHold = false, GroupId = 3 };

            #endregion

            #region L-sit V-sit Manna

            yield return new Exercise { Id = 400, Name = "Tuck L-sit", IsHold = true, GroupId = 4 };
            yield return new Exercise { Id = 401, Name = "L-sit", IsHold = true, GroupId = 4 };
            yield return new Exercise { Id = 402, Name = "Straddle L-sit", IsHold = true, GroupId = 4 };
            yield return new Exercise { Id = 403, Name = "Rings L-sit", IsHold = true, GroupId = 4 };
            yield return new Exercise { Id = 404, Name = "Rings Straddle L-sit", IsHold = true, GroupId = 4 };
            yield return new Exercise { Id = 405, Name = "V-Sit", IsHold = true, GroupId = 4 };
            yield return new Exercise { Id = 406, Name = "Rings V-Sit", IsHold = true, GroupId = 4 };
            yield return new Exercise { Id = 407, Name = "45 Degree V-Sit/Manna", IsHold = true, GroupId = 4 };
            yield return new Exercise { Id = 408, Name = "Manna", IsHold = true, GroupId = 4 };

            #endregion

            #region Back Lever

            yield return new Exercise { Id = 500, Name = "German Hang", IsHold = true, GroupId = 5 };
            yield return new Exercise { Id = 501, Name = "Tuck Back Lever", IsHold = true, GroupId = 5 };
            yield return new Exercise { Id = 502, Name = "Advanced Tuck Back Lever", IsHold = true, GroupId = 5 };
            yield return new Exercise { Id = 503, Name = "Straddle Back Lever", IsHold = true, GroupId = 5 };
            yield return new Exercise { Id = 504, Name = "Half Lay Back Lever", IsHold = true, GroupId = 5 };
            yield return new Exercise { Id = 505, Name = "Full Back Lever", IsHold = true, GroupId = 5 };
            yield return new Exercise { Id = 506, Name = "Wide Full Back Lever", IsHold = true, GroupId = 5 };
            yield return new Exercise { Id = 507, Name = "One Arm Back Lever", IsHold = true, GroupId = 5 };

            #endregion

            #region Back Lever Press

            yield return new Exercise { Id = 600, Name = "Tuck Back Lever Press To Reverse Hang", IsHold = false, GroupId = 6 };
            yield return new Exercise { Id = 601, Name = "German Hang Thru Tuck Back Lever Press To Reverse Hang", IsHold = false, GroupId = 6 };
            yield return new Exercise { Id = 602, Name = "Advanced Tuck Back Lever Press To Reverse Hang", IsHold = false, GroupId = 6 };
            yield return new Exercise { Id = 603, Name = "German Hang Thru Advanced Tuck Back Lever Press To Reverse Hang", IsHold = false, GroupId = 6 };
            yield return new Exercise { Id = 604, Name = "Straddle Back Lever Press To Reverse Hang", IsHold = false, GroupId = 6 };
            yield return new Exercise { Id = 605, Name = "German Hang Thru Straddle Back Lever Press To Reverse Hang", IsHold = false, GroupId = 6 };
            yield return new Exercise { Id = 606, Name = "Half Lay Back Lever Press To Reverse Hang", IsHold = false, GroupId = 6 };
            yield return new Exercise { Id = 607, Name = "German Hang Thru Half Lay Back Lever Press To Reverse Hang", IsHold = false, GroupId = 6 };
            yield return new Exercise { Id = 608, Name = "Full Back Lever Press To Reverse Hang", IsHold = false, GroupId = 6 };
            yield return new Exercise { Id = 609, Name = "German Hang Thru Full Back Lever Press To Reverse Hang", IsHold = false, GroupId = 6 };

            #endregion

            #region Back Lever Pull Ups

            yield return new Exercise { Id = 700, Name = "German Hang Pull Ups", IsHold = false, GroupId = 7 };
            yield return new Exercise { Id = 701, Name = "Tuck Back Lever Pull Ups", IsHold = false, GroupId = 7 };
            yield return new Exercise { Id = 702, Name = "Advanced Tuck Back Lever Pull Ups", IsHold = false, GroupId = 7 };
            yield return new Exercise { Id = 703, Name = "Straddle Back Lever Pull Ups", IsHold = false, GroupId = 7 };
            yield return new Exercise { Id = 704, Name = "Half Lay Back Lever Pull Ups", IsHold = false, GroupId = 7 };
            yield return new Exercise { Id = 705, Name = "Full Back Lever Pull Ups", IsHold = false, GroupId = 7 };

            #endregion

            #region Front Lever

            yield return new Exercise { Id = 800, Name = "Tuck Front Lever", IsHold = true, GroupId = 8 };
            yield return new Exercise { Id = 801, Name = "Advanced Tuck Front Lever", IsHold = true, GroupId = 8 };
            yield return new Exercise { Id = 802, Name = "Straddle Front Lever", IsHold = true, GroupId = 8 };
            yield return new Exercise { Id = 803, Name = "Half Lay Front Lever", IsHold = true, GroupId = 8 };
            yield return new Exercise { Id = 804, Name = "Full Front Lever", IsHold = true, GroupId = 8 };
            yield return new Exercise { Id = 805, Name = "Wide Full Front Lever", IsHold = true, GroupId = 8 };
            yield return new Exercise { Id = 806, Name = "One Arm Side Lever", IsHold = true, GroupId = 8 };
            yield return new Exercise { Id = 807, Name = "One Arm Front Lever", IsHold = true, GroupId = 8 };

            #endregion

            #region Front Lever Press

            yield return new Exercise { Id = 900, Name = "Dead Hang Thru Tuck Front Lever Press To Reverse Hang Eccentric", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 901, Name = "Tuck Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 902, Name = "Dead Hang Thru Tuck Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 903, Name = "Dead Hang Thru Advanced Front Back Lever Press To Reverse Hang Eccentric", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 904, Name = "Advanced Tuck Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 905, Name = "Dead Hang Thru Advanced Front Back Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 906, Name = "Dead Hang Thru Straddle Front Lever Press To Reverse Hang Eccentric", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 907, Name = "Straddle Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 908, Name = "Dead Hang Thru Straddle Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 909, Name = "Dead Hang Thru Half Lay Front Lever Press To Reverse Hang Eccentric", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 910, Name = "Half Lay Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 911, Name = "Dead Hang Thru Half Lay Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 912, Name = "Dead Hang Thru Full Front Lever Press To Reverse Hang Eccentric", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 913, Name = "Full Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 914, Name = "Dead Hang Thru Full Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 915, Name = "Dead Hang Press To One Arm Front Lever", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 916, Name = "Dead Hang Thru One Arm Front Lever Press To Reverse Hang Eccentric", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 917, Name = "One Arm Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };
            yield return new Exercise { Id = 918, Name = "Dead Hang Thru One Arm Front Lever Press To Reverse Hang", IsHold = false, GroupId = 9 };

            #endregion

            #region Front Lever Pull Ups

            yield return new Exercise { Id = 1000, Name = "Tuck Front Lever False Grip Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1001, Name = "Tuck Front Lever Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1002, Name = "Advanced Tuck Front Lever False Grip Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1003, Name = "Advanced Tuck Front Lever Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1004, Name = "Straddle Front Lever False Grip Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1005, Name = "Straddle Front Lever Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1006, Name = "Half Lay Front Lever False Grip Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1007, Name = "Half Lay Front Lever Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1008, Name = "Full Front Lever False Grip Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1009, Name = "Full Front Lever Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1010, Name = "Wide Front Lever False Grip Pull Ups", IsHold = false, GroupId = 10 };
            yield return new Exercise { Id = 1011, Name = "Wide Front Lever Pull Ups", IsHold = false, GroupId = 10 };

            #endregion

            #region Rows

            yield return new Exercise { Id = 1100, Name = "Australian Pull Ups Eccentric", IsHold = false, GroupId = 11 };
            yield return new Exercise { Id = 1101, Name = "Australian Pull Ups", IsHold = false, GroupId = 11 };
            yield return new Exercise { Id = 1102, Name = "Wide Australian Pull Ups", IsHold = false, GroupId = 11 };
            yield return new Exercise { Id = 1103, Name = "Archer Australian Pull Ups", IsHold = false, GroupId = 11 };
            yield return new Exercise { Id = 1104, Name = "One Arm Australian Pull Ups", IsHold = false, GroupId = 11 };

            #endregion

            #region Pull Ups

            yield return new Exercise { Id = 1200, Name = "Regular Pull Ups Eccentrinc", IsHold = false, GroupId = 12 };
            yield return new Exercise { Id = 1201, Name = "Regular Pull Ups", IsHold = false, GroupId = 12 };
            yield return new Exercise { Id = 1202, Name = "Wide Pull Up Eccentrinc", IsHold = false, GroupId = 12 };
            yield return new Exercise { Id = 1203, Name = "Wide Pull Ups", IsHold = false, GroupId = 12 };
            yield return new Exercise { Id = 1204, Name = "Archer Pull Ups", IsHold = false, GroupId = 12 };
            yield return new Exercise { Id = 1205, Name = "One Arm Pull Ups Eccentrinc", IsHold = false, GroupId = 12 };
            yield return new Exercise { Id = 1206, Name = "One Arm Pull Ups", IsHold = false, GroupId = 12 };

            #endregion

            #region Support Hold

            yield return new Exercise { Id = 1300, Name = "Support Hold", IsHold = true, GroupId = 13 };

            #endregion

            #region Dips

            yield return new Exercise { Id = 1400, Name = "Swedish Dips Eccentrinc", IsHold = false, GroupId = 14 };
            yield return new Exercise { Id = 1401, Name = "Swedish Dips", IsHold = false, GroupId = 14 };
            yield return new Exercise { Id = 1402, Name = "Regular Dips Eccentrinc", IsHold = false, GroupId = 14 };
            yield return new Exercise { Id = 1403, Name = "Regular Dips", IsHold = false, GroupId = 14 };
            yield return new Exercise { Id = 1404, Name = "Single Bar Dips Eccentrinc", IsHold = false, GroupId = 14 };
            yield return new Exercise { Id = 1405, Name = "Single Bar Dips", IsHold = false, GroupId = 14 };
            yield return new Exercise { Id = 1406, Name = "Korean Dips Eccentrinc", IsHold = false, GroupId = 14 };
            yield return new Exercise { Id = 1407, Name = "Korean Dips", IsHold = false, GroupId = 14 };
            yield return new Exercise { Id = 1408, Name = "Ring Dips", IsHold = false, GroupId = 14 };
            yield return new Exercise { Id = 1409, Name = "Bulgarian Dips Eccentrinc", IsHold = false, GroupId = 14 };

            #endregion

            #region Human Flag

            yield return new Exercise { Id = 1500, Name = "Human Flag Hang", IsHold = true, GroupId = 15 };
            yield return new Exercise { Id = 1501, Name = "Human Flag Reverse Hang", IsHold = true, GroupId = 15 };
            yield return new Exercise { Id = 1502, Name = "Advanced Tuck Human Flag", IsHold = true, GroupId = 15 };
            yield return new Exercise { Id = 1503, Name = "Straddle Human Flag", IsHold = true, GroupId = 15 };
            yield return new Exercise { Id = 1504, Name = "Full Human Flag", IsHold = true, GroupId = 15 };

            #endregion

            #region Muscle Ups

            yield return new Exercise { Id = 1600, Name = "Muscle Ups Eccentrinc", IsHold = false, GroupId = 16 };
            yield return new Exercise { Id = 1601, Name = "Muscle Ups", IsHold = false, GroupId = 16 };
            yield return new Exercise { Id = 1602, Name = "Rings Muscle Ups", IsHold = false, GroupId = 16 };
            yield return new Exercise { Id = 1603, Name = "One Arm Muscle Ups", IsHold = false, GroupId = 16 };

            #endregion

            #region Hefesto

            yield return new Exercise { Id = 1700, Name = "Reverse Australian Pull Ups Eccentrinc", IsHold = false, GroupId = 17 };
            yield return new Exercise { Id = 1701, Name = "Reverse Australian Pull Ups", IsHold = false, GroupId = 17 };
            yield return new Exercise { Id = 1702, Name = "Hefesto Eccentrinc", IsHold = false, GroupId = 17 };
            yield return new Exercise { Id = 1703, Name = "Hefesto", IsHold = false, GroupId = 17 };
            yield return new Exercise { Id = 1704, Name = "Back Lever Hefesto Eccentrinc", IsHold = false, GroupId = 17 };
            yield return new Exercise { Id = 1705, Name = "Back Lever Hefesto", IsHold = false, GroupId = 17 };
            yield return new Exercise { Id = 1706, Name = "Entrade De Angelo Eccentrinc", IsHold = false, GroupId = 17 };
            yield return new Exercise { Id = 1707, Name = "Entrade De Angelo", IsHold = false, GroupId = 17 };
            yield return new Exercise { Id = 1708, Name = "Entrade De Diablo Eccentrinc", IsHold = false, GroupId = 17 };
            yield return new Exercise { Id = 1709, Name = "Entrade De Diablo", IsHold = false, GroupId = 17 };

            #endregion

            #region High Pull Ups

            yield return new Exercise { Id = 1800, Name = "High Pull Ups To Chest", IsHold = false, GroupId = 18 };
            yield return new Exercise { Id = 1801, Name = "High Pull Ups To Stomach", IsHold = false, GroupId = 18 };
            yield return new Exercise { Id = 1802, Name = "High Pull Ups To Thigs", IsHold = false, GroupId = 18 };
            yield return new Exercise { Id = 1803, Name = "Terrorist Pull Ups", IsHold = false, GroupId = 18 };

            #endregion

            #region Squats

            yield return new Exercise { Id = 1900, Name = "Squat", IsHold = false, GroupId = 19 };
            yield return new Exercise { Id = 1901, Name = "Pistol Squat Eccentric", IsHold = false, GroupId = 19 };
            yield return new Exercise { Id = 1902, Name = "Pistol Squat", IsHold = false, GroupId = 19 };

            #endregion

            #region Push Ups

            yield return new Exercise { Id = 2000, Name = "Knee Push Ups Eccentric", IsHold = false, GroupId = 20 };
            yield return new Exercise { Id = 2001, Name = "Knee Push Ups", IsHold = false, GroupId = 20 };
            yield return new Exercise { Id = 2002, Name = "Regular Push Ups Eccentric", IsHold = false, GroupId = 20 };
            yield return new Exercise { Id = 2003, Name = "Regular Push Ups", IsHold = false, GroupId = 20 };
            yield return new Exercise { Id = 2004, Name = "Diamond Push Ups", IsHold = false, GroupId = 20 };
            yield return new Exercise { Id = 2005, Name = "Archer Push Ups", IsHold = false, GroupId = 20 };
            yield return new Exercise { Id = 2006, Name = "One Arm Push Ups Eccentric", IsHold = false, GroupId = 20 };
            yield return new Exercise { Id = 2007, Name = "One Arm Push Ups", IsHold = false, GroupId = 20 };

            #endregion

            #region Dead Hang

            yield return new Exercise { Id = 2100, Name = "Dead Hang", IsHold = true, GroupId = 21 };
            yield return new Exercise { Id = 2101, Name = "One Arm Dead Hang", IsHold = true, GroupId = 21 };

            #endregion

            #region Reverse Hang

            yield return new Exercise { Id = 2200, Name = "Reverse Hang", IsHold = true, GroupId = 22 };

            #endregion

            #region Victorian Cross

            yield return new Exercise { Id = 2300, Name = "Paraller Bars L Victorian Cross (Arms On Bars)", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2301, Name = "Paraller Bars Advanced Tuck Victorian Cross (Arms On Bars)", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2302, Name = "Paraller Bars Super Advanced Tuck Victorian Cross (Arms On Bars)", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2303, Name = "Paraller Bars Half Lay Victorian Cross (Arms On Bars)", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2304, Name = "Paraller Bars Full Victorian Cross (Arms On Bars)", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2305, Name = "Paraller Bars L Victorian Cross (Only Hands On Bars)", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2306, Name = "Paraller Bars Advanced Tuck Victorian Cross (Only Hands On Bars)", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2307, Name = "Paraller Bars Super Advanced Tuck Victorian Cross (Only Hands On Bars)", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2308, Name = "Paraller Bars Half Lay Victorian Cross (Only Hands On Bars)", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2309, Name = "Paraller Bars Full Victorian Cross (Only Hands On Bars)", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2310, Name = "Rings Snake Grip Victorian Cross", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2311, Name = "Rings Victorian Cross", IsHold = true, GroupId = 23 };
            yield return new Exercise { Id = 2312, Name = "Paraller Bars L Victorian Cross", IsHold = true, GroupId = 23 };

            #endregion

            #region Dragon Flag

            yield return new Exercise { Id = 2400, Name = "L Dragon Flag", IsHold = true, GroupId = 24 };
            yield return new Exercise { Id = 2401, Name = "Advanced Tuck Dragon Flag", IsHold = true, GroupId = 24 };
            yield return new Exercise { Id = 2402, Name = "Straddle Dragon Flag", IsHold = true, GroupId = 24 };
            yield return new Exercise { Id = 2403, Name = "Full Dragon Flag", IsHold = true, GroupId = 24 };
            yield return new Exercise { Id = 2404, Name = "One Arm Dragon Flag", IsHold = true, GroupId = 24 };

            #endregion

            #region Dragon Flag Press

            yield return new Exercise { Id = 2500, Name = "Advanced Tuck Dragon Flag Press Eccentric", IsHold = false, GroupId = 25 };
            yield return new Exercise { Id = 2501, Name = "Advanced Tuck Dragon Flag Press", IsHold = false, GroupId = 25 };
            yield return new Exercise { Id = 2502, Name = "Straddle Dragon Flag Press Eccentric", IsHold = false, GroupId = 25 };
            yield return new Exercise { Id = 2503, Name = "Straddle Dragon Flag Press", IsHold = false, GroupId = 25 };
            yield return new Exercise { Id = 2504, Name = "Full Dragon Flag Press Eccentric", IsHold = false, GroupId = 25 };
            yield return new Exercise { Id = 2505, Name = "Full Dragon Flag Press", IsHold = false, GroupId = 25 };
            yield return new Exercise { Id = 2506, Name = "One Arm Dragon Flag Press Eccentric", IsHold = false, GroupId = 25 };
            yield return new Exercise { Id = 2507, Name = "One Arm Dragon Flag Press", IsHold = false, GroupId = 25 };

            #endregion

            #region Dragon Press

            yield return new Exercise { Id = 2600, Name = "L Dragon Press", IsHold = true, GroupId = 26 };
            yield return new Exercise { Id = 2601, Name = "Advanced Tuck Dragon Press", IsHold = true, GroupId = 26 };
            yield return new Exercise { Id = 2602, Name = "Straddle Dragon Press", IsHold = true, GroupId = 26 };
            yield return new Exercise { Id = 2603, Name = "Full Dragon Press", IsHold = true, GroupId = 26 };
            yield return new Exercise { Id = 2604, Name = "One Arm Dragon Press", IsHold = true, GroupId = 26 };

            #endregion

            #region Dragon Press Press

            yield return new Exercise { Id = 2700, Name = "Advanced Tuck Dragon Press Press Eccentric", IsHold = false, GroupId = 27 };
            yield return new Exercise { Id = 2701, Name = "Advanced Tuck Dragon Press Press", IsHold = false, GroupId = 27 };
            yield return new Exercise { Id = 2702, Name = "Straddle Dragon Press Press Eccentric", IsHold = false, GroupId = 27 };
            yield return new Exercise { Id = 2703, Name = "Straddle Dragon Press Press", IsHold = false, GroupId = 27 };
            yield return new Exercise { Id = 2704, Name = "Full Dragon Press Press Eccentric", IsHold = false, GroupId = 27 };
            yield return new Exercise { Id = 2705, Name = "Full Dragon Press Press", IsHold = false, GroupId = 27 };
            yield return new Exercise { Id = 2706, Name = "One Arm Dragon Press Press Eccentric", IsHold = false, GroupId = 27 };
            yield return new Exercise { Id = 2707, Name = "One Arm Dragon Press Press", IsHold = false, GroupId = 27 };

            #endregion

            #region Front Lever Touch

            yield return new Exercise { Id = 2800, Name = "Advanced Tuck Front Lever Touch", IsHold = true, GroupId = 28 };
            yield return new Exercise { Id = 2801, Name = "Straddle Front Lever Touch", IsHold = true, GroupId = 28 };
            yield return new Exercise { Id = 2802, Name = "Half Lay Front Lever Touch", IsHold = true, GroupId = 28 };
            yield return new Exercise { Id = 2803, Name = "Full Front Lever Touch", IsHold = true, GroupId = 28 };
            yield return new Exercise { Id = 2804, Name = "Wide Full Front Lever Touch", IsHold = true, GroupId = 28 };

            #endregion

            #region Planche

            yield return new Exercise { Id = 2900, Name = "Tuck Planche", IsHold = true, GroupId = 29 };
            yield return new Exercise { Id = 2901, Name = "Tuck Rings Planche", IsHold = true, GroupId = 29 };
            yield return new Exercise { Id = 2902, Name = "Advanced Tuck Planche", IsHold = true, GroupId = 29 };
            yield return new Exercise { Id = 2903, Name = "Advanced Rings Tuck Planche", IsHold = true, GroupId = 29 };
            yield return new Exercise { Id = 2904, Name = "Straddle Planche", IsHold = true, GroupId = 29 };
            yield return new Exercise { Id = 2905, Name = "Half Lay Planche", IsHold = true, GroupId = 29 };
            yield return new Exercise { Id = 2906, Name = "Straddle Rings Planche", IsHold = true, GroupId = 29 };
            yield return new Exercise { Id = 2907, Name = "Full Planche", IsHold = true, GroupId = 29 };
            yield return new Exercise { Id = 2908, Name = "Full Rings Planche", IsHold = true, GroupId = 29 };

            #endregion

            #region Planche Push Ups

            yield return new Exercise { Id = 3000, Name = "Tuck Planche Push Ups", IsHold = false, GroupId = 30 };
            yield return new Exercise { Id = 3001, Name = "Tuck Rings Planche Push Ups", IsHold = false, GroupId = 30 };
            yield return new Exercise { Id = 3002, Name = "Advanced Tuck Planche Push Ups", IsHold = false, GroupId = 30 };
            yield return new Exercise { Id = 3003, Name = "Advanced Rings Tuck Planche Push Ups", IsHold = false, GroupId = 30 };
            yield return new Exercise { Id = 3004, Name = "Straddle Planche Push Ups", IsHold = false, GroupId = 30 };
            yield return new Exercise { Id = 3005, Name = "Half Lay Planche Push Ups", IsHold = false, GroupId = 30 };
            yield return new Exercise { Id = 3006, Name = "Straddle Rings Planche Push Ups", IsHold = false, GroupId = 30 };
            yield return new Exercise { Id = 3007, Name = "Full Planche Push Ups", IsHold = false, GroupId = 30 };
            yield return new Exercise { Id = 3008, Name = "Full Rings Planche Push Ups", IsHold = false, GroupId = 30 };

            #endregion

            #region Planche Press

            yield return new Exercise { Id = 3100, Name = "Tuck Planche Press Eccentric", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3101, Name = "Tuck Planche Press", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3102, Name = "Tuck Rings Planche Press Eccentric", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3103, Name = "Tuck Rings Planche Press", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3104, Name = "Advanced Tuck Planche Press Eccentric", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3105, Name = "Advanced Tuck Planche Press", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3106, Name = "Advanced Rings Tuck Planche Press Eccentric", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3107, Name = "Advanced Rings Tuck Planche Press", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3108, Name = "Straddle Planche Press Eccentric", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3109, Name = "Straddle Planche Press", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3111, Name = "Half Lay Planche Press Eccentric", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3112, Name = "Half Lay Planche Press", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3113, Name = "Straddle Rings Planche Press Eccentric", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3114, Name = "Straddle Rings Planche Press", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3115, Name = "Full Planche Press Eccentric", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3116, Name = "Full Planche Press", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3117, Name = "Full Rings Planche Press Eccentric", IsHold = false, GroupId = 31 };
            yield return new Exercise { Id = 3118, Name = "Full Rings Planche Press", IsHold = false, GroupId = 31 };

            #endregion

            #region Maltese

            yield return new Exercise { Id = 3200, Name = "Straddle Maltese", IsHold = true, GroupId = 32 };
            yield return new Exercise { Id = 3201, Name = "Straddle Rings Maltese", IsHold = true, GroupId = 32 };
            yield return new Exercise { Id = 3202, Name = "Full Maltese", IsHold = true, GroupId = 32 };
            yield return new Exercise { Id = 3203, Name = "Full Rings Maltese", IsHold = true, GroupId = 32 };

            #endregion

            #region Maltese Press

            yield return new Exercise { Id = 3300, Name = "Straddle Maltese Press Eccentric", IsHold = false, GroupId = 33 };
            yield return new Exercise { Id = 3301, Name = "Straddle Maltese Press", IsHold = false, GroupId = 33 };
            yield return new Exercise { Id = 3302, Name = "Straddle Rings Maltese Press Eccentric", IsHold = false, GroupId = 33 };
            yield return new Exercise { Id = 3303, Name = "Straddle Rings Maltese Press", IsHold = false, GroupId = 33 };
            yield return new Exercise { Id = 3304, Name = "Full Maltese Press Eccentric", IsHold = false, GroupId = 33 };
            yield return new Exercise { Id = 3305, Name = "Full Maltese Press", IsHold = false, GroupId = 33 };
            yield return new Exercise { Id = 3306, Name = "Full Rings Maltese Press Eccentric", IsHold = false, GroupId = 33 };
            yield return new Exercise { Id = 3307, Name = "Full Rings Maltese Press", IsHold = false, GroupId = 33 };

            #endregion

            #region Inverted Cross

            yield return new Exercise { Id = 3400, Name = "30 Degrees Inverted Cross", IsHold = true, GroupId = 34 };
            yield return new Exercise { Id = 3401, Name = "45 Degrees Inverted Cross", IsHold = true, GroupId = 34 };
            yield return new Exercise { Id = 3402, Name = "75 Degrees Inverted Cross", IsHold = true, GroupId = 34 };
            yield return new Exercise { Id = 3403, Name = "Full Inverted Cross", IsHold = true, GroupId = 34 };

            #endregion

            #region Inverted Cross Press

            yield return new Exercise { Id = 3500, Name = "30 Degrees Inverted Cross Press Eccentric", IsHold = false, GroupId = 35 };
            yield return new Exercise { Id = 3501, Name = "30 Degrees Inverted Cross Press", IsHold = false, GroupId = 35 };
            yield return new Exercise { Id = 3502, Name = "45 Degrees Inverted Cross Press Eccentric", IsHold = false, GroupId = 35 };
            yield return new Exercise { Id = 3503, Name = "45 Degrees Inverted Cross Press", IsHold = false, GroupId = 35 };
            yield return new Exercise { Id = 3504, Name = "75 Degrees Inverted Cross Press Eccentric", IsHold = false, GroupId = 35 };
            yield return new Exercise { Id = 3505, Name = "75 Degrees Inverted Cross Press", IsHold = false, GroupId = 35 };
            yield return new Exercise { Id = 3506, Name = "Full Inverted Cross Press Eccentric", IsHold = false, GroupId = 35 };
            yield return new Exercise { Id = 3507, Name = "Full Inverted Cross Press", IsHold = false, GroupId = 35 };

            #endregion

            #region Handstand Flag

            yield return new Exercise { Id = 3600, Name = "Full Handstand Flag", IsHold = true, GroupId = 36 };
            yield return new Exercise { Id = 3601, Name = "Full One Arm Handstand Flag", IsHold = true, GroupId = 36 };

            #endregion

            #region Planche Lean

            yield return new Exercise { Id = 3700, Name = "Planche Lean", IsHold = true, GroupId = 37 };
            yield return new Exercise { Id = 3701, Name = "Elevated Planche Lean", IsHold = true, GroupId = 37 };
            yield return new Exercise { Id = 3702, Name = "Rings Planche Lean", IsHold = true, GroupId = 37 };
            yield return new Exercise { Id = 3703, Name = "Elevated Rings Planche Lean", IsHold = true, GroupId = 37 };

            #endregion

            #region Planche Lean Push Ups

            yield return new Exercise { Id = 3800, Name = "Planche Lean Push Ups", IsHold = false, GroupId = 38 };

            #endregion

            #region Plank

            yield return new Exercise { Id = 3900, Name = "Elbow Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3901, Name = "Elevated Elbow Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3902, Name = "Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3903, Name = "Elevated Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3904, Name = "One Arm Elbow Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3905, Name = "Elevated One Arm Elbow Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3906, Name = "One Arm Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3907, Name = "Elevated One Arm Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3908, Name = "Rings Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3909, Name = "Elevated Rings Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3910, Name = "One Arm Rings Plank", IsHold = true, GroupId = 39 };
            yield return new Exercise { Id = 3911, Name = "Elevated Rings Plank", IsHold = true, GroupId = 39 };

            #endregion

            #region Maltese Lean

            yield return new Exercise { Id = 4000, Name = "Maltese Lean", IsHold = true, GroupId = 40 };
            yield return new Exercise { Id = 4001, Name = "Elevated Maltese Lean", IsHold = true, GroupId = 40 };
            yield return new Exercise { Id = 4002, Name = "Rings Maltese Lean", IsHold = true, GroupId = 40 };
            yield return new Exercise { Id = 4003, Name = "Elevated Rings Maltese Lean", IsHold = true, GroupId = 40 };

            #endregion

            #region Iron Cross

            yield return new Exercise { Id = 4100, Name = "30 Degrees Iron Cross", IsHold = true, GroupId = 41 };
            yield return new Exercise { Id = 4101, Name = "45 Degrees Iron Cross", IsHold = true, GroupId = 41 };
            yield return new Exercise { Id = 4102, Name = "75 Degrees Iron Cross", IsHold = true, GroupId = 41 };
            yield return new Exercise { Id = 4103, Name = "Full Iron Cross", IsHold = true, GroupId = 41 };

            #endregion

            #region Inverted Cross Press

            yield return new Exercise { Id = 4200, Name = "30 Degrees Iron Cross Press Eccentric", IsHold = false, GroupId = 42 };
            yield return new Exercise { Id = 4201, Name = "30 Degrees Iron Cross Press", IsHold = false, GroupId = 42 };
            yield return new Exercise { Id = 4202, Name = "45 Degrees Iron Cross Press Eccentric", IsHold = false, GroupId = 42 };
            yield return new Exercise { Id = 4203, Name = "45 Degrees Iron Cross Press", IsHold = false, GroupId = 42 };
            yield return new Exercise { Id = 4204, Name = "75 Degrees Iron Cross Press Eccentric", IsHold = false, GroupId = 42 };
            yield return new Exercise { Id = 4205, Name = "75 Degrees Iron Cross Press", IsHold = false, GroupId = 42 };
            yield return new Exercise { Id = 4206, Name = "Full Iron Cross Press Eccentric", IsHold = false, GroupId = 42 };
            yield return new Exercise { Id = 4207, Name = "Full Iron Cross Press", IsHold = false, GroupId = 42 };

            #endregion

            #region Reverse Planche

            yield return new Exercise { Id = 4300, Name = "Reverse Planche", IsHold = true, GroupId = 43 };

            #endregion

            #region Victorian Cross Leans

            yield return new Exercise { Id = 4400, Name = "Victorian Cross Lean", IsHold = true, GroupId = 44 };
            yield return new Exercise { Id = 4401, Name = "Elevated Victorian Cross Lean", IsHold = true, GroupId = 44 };
            yield return new Exercise { Id = 4402, Name = "Rings Victorian Cross Lean", IsHold = true, GroupId = 44 };
            yield return new Exercise { Id = 4403, Name = "Elevated Rings Victorian Cross Lean", IsHold = true, GroupId = 44 };

            #endregion

            #region Hollow Body

            yield return new Exercise { Id = 4500, Name = "Advanced Hollow Body", IsHold = true, GroupId = 45 };
            yield return new Exercise { Id = 4501, Name = "Super Advanced Hollow Body", IsHold = true, GroupId = 45 };
            yield return new Exercise { Id = 4502, Name = "Straddle Hollow Body", IsHold = true, GroupId = 45 };
            yield return new Exercise { Id = 4503, Name = "Hollow Body", IsHold = true, GroupId = 45 };

            #endregion

            #region Superman

            yield return new Exercise { Id = 4600, Name = "Superman", IsHold = true, GroupId = 46 };

            #endregion

            #region Leg Raises

            yield return new Exercise { Id = 4700, Name = "Tuck Leg Raises", IsHold = false, GroupId = 47 };
            yield return new Exercise { Id = 4701, Name = "Straddle Leg Raises", IsHold = false, GroupId = 47 };
            yield return new Exercise { Id = 4702, Name = "Full Leg Raises", IsHold = false, GroupId = 47 };
            yield return new Exercise { Id = 4703, Name = "One Arm Leg Raises", IsHold = false, GroupId = 47 };

            #endregion

            #region Dynamic Hollow Body

            yield return new Exercise { Id = 4800, Name = "Hollow Body Rocks", IsHold = false, GroupId = 48 };
            yield return new Exercise { Id = 4801, Name = "Hollow Body Raises", IsHold = false, GroupId = 48 };

            #endregion

            #region Dynamic Superman

            yield return new Exercise { Id = 4900, Name = "Superman Rocks", IsHold = false, GroupId = 49 };
            yield return new Exercise { Id = 4901, Name = "Superman Raises", IsHold = false, GroupId = 49 };

            #endregion

            #region Impossible Dips

            yield return new Exercise { Id = 5000, Name = "Impossible Dips Eccentric", IsHold = false, GroupId = 50 };
            yield return new Exercise { Id = 5001, Name = "Impossible Dips", IsHold = false, GroupId = 50 };

            #endregion

            #region Neck Hold

            yield return new Exercise { Id = 5100, Name = "Neck Hold", IsHold = true, GroupId = 51 };

            #endregion

            #region Christo

            yield return new Exercise { Id = 5200, Name = "Christo", IsHold = true, GroupId = 52 };

            #endregion

            #region Half Zanetti Flies

            yield return new Exercise { Id = 5300, Name = "Half Zanetti Flies", IsHold = false, GroupId = 53 };

            #endregion

            #region Zanetti Flies

            yield return new Exercise { Id = 5400, Name = "Zanetti Flies", IsHold = false, GroupId = 54 };

            #endregion

            #region Planche Hollow Body

            yield return new Exercise { Id = 5500, Name = "Planche Hollow Body", IsHold = true, GroupId = 55 };

            #endregion

            #region Maltese Hollow Body

            yield return new Exercise { Id = 5600, Name = "Maltese Hollow Body", IsHold = true, GroupId = 56 };

            #endregion

            #region Bench Press

            yield return new Exercise { Id = 5700, Name = "Bench Press", IsHold = false, GroupId = 57 };

            #endregion

            #region Incline Bench Press

            yield return new Exercise { Id = 5800, Name = "Incline Bench Press", IsHold = false, GroupId = 58 };

            #endregion

            #region OHP

            yield return new Exercise { Id = 5900, Name = "OHP", IsHold = false, GroupId = 59 };

            #endregion

            #region Biceps Curls

            yield return new Exercise { Id = 6000, Name = "Biceps Curls", IsHold = false, GroupId = 60 };

            #endregion

            #region Dead Lift

            yield return new Exercise { Id = 6100, Name = "Dead Lift", IsHold = false, GroupId = 61 };

            #endregion

            #region Bridge

            yield return new Exercise { Id = 6200, Name = "Bridge", IsHold = true, GroupId = 62 };

            #endregion

        }
    }
}
