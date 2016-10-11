using System;
using System.Collections.Generic;

namespace Mocking
{
    public class Employee:IEmployeeRepository
    {
        public Employee()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Wage { get; set; }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int CountEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee CreateEmployee(string name, string type)
        {
            throw new NotImplementedException();
        }

        public List<Employee> FindAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee LoadEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        internal double CalculateWeeklySalary(int HOURS, int wage)
        {
            return (HOURS * wage);
        }
    }
}