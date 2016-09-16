using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations
{
    public class Features
    {

        public Boolean laundry { get; set; }
        public Boolean aircon { get; set; }
        public Boolean breakfast { get; set; }

        public Features() { }

        public Features(Boolean laundry, Boolean aircon, Boolean breakfast, Boolean shuttle)
        {

            this.laundry = laundry;
            this.aircon = aircon;
            this.breakfast = breakfast;
            this.shuttle = shuttle;

        }
    }
}
