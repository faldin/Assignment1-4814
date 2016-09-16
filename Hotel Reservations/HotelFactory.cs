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

            




                hotelList.Add(aHotel);


            StreamWriter writer = new StreamWriter("../../hotels.xml");
            XmlSerializer serializer = new XmlSerializer(hotelList.GetType());
            serializer.Serialize(writer, hotelList);



            return true;
        }



    }
}
