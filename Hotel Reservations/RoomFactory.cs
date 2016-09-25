using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hotel_Reservations
{
    class RoomFactory
    {


        public bool createRooms()
        {

            InventoryType anInventory = new InventoryType();

            List<InventoryType> inventoryList = new List<InventoryType>();

            Hotel aHotel1 = new Hotel();

            Room h1room1 = new Room();
            anInventory.Date = "09012016";
            anInventory.Quantity = 3;
            anInventory.HotelId = aHotel1.id;
            anInventory.RoomType = h1room1.type;

            inventoryList.Add(anInventory);

            Room h1room2 = new Room();
            anInventory.Date = "09022016";
            anInventory.Quantity = 3;
            anInventory.HotelId = aHotel1.id;
            anInventory.RoomType = h1room2.type;

            inventoryList.Add(anInventory);

            Room h1room3 = new Room();
            anInventory.Date = "09032016";
            anInventory.Quantity = 2;
            anInventory.HotelId = aHotel1.id;
            anInventory.RoomType = h1room3.type;

            inventoryList.Add(anInventory);

            Room h1room4 = new Room();
            anInventory.Date = "09042016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel1.id;
            anInventory.RoomType = h1room4.type;

            inventoryList.Add(anInventory);


            Hotel aHotel2 = new Hotel();

            Room h2room1 = new Room();
            anInventory.Date = "09052016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel2.id;
            anInventory.RoomType = h2room1.type;

            inventoryList.Add(anInventory);

            Room h2room2 = new Room();
            anInventory.Date = "09062016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel2.id;
            anInventory.RoomType = h2room2.type;

            inventoryList.Add(anInventory);

            Room h2room3 = new Room();
            anInventory.Date = "09072016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel2.id;
            anInventory.RoomType = h2room3.type;

            inventoryList.Add(anInventory);

            Room h2room4 = new Room();
            anInventory.Date = "09082016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel2.id;
            anInventory.RoomType = h2room4.type;

            inventoryList.Add(anInventory);

            Hotel aHotel3 = new Hotel();

            Room h3room1 = new Room();
            anInventory.Date = "09092016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel3.id;
            anInventory.RoomType = h3room1.type;

            inventoryList.Add(anInventory);

            Room h3room2 = new Room();
            anInventory.Date = "09102016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel3.id;
            anInventory.RoomType = h3room2.type;

            inventoryList.Add(anInventory);

            Room h3room3 = new Room();
            anInventory.Date = "09112016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel3.id;
            anInventory.RoomType = h3room3.type;

            inventoryList.Add(anInventory);

            Room h3room4 = new Room();
            anInventory.Date = "09122016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel3.id;
            anInventory.RoomType = h3room4.type;

            inventoryList.Add(anInventory);


            Hotel aHotel4 = new Hotel();

            Room h4room1 = new Room();
            anInventory.Date = "09132016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel4.id;
            anInventory.RoomType = h4room1.type;

            inventoryList.Add(anInventory);

            Room h4room2 = new Room();
            anInventory.Date = "09152016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel4.id;
            anInventory.RoomType = h4room2.type;

            inventoryList.Add(anInventory);

            Room h4room3 = new Room();
            anInventory.Date = "09162016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel4.id;
            anInventory.RoomType = h4room3.type;

            inventoryList.Add(anInventory);

            Room h4room4 = new Room();
            anInventory.Date = "09162016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel4.id;
            anInventory.RoomType = h4room4.type;

            inventoryList.Add(anInventory);

            Hotel aHotel5 = new Hotel();

            Room h5room1 = new Room();
            anInventory.Date = "09172016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel5.id;
            anInventory.RoomType = h5room1.type;

            inventoryList.Add(anInventory);

            Room h5room2 = new Room();
            anInventory.Date = "09182016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel5.id;
            anInventory.RoomType = h5room2.type;

            inventoryList.Add(anInventory);

            Room h5room3 = new Room();
            anInventory.Date = "09192016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel5.id;
            anInventory.RoomType = h5room3.type;

            inventoryList.Add(anInventory);

            Room h5room4 = new Room();
            anInventory.Date = "09202016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel5.id;
            anInventory.RoomType = h5room4.type;

            inventoryList.Add(anInventory);

            Hotel aHotel6 = new Hotel();

            Room h6room1 = new Room();
            anInventory.Date = "09212016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel6.id;
            anInventory.RoomType = h6room1.type;

            inventoryList.Add(anInventory);


            Room h6room2 = new Room();
            anInventory.Date = "09222016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel6.id;
            anInventory.RoomType = h6room2.type;

            inventoryList.Add(anInventory);

            Room h6room3 = new Room();
            anInventory.Date = "09232016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel6.id;
            anInventory.RoomType = h6room3.type;

            inventoryList.Add(anInventory);

            Room h6room4 = new Room();
            anInventory.Date = "09242016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel6.id;
            anInventory.RoomType = h6room4.type;

            inventoryList.Add(anInventory);

            Hotel aHotel7 = new Hotel();

            Room h7room1 = new Room();
            anInventory.Date = "09252016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel7.id;
            anInventory.RoomType = h7room1.type;

            inventoryList.Add(anInventory);

            Room h7room2 = new Room();
            anInventory.Date = "09262016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel7.id;
            anInventory.RoomType = h7room2.type;

            inventoryList.Add(anInventory);

            Room h7room3 = new Room();
            anInventory.Date = "09272016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel7.id;
            anInventory.RoomType = h7room3.type;

            inventoryList.Add(anInventory);

            Room h7room4 = new Room();
            anInventory.Date = "09282016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel7.id;
            anInventory.RoomType = h7room4.type;

            inventoryList.Add(anInventory);

            Hotel aHotel8 = new Hotel();

            Room h8room1 = new Room();
            anInventory.Date = "09292016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel8.id;
            anInventory.RoomType = h8room1.type;

            inventoryList.Add(anInventory);

            Room h8room2 = new Room();
            anInventory.Date = "09302016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel8.id;
            anInventory.RoomType = h8room2.type;

            inventoryList.Add(anInventory);

            Room h8room3 = new Room();
            anInventory.Date = "10012016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel8.id;
            anInventory.RoomType = h8room3.type;

            inventoryList.Add(anInventory);

            Room h8room4 = new Room();
            anInventory.Date = "10022016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel8.id;
            anInventory.RoomType = h8room4.type;

            inventoryList.Add(anInventory);

            Hotel aHotel9 = new Hotel();

            Room h9room1 = new Room();
            anInventory.Date = "10032016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel9.id;
            anInventory.RoomType = h9room1.type;

            inventoryList.Add(anInventory);

            Room h9room2 = new Room();
            anInventory.Date = "10042016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel9.id;
            anInventory.RoomType = h9room2.type;

            inventoryList.Add(anInventory);

            Room h9room3 = new Room();
            anInventory.Date = "10052016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel9.id;
            anInventory.RoomType = h9room3.type;

            inventoryList.Add(anInventory);

            Room h9room4 = new Room();
            anInventory.Date = "10062016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel9.id;
            anInventory.RoomType = h9room4.type;

            inventoryList.Add(anInventory);

            Hotel aHotel10 = new Hotel();

            Room h10room1 = new Room();
            anInventory.Date = "10072016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel10.id;
            anInventory.RoomType = h10room1.type;

            inventoryList.Add(anInventory);

            Room h10room2 = new Room();
            anInventory.Date = "10082016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel10.id;
            anInventory.RoomType = h10room2.type;

            inventoryList.Add(anInventory);

            Room h10room3 = new Room();
            anInventory.Date = "10092016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel10.id;
            anInventory.RoomType = h10room3.type;

            inventoryList.Add(anInventory);

            Room h10room4 = new Room();
            anInventory.Date = "10102016";
            anInventory.Quantity = 4;
            anInventory.HotelId = aHotel10.id;
            anInventory.RoomType = h10room4.type;

            inventoryList.Add(anInventory);




            StreamWriter writer = new StreamWriter("../../roominventory.xml");
            XmlSerializer serializer = new XmlSerializer(inventoryList.GetType());
            serializer.Serialize(writer, inventoryList);



            return true;
        }


    }
}
