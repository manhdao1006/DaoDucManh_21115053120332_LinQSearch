using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoDucManh_21115053120332_LinQSearch
{
    class List
    {
        List<Department> departments = Department.getDepartments();
        List<Employee> employees = Employee.getEmployees();
        List<Position> positions = Position.getPositions();
        public List() { }
        public void Search()
        {
            Console.Write("Tu khoa tim kiem: ");
            string keyword = Console.ReadLine();

            Console.Write("Tuoi tu: ");
            int minAge = int.Parse(Console.ReadLine());

            Console.Write("Den tuoi: ");
            int maxAge = int.Parse(Console.ReadLine());

            Console.Write("Vi tri: ");
            string positionKeyWord = Console.ReadLine();

            Console.Write("Phong ban: ");
            string departmentKeyWord = Console.ReadLine();

            var result = from employee in employees
                         join position in positions on employee.PositionID equals position.ID
                         join department in departments on employee.DepartmentID equals department.ID
                         where (employee.Name.Contains(keyword) || employee.Description.Contains(keyword) ||
                                position.Name.Contains(keyword) || position.Description.Contains(keyword) ||
                                department.Name.Contains(keyword) || department.Description.Contains(keyword)) &&
                                employee.Age >= minAge && employee.Age <= maxAge &&
                                position.Name.Contains(positionKeyWord) &&
                                department.Name.Contains(departmentKeyWord)
                         select new
                         {
                             EmployeeName = employee.Name,
                             EmployeeAge = employee.Age,
                             EmployeeDescription = employee.Description,
                             PositionName = position.Name,
                             PositionDesciption = position.Description,
                             DepartmentName = department.Name,
                             DepartmentDescription = department.Description
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"Employee:\n Name: {item.EmployeeName}, Age: {item.EmployeeAge}, Description: {item.EmployeeDescription}");
                Console.WriteLine($"Position:\n Name: {item.PositionName}, Description: {item.PositionDesciption}");
                Console.WriteLine($"Department:\n Name: {item.DepartmentName}, Description: {item.DepartmentDescription}");
            }
        }
    }
}