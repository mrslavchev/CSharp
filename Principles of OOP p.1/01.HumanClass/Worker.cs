﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanClass
{
    class Worker : Human
    {
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, double salary, double workHours)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = salary;
            this.WorkHoursPerDay = workHours;
        }

        public double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5.0);
        }

    }
}