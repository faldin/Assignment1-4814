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


            Hotel aHotel = new Hotel();
            

            aHotel.name = "Old Glory";
            aHotel.address = "10601 sw 48 st";
            aHotel.id = "001";
            aHotel.features.laundry = true;
            aHotel.features.aircon = true;
            aHotel.features.breakfast = true;
            aHotel.features.shuttle = true;
            aHotel.distances.beach = 10;
            aHotel.distances.shopping = 2;
            aHotel.distances.airport = 7;

                for (int i = 0; i < i+4; i++) {
                    Room room1 = new Room("KB", 1+i, i+"/"+i+1);
                    aHotel.listOfRooms.Add(room1);
                }

            hotelList.Add(aHotel);

        


            StreamWriter writer = new StreamWriter("../../hotels.xml");
            XmlSerializer serializer = new XmlSerializer(hotelList.GetType());
            serializer.Serialize(writer, hotelList);



            return true;
        }



    }
}
