using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Samuel van Dalen and Eduardo Martinez
namespace Hotel_Reservations
{
    public class Room
    {

        public string type { get; set; }
        public int dailyRate { get; set; }
        public string capacity { get; set; }


        public Room() { }

        public Room(string type, int dailyRate, string capacity)
        {

            this.type = type;
            this.dailyRate = dailyRate;
            this.capacity = capacity;

        }
    }
}
