using Hotel_Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Samuel van Dalen and Eduardo Martinez
namespace Hotel_Reservations
{

    public class Hotel
    {

        public string name { get; set; }
        public string address { get; set; }
        public string id { get; set; }
        public Features varfeatures {get; set;}
        public Distances distances { get; set;}
        public List<Room> listOfRooms { get; set;}


        public Hotel()
        {
            this.name = name;
            this.address = address;
            this.id = id;
            this.varfeatures = new Features();
            this.distances = new Distances();
            this.listOfRooms = new List<Room>();

        }

        public Hotel(string name, string address, string id)
        {

            this.name = name;
            this.address = address;
            this.id = id;
            this.varfeatures = new Features();
            this.distances = new Distances();
            this.listOfRooms = new List<Room>();


        }
    }



}
