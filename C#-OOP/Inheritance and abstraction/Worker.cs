using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction
{
        public class Worker : Human
        {
            private double weekSalary;
            private int workHoursPerDay;
            public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
                : base(firstName, lastName)
            {
                this.WeekSalary = weekSalary;
                this.WorkHoursPerDay = workHoursPerDay;
            }
            public double WeekSalary
            {
                get
                {
                    return this.weekSalary;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("The week salary cannot be a negative number");
                    }
                    this.weekSalary = value;
                }
            }

            public int WorkHoursPerDay
            {
                get
                {
                    return this.workHoursPerDay;
                }
                set
                {
                    if (value < 0 && value > 24)
                    {
                        throw new ArgumentOutOfRangeException("The work hours per day must be in the range [0;24]");
                    }
                    this.workHoursPerDay = value;
                }
            }
            public double MoneyPerHour()
            {
                double moneyPerDay = this.weekSalary / 7;
                double moneyPerHour = moneyPerDay / this.workHoursPerDay;
                return moneyPerHour;
            }
        }
}
