using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadOperator
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }

        public static bool operator== (Employee employee, Employee employee1)
        {
            if (employee.ID == employee1.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!= (Employee employee, Employee employee1)
        {
            if (employee.ID != employee1.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
