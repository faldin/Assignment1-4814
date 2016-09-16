using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations
{

    public class Hotel
    {

        public string name { get; set; }
        public string address { get; set; }
        public string id { get; set; }
        public Features features {get; set;}


        Hotel() { }

        public Hotel(string name, string address, string id, Features features)
        {

            this.name = name;
            this.address = address;
            this.id = id;
            this.features = features;

        }
    }



}
