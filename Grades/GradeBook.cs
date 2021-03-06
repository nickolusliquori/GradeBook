﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradesStatistics ComputeStatistics()
        {
            GradesStatistics stats =  new GradesStatistics();

            stats.HighestGrade = 0;

            float sum = 0;

            foreach (float grade in grades)
                {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
                }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        private List<float> grades;
    }
}
