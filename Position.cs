using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoDucManh_21115053120332_LinQSearch
{
    class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public static List<Position> getPositions()
        {
            return new List<Position>()
            {
                new Position {ID = 1, Name = "Leader", Description = "Nhom truong"},
                new Position {ID = 2, Name = "Mentor", Description = "Nguoi huong dan"},
                new Position {ID = 3, Name = "Member", Description = "Thanh vien"}
            };
        }
    }
}
