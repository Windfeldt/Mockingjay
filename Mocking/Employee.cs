using System;
using System.Collections.Generic;

namespace Mocking
{
    public class Employee
    {
        object mailbox;
        public Employee()
        {
        }

        public int Id { get; set; }
        public MailBox MailBox
        {
            get;
            internal set;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Wage { get; set; }

        internal double CalculateWeeklySalary(int HOURS, int wage)
        {
            return (HOURS * wage);
        }

        internal double CalculateAverageWeeklySalary(int HOURS, int wage)
        {
            return (HOURS * wage) / 3;
        }
    }
}