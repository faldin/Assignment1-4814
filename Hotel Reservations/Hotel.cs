using Hotel_Reservations;
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
        public Distances distances { get; set;}
        public List<Room> listOfRooms { get; set;}


        public Hotel()
        {
            this.name = name;
            this.address = address;
            this.id = id;
            this.features = features;
            this.distances = distances;
            this.listOfRooms = listOfRooms;
            this.features.laundry = new Boolean();

        }

        public Hotel(string name, string address, string id)
        {

            this.name = name;
            this.address = address;
            this.id = id;
            this.features = features;
            this.distances = distances;
            this.listOfRooms = listOfRooms;
            this.features.laundry = true;
            this.features.aircon = true;
            this.features.breakfast = true;
            this.features.shuttle = true;
            this.distances.beach = 10;
            this.distances.shopping = 2;
            this.distances.airport = 7;


        }
    }



}
