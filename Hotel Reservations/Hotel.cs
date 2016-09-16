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


        public Hotel() {

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

            for (int i = 0; i < i + 4; i++)
            {
                Room room1 = new Room("KB", 1 + i, i + "/" + i + 1);
                this.listOfRooms.Add(room1);
            }

        }

        public Hotel(string name, string address, string id, Features features, Distances distances, List<Room> listOfRooms)
        {

            this.name = name;
            this.address = address;
            this.id = id;
            this.features = features;
            this.distances = distances;
            this.listOfRooms = listOfRooms;


        }
    }



}
