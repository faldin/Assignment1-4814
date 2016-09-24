using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Hotel_Reservations
{
    public class RoomFactory
    {


        public bool createRooms()
        {

            InventoryType anInventory = new InventoryType();

            List<InventoryType> inventoryList = new List<InventoryType>();

            anInventory.Date = "09222016";
            anInventory.Quantity = 10;
            anInventory.HotelId = aHotel1.id;
            anInventory.RoomType = h1room1.type;

            inventoryList.Add(anInventory);



            StreamWriter writer = new StreamWriter("../../roominventory.xml");
            XmlSerializer serializer = new XmlSerializer(inventoryList.GetType());
            serializer.Serialize(writer, inventoryList);



            return true;
        }


    }
}
