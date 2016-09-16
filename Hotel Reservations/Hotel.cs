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


        public Hotel() { }

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
