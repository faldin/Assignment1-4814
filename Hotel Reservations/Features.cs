//Eduardo M. Martin
//Samuel Van Dalen
//COP 4814 U03 - Component Based Software Dev - Fall 2016
//Assignment1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Samuel van Dalen and Eduardo Martinez
namespace Hotel_Reservations
{
    public class Features
    {

        public bool laundry { get; set; }
        public bool aircon { get; set; }
        public bool breakfast { get; set; }
        public bool shuttle { get; set; }


        public Features() { }


        public Features(bool laundry, bool aircon, bool breakfast, bool shuttle)
        {

            this.laundry = laundry;
            this.aircon = aircon;
            this.breakfast = breakfast;
            this.shuttle = shuttle;


        }
    }
}
