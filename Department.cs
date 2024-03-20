using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoDucManh_21115053120332_LinQSearch
{
    class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public static List<Department> getDepartments()
        {
            return new List<Department>()
            {
                new Department {ID = 1, Name = "IT", Description = "Bo phan cong nghe thong tin"},
                new Department {ID = 2, Name = "HR", Description = "Bo phan quan ly nhan su"},
                new Department {ID = 3, Name = "Marketing", Description = "Bo phan quang ba, quang cao"}
            };
        }
    }
}
