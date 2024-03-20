using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoDucManh_21115053120332_LinQSearch
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public DateTime Birthday { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public string Description { get; set; }
        public static List<Employee> getEmployees()
        {
            return new List<Employee>()
            {
                new Employee{ID = 1, Name = "Tran Chi Vi", Age = 20, Salary = 1000, Birthday = new DateTime(2004, 01, 10), DepartmentID = 1, PositionID = 3, Description = "Intern"},
                new Employee{ID = 2, Name = "Hoang Dung", Age = 21, Salary = 1500, Birthday = new DateTime(2003, 01, 10), DepartmentID = 2, PositionID = 2, Description = "Fresher"},
                new Employee{ID = 3, Name = "Truong Cao Phong", Age = 22, Salary = 3000, Birthday = new DateTime(2002, 01, 10), DepartmentID = 3, PositionID = 2, Description = "Fresher"},
                new Employee{ID = 4, Name = "Doan Duoc Diem", Age = 23, Salary = 2500, Birthday = new DateTime(2001, 01, 10), DepartmentID = 1, PositionID = 2, Description = "Senior"},
                new Employee{ID = 5, Name = "Hoang Da Quynh", Age = 24, Salary = 2000, Birthday = new DateTime(2000, 01, 10), DepartmentID = 2, PositionID = 1, Description = "Senior"}
            };
        }
    }
}
