﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GymManagementSystem.Models
{
    /// <summary>
    /// Schedule Model
    /// </summary>
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        public DayOfWeek Day { get; set; }

        [Display(Name = "Program")]
        public string ProgramName { get; set; }

        [Display(Name = "Start Time")]
        public DateTime? StartTime { get; set; }

        [Display(Name = "End Time")]
        public DateTime? EndTime { get; set; }

        // READ ONLY

        [Display(Name = "Schedule Description")]
        public string Description
        {
            get { return $"{ProgramName} - {Day} - {StartTime.Value.ToShortTimeString()} to {EndTime.Value.ToShortTimeString()}"; }
        }

        // RELATIONSHIP

        [Display(Name = "Trainer")]
        public int TrainerId { get; set; }

        public Trainer Trainer { get; set; }
    }

    /// <summary>
    /// Contant class
    /// </summary>
    public static class Constant
    {
        public static int MaxLimitOfSession { get { return 5; } }

        /// <summary>
        /// Gets the days of week.
        /// </summary>
        /// <returns></returns>
        public static List<DayOfWeek> GetDaysOfWeek()
        {
            return new List<DayOfWeek>
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday
            };
        }
    }
}