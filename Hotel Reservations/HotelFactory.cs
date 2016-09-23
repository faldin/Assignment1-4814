using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hotel_Reservations
{
    class HotelFactory
    {
        public bool CreateHotelFile()
        {


            List<Hotel> hotelList = new List<Hotel>(10);

            //Hotel 1
            Hotel aHotel1 = new Hotel();
            

            aHotel1.name = "Old Glory";
            aHotel1.address = "10601 sw 48 st";
            aHotel1.id = "001";
            aHotel1.varfeatures.laundry = true;
            aHotel1.varfeatures.aircon = true;
            aHotel1.varfeatures.breakfast = true;
            aHotel1.varfeatures.shuttle = true;
            aHotel1.distances.beach = 10;
            aHotel1.distances.shopping = 2;
            aHotel1.distances.airport = 7;


            
                    Room h1room1 = new Room();
                    h1room1.capacity = "2/5";
                    h1room1.dailyRate = 50;
                    h1room1.type = "KB";
                    
               aHotel1.listOfRooms.Add(h1room1);

               hotelList.Add(aHotel1);



            //Hotel 2
            Hotel aHotel2 = new Hotel();


            aHotel2.name = "Oldest Glory";
            aHotel2.address = "66954 nw 98 st";
            aHotel2.id = "002";
            aHotel2.varfeatures.laundry = false;
            aHotel2.varfeatures.aircon = true;
            aHotel2.varfeatures.breakfast = false;
            aHotel2.varfeatures.shuttle = true;
            aHotel2.distances.beach = 3;
            aHotel2.distances.shopping = 9;
            aHotel2.distances.airport = 4;



            Room h2room1 = new Room();
            h2room1.capacity = "5/8";
            h2room1.dailyRate = 80;
            h2room1.type = "QB";

            aHotel2.listOfRooms.Add(h2room1);

            hotelList.Add(aHotel2);



            StreamWriter writerb = new StreamWriter("../../hotels.xml");
            XmlSerializer serializerb = new XmlSerializer(hotelList.GetType());
            serializerb.Serialize(writerb, hotelList);




            return true;
        }







    }
}
