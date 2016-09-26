using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Samuel van Dalen and Eduardo Martinez
namespace Hotel_Reservations
{
    public class Distances
    {

        public int beach { get; set; }
        public int shopping { get; set; }
        public int airport { get; set; }


        public Distances() { }

        public Distances(int beach, int shopping, int airport)
        {

            this.beach = beach;
            this.shopping = shopping;
            this.airport = airport;

        }
    }
}
