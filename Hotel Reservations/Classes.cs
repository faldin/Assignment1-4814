using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace Hotel_Reservations
{
    public partial class Classes : Component
    {
        public Classes()
        {
            InitializeComponent();
        }

        public Classes(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


    }

    public class RoomFactory
    {



        public bool createRooms()
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

            Room h1room2 = new Room();
            h1room2.capacity = "1/2";
            h1room2.dailyRate = 35;
            h1room2.type = "TB";

            aHotel1.listOfRooms.Add(h1room2);

            Room h1room3 = new Room();
            h1room3.capacity = "1/3";
            h1room3.dailyRate = 45;
            h1room3.type = "QB";

            aHotel1.listOfRooms.Add(h1room3);

            Room h1room4 = new Room();
            h1room4.capacity = "2/3";
            h1room4.dailyRate = 40;
            h1room4.type = "QB";

            aHotel1.listOfRooms.Add(h1room4);

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
            h2room1.capacity = "1/4";
            h2room1.dailyRate = 55;
            h2room1.type = "KB";

            aHotel2.listOfRooms.Add(h2room1);

            Room h2room2 = new Room();
            h2room2.capacity = "1/2";
            h2room2.dailyRate = 35;
            h2room2.type = "TB";

            aHotel2.listOfRooms.Add(h2room2);

            Room h2room3 = new Room();
            h2room3.capacity = "1/3";
            h2room3.dailyRate = 45;
            h2room3.type = "TB";

            aHotel2.listOfRooms.Add(h2room3);

            Room h2room4 = new Room();
            h2room4.capacity = "2/3";
            h2room4.dailyRate = 40;
            h2room4.type = "QB";

            aHotel2.listOfRooms.Add(h2room4);

            hotelList.Add(aHotel2);


            //Hotel 3
            Hotel aHotel3 = new Hotel();


            aHotel3.name = "Oldester Glory";
            aHotel3.address = "84920 w 8 st";
            aHotel3.id = "003";
            aHotel3.varfeatures.laundry = false;
            aHotel3.varfeatures.aircon = true;
            aHotel3.varfeatures.breakfast = true;
            aHotel3.varfeatures.shuttle = false;
            aHotel3.distances.beach = 5;
            aHotel3.distances.shopping = 1;
            aHotel3.distances.airport = 2;



            Room h3room1 = new Room();
            h3room1.capacity = "1/4";
            h3room1.dailyRate = 55;
            h3room1.type = "KB";

            aHotel3.listOfRooms.Add(h3room1);

            Room h3room2 = new Room();
            h3room2.capacity = "1/2";
            h3room2.dailyRate = 35;
            h3room2.type = "TB";

            aHotel3.listOfRooms.Add(h3room2);

            Room h3room3 = new Room();
            h3room3.capacity = "1/3";
            h3room3.dailyRate = 45;
            h3room3.type = "QB";

            aHotel3.listOfRooms.Add(h3room3);

            Room h3room4 = new Room();
            h3room4.capacity = "2/3";
            h3room4.dailyRate = 40;
            h3room4.type = "KB";

            aHotel3.listOfRooms.Add(h3room4);

            hotelList.Add(aHotel3);


            //Hotel 4
            Hotel aHotel4 = new Hotel();


            aHotel4.name = "Oldesterest Glory";
            aHotel4.address = "82430 w 90 st";
            aHotel4.id = "004";
            aHotel4.varfeatures.laundry = true;
            aHotel4.varfeatures.aircon = true;
            aHotel4.varfeatures.breakfast = true;
            aHotel4.varfeatures.shuttle = true;
            aHotel4.distances.beach = 4;
            aHotel4.distances.shopping = 3;
            aHotel4.distances.airport = 2;



            Room h4room1 = new Room();
            h4room1.capacity = "1/4";
            h4room1.dailyRate = 55;
            h4room1.type = "KB";

            aHotel4.listOfRooms.Add(h4room1);

            Room h4room2 = new Room();
            h4room2.capacity = "1/2";
            h4room2.dailyRate = 35;
            h4room2.type = "TB";

            aHotel4.listOfRooms.Add(h4room2);

            Room h4room3 = new Room();
            h4room3.capacity = "1/3";
            h4room3.dailyRate = 45;
            h4room3.type = "QB";

            aHotel4.listOfRooms.Add(h4room3);

            Room h4room4 = new Room();
            h4room4.capacity = "2/3";
            h4room4.dailyRate = 40;
            h4room4.type = "QB";

            aHotel4.listOfRooms.Add(h4room4);

            hotelList.Add(aHotel4);



            //Hotel 5
            Hotel aHotel5 = new Hotel();


            aHotel5.name = "Oldesteresting Glory";
            aHotel5.address = "11832 nw 12 st";
            aHotel5.id = "005";
            aHotel5.varfeatures.laundry = true;
            aHotel5.varfeatures.aircon = true;
            aHotel5.varfeatures.breakfast = false;
            aHotel5.varfeatures.shuttle = false;
            aHotel5.distances.beach = 4;
            aHotel5.distances.shopping = 3;
            aHotel5.distances.airport = 3;



            Room h5room1 = new Room();
            h5room1.capacity = "2/4";
            h5room1.dailyRate = 45;
            h5room1.type = "KB";

            aHotel5.listOfRooms.Add(h5room1);

            Room h5room2 = new Room();
            h5room2.capacity = "1/2";
            h5room2.dailyRate = 35;
            h5room2.type = "TB";

            aHotel5.listOfRooms.Add(h5room2);

            Room h5room3 = new Room();
            h5room3.capacity = "2/3";
            h5room3.dailyRate = 55;
            h5room3.type = "QB";

            aHotel5.listOfRooms.Add(h5room3);

            Room h5room4 = new Room();
            h5room4.capacity = "2/3";
            h5room4.dailyRate = 40;
            h5room4.type = "QB";

            aHotel5.listOfRooms.Add(h5room4);

            hotelList.Add(aHotel5);


            //Hotel 6
            Hotel aHotel6 = new Hotel();


            aHotel6.name = "Oldesteresting Glories";
            aHotel6.address = "11234 nw 14 st";
            aHotel6.id = "006";
            aHotel6.varfeatures.laundry = false;
            aHotel6.varfeatures.aircon = false;
            aHotel6.varfeatures.breakfast = false;
            aHotel6.varfeatures.shuttle = false;
            aHotel6.distances.beach = 4;
            aHotel6.distances.shopping = 3;
            aHotel6.distances.airport = 3;



            Room h6room1 = new Room();
            h6room1.capacity = "2/4";
            h6room1.dailyRate = 45;
            h6room1.type = "KB";

            aHotel6.listOfRooms.Add(h6room1);

            Room h6room2 = new Room();
            h6room2.capacity = "1/2";
            h6room2.dailyRate = 35;
            h6room2.type = "TB";

            aHotel6.listOfRooms.Add(h6room2);

            Room h6room3 = new Room();
            h6room3.capacity = "2/3";
            h6room3.dailyRate = 55;
            h6room3.type = "QB";

            aHotel6.listOfRooms.Add(h6room3);

            Room h6room4 = new Room();
            h6room4.capacity = "2/3";
            h6room4.dailyRate = 40;
            h6room4.type = "QB";

            aHotel6.listOfRooms.Add(h6room4);

            hotelList.Add(aHotel6);


            //Hotel 7
            Hotel aHotel7 = new Hotel();


            aHotel7.name = "Oldesteresting Gloriesest";
            aHotel7.address = "98274 nw 16 st";
            aHotel7.id = "007";
            aHotel7.varfeatures.laundry = true;
            aHotel7.varfeatures.aircon = false;
            aHotel7.varfeatures.breakfast = false;
            aHotel7.varfeatures.shuttle = false;
            aHotel7.distances.beach = 5;
            aHotel7.distances.shopping = 3;
            aHotel7.distances.airport = 4;



            Room h7room1 = new Room();
            h7room1.capacity = "2/4";
            h7room1.dailyRate = 45;
            h7room1.type = "KB";

            aHotel7.listOfRooms.Add(h7room1);

            Room h7room2 = new Room();
            h7room2.capacity = "1/2";
            h7room2.dailyRate = 35;
            h7room2.type = "TB";

            aHotel7.listOfRooms.Add(h7room2);

            Room h7room3 = new Room();
            h7room3.capacity = "2/3";
            h7room3.dailyRate = 55;
            h7room3.type = "QB";

            aHotel7.listOfRooms.Add(h7room3);

            Room h7room4 = new Room();
            h7room4.capacity = "2/3";
            h7room4.dailyRate = 40;
            h7room4.type = "QB";

            aHotel7.listOfRooms.Add(h7room4);

            hotelList.Add(aHotel7);



            //Hotel 8
            Hotel aHotel8 = new Hotel();


            aHotel8.name = "Oldesteresting Gloriesester";
            aHotel8.address = "11234 nw 14 st";
            aHotel8.id = "008";
            aHotel8.varfeatures.laundry = false;
            aHotel8.varfeatures.aircon = false;
            aHotel8.varfeatures.breakfast = true;
            aHotel8.varfeatures.shuttle = true;
            aHotel8.distances.beach = 7;
            aHotel8.distances.shopping = 9;
            aHotel8.distances.airport = 600;



            Room h8room1 = new Room();
            h8room1.capacity = "2/4";
            h8room1.dailyRate = 45;
            h8room1.type = "KB";

            aHotel8.listOfRooms.Add(h8room1);

            Room h8room2 = new Room();
            h8room2.capacity = "1/2";
            h8room2.dailyRate = 35;
            h8room2.type = "TB";

            aHotel8.listOfRooms.Add(h8room2);

            Room h8room3 = new Room();
            h8room3.capacity = "2/3";
            h8room3.dailyRate = 55;
            h8room3.type = "QB";

            aHotel8.listOfRooms.Add(h8room3);

            Room h8room4 = new Room();
            h8room4.capacity = "2/3";
            h8room4.dailyRate = 40;
            h8room4.type = "QB";

            aHotel8.listOfRooms.Add(h8room4);

            hotelList.Add(aHotel8);


            //Hotel 9
            Hotel aHotel9 = new Hotel();


            aHotel9.name = "Oldesteresting Gloriesesterest";
            aHotel9.address = "11234 nw 14 st";
            aHotel9.id = "009";
            aHotel9.varfeatures.laundry = true;
            aHotel9.varfeatures.aircon = true;
            aHotel9.varfeatures.breakfast = false;
            aHotel9.varfeatures.shuttle = false;
            aHotel9.distances.beach = 4;
            aHotel9.distances.shopping = 3;
            aHotel9.distances.airport = 3;



            Room h9room1 = new Room();
            h9room1.capacity = "2/4";
            h9room1.dailyRate = 45;
            h9room1.type = "KB";

            aHotel9.listOfRooms.Add(h9room1);

            Room h9room2 = new Room();
            h9room2.capacity = "1/2";
            h9room2.dailyRate = 35;
            h9room2.type = "TB";

            aHotel9.listOfRooms.Add(h9room2);

            Room h9room3 = new Room();
            h9room3.capacity = "2/3";
            h9room3.dailyRate = 55;
            h9room3.type = "QB";

            aHotel9.listOfRooms.Add(h9room3);

            Room h9room4 = new Room();
            h9room4.capacity = "2/3";
            h9room4.dailyRate = 40;
            h9room4.type = "QB";

            aHotel9.listOfRooms.Add(h9room4);

            hotelList.Add(aHotel9);



            //Hotel 10
            Hotel aHotel10 = new Hotel();


            aHotel10.name = "Oldesteresting Gloriesesteresters";
            aHotel10.address = "13370 sw 9 st";
            aHotel10.id = "010";
            aHotel10.varfeatures.laundry = true;
            aHotel10.varfeatures.aircon = true;
            aHotel10.varfeatures.breakfast = true;
            aHotel10.varfeatures.shuttle = true;
            aHotel10.distances.beach = 4;
            aHotel10.distances.shopping = 5;
            aHotel10.distances.airport = 6;



            Room h10room1 = new Room();
            h10room1.capacity = "2/4";
            h10room1.dailyRate = 45;
            h10room1.type = "KB";

            aHotel10.listOfRooms.Add(h10room1);

            Room h10room2 = new Room();
            h10room2.capacity = "1/2";
            h10room2.dailyRate = 35;
            h10room2.type = "TB";

            aHotel10.listOfRooms.Add(h10room2);

            Room h10room3 = new Room();
            h10room3.capacity = "2/3";
            h10room3.dailyRate = 55;
            h10room3.type = "QB";

            aHotel10.listOfRooms.Add(h10room3);

            Room h10room4 = new Room();
            h10room4.capacity = "2/3";
            h10room4.dailyRate = 40;
            h10room4.type = "QB";

            aHotel10.listOfRooms.Add(h10room4);

            hotelList.Add(aHotel10);




            List<InventoryType> inventoryList = new List<InventoryType>();

            InventoryType room1 = new InventoryType();
            InventoryType room2 = new InventoryType();
            InventoryType room3 = new InventoryType();
            InventoryType room4 = new InventoryType();
            InventoryType room5 = new InventoryType();
            InventoryType room6 = new InventoryType();
            InventoryType room7 = new InventoryType();
            InventoryType room8 = new InventoryType();
            InventoryType room9 = new InventoryType();
            InventoryType room10 = new InventoryType();
            InventoryType room11 = new InventoryType();
            InventoryType room12 = new InventoryType();
            InventoryType room13 = new InventoryType();
            InventoryType room14 = new InventoryType();
            InventoryType room15 = new InventoryType();
            InventoryType room16 = new InventoryType();
            InventoryType room17 = new InventoryType();
            InventoryType room18 = new InventoryType();
            InventoryType room19 = new InventoryType();
            InventoryType room20 = new InventoryType();
            InventoryType room21 = new InventoryType();
            InventoryType room22 = new InventoryType();
            InventoryType room23 = new InventoryType();
            InventoryType room24 = new InventoryType();
            InventoryType room25 = new InventoryType();
            InventoryType room26 = new InventoryType();
            InventoryType room27 = new InventoryType();
            InventoryType room28 = new InventoryType();
            InventoryType room29 = new InventoryType();
            InventoryType room30 = new InventoryType();
            InventoryType room31 = new InventoryType();
            InventoryType room32 = new InventoryType();
            InventoryType room33 = new InventoryType();
            InventoryType room34 = new InventoryType();
            InventoryType room35 = new InventoryType();
            InventoryType room36 = new InventoryType();
            InventoryType room37 = new InventoryType();
            InventoryType room38 = new InventoryType();
            InventoryType room39 = new InventoryType();
            InventoryType room40 = new InventoryType();

            room1.Date = "09012016";
            room1.Quantity = 3;
            room1.HotelId = aHotel1.id;
            room1.RoomType = h1room1.type;

            inventoryList.Add(room1);


            room2.Date = "09022016";
            room2.Quantity = 3;
            room2.HotelId = aHotel1.id;
            room2.RoomType = h1room2.type;

            inventoryList.Add(room2);

            room3.Date = "09032016";
            room3.Quantity = 2;
            room3.HotelId = aHotel1.id;
            room3.RoomType = h1room3.type;

            inventoryList.Add(room3);

            room4.Date = "09042016";
            room4.Quantity = 4;
            room4.HotelId = aHotel1.id;
            room4.RoomType = h1room4.type;

            inventoryList.Add(room4);



            room5.Date = "09052016";
            room5.Quantity = 4;
            room5.HotelId = aHotel2.id;
            room5.RoomType = h2room1.type;

            inventoryList.Add(room5);

            room6.Date = "09062016";
            room6.Quantity = 4;
            room6.HotelId = aHotel2.id;
            room6.RoomType = h2room2.type;

            inventoryList.Add(room6);

            room7.Date = "09072016";
            room7.Quantity = 4;
            room7.HotelId = aHotel2.id;
            room7.RoomType = h2room3.type;

            inventoryList.Add(room7);

            room8.Date = "09082016";
            room8.Quantity = 4;
            room8.HotelId = aHotel2.id;
            room8.RoomType = h2room4.type;

            inventoryList.Add(room8);


            room9.Date = "09092016";
            room9.Quantity = 4;
            room9.HotelId = aHotel3.id;
            room9.RoomType = h3room1.type;

            inventoryList.Add(room9);

            room10.Date = "09102016";
            room10.Quantity = 4;
            room10.HotelId = aHotel3.id;
            room10.RoomType = h3room2.type;

            inventoryList.Add(room10);

            room11.Date = "09112016";
            room11.Quantity = 4;
            room11.HotelId = aHotel3.id;
            room11.RoomType = h3room3.type;

            inventoryList.Add(room11);

            room12.Date = "09122016";
            room12.Quantity = 4;
            room12.HotelId = aHotel3.id;
            room12.RoomType = h3room4.type;

            inventoryList.Add(room12);



            room13.Date = "09132016";
            room13.Quantity = 4;
            room13.HotelId = aHotel4.id;
            room13.RoomType = h4room1.type;

            inventoryList.Add(room13);

            room14.Date = "09152016";
            room14.Quantity = 4;
            room14.HotelId = aHotel4.id;
            room14.RoomType = h4room2.type;

            inventoryList.Add(room14);

            room15.Date = "09162016";
            room15.Quantity = 4;
            room15.HotelId = aHotel4.id;
            room15.RoomType = h4room3.type;

            inventoryList.Add(room15);

            room16.Date = "09162016";
            room16.Quantity = 4;
            room16.HotelId = aHotel4.id;
            room16.RoomType = h4room4.type;

            inventoryList.Add(room16);


            room17.Date = "09172016";
            room17.Quantity = 4;
            room17.HotelId = aHotel5.id;
            room17.RoomType = h5room1.type;

            inventoryList.Add(room17);

            room18.Date = "09182016";
            room18.Quantity = 4;
            room18.HotelId = aHotel5.id;
            room18.RoomType = h5room2.type;

            inventoryList.Add(room18);

            room19.Date = "09192016";
            room19.Quantity = 4;
            room19.HotelId = aHotel5.id;
            room19.RoomType = h5room3.type;

            inventoryList.Add(room19);

            room20.Date = "09202016";
            room20.Quantity = 4;
            room20.HotelId = aHotel5.id;
            room20.RoomType = h5room4.type;

            inventoryList.Add(room20);



            room21.Date = "09212016";
            room21.Quantity = 4;
            room21.HotelId = aHotel6.id;
            room21.RoomType = h6room1.type;

            inventoryList.Add(room21);


            room22.Date = "09222016";
            room22.Quantity = 4;
            room22.HotelId = aHotel6.id;
            room22.RoomType = h6room2.type;

            inventoryList.Add(room22);

            room23.Date = "09232016";
            room23.Quantity = 4;
            room23.HotelId = aHotel6.id;
            room23.RoomType = h6room3.type;

            inventoryList.Add(room23);

            room24.Date = "09242016";
            room24.Quantity = 4;
            room24.HotelId = aHotel6.id;
            room24.RoomType = h6room4.type;

            inventoryList.Add(room24);


            room25.Date = "09252016";
            room25.Quantity = 4;
            room25.HotelId = aHotel7.id;
            room25.RoomType = h7room1.type;

            inventoryList.Add(room25);

            room26.Date = "09262016";
            room26.Quantity = 4;
            room26.HotelId = aHotel7.id;
            room26.RoomType = h7room2.type;

            inventoryList.Add(room26);

            room27.Date = "09272016";
            room27.Quantity = 4;
            room27.HotelId = aHotel7.id;
            room27.RoomType = h7room3.type;

            inventoryList.Add(room27);

            room28.Date = "09282016";
            room28.Quantity = 4;
            room28.HotelId = aHotel7.id;
            room28.RoomType = h7room4.type;

            inventoryList.Add(room28);


            room29.Date = "09292016";
            room29.Quantity = 4;
            room29.HotelId = aHotel8.id;
            room29.RoomType = h8room1.type;

            inventoryList.Add(room29);

            room30.Date = "09302016";
            room30.Quantity = 4;
            room30.HotelId = aHotel8.id;
            room30.RoomType = h8room2.type;

            inventoryList.Add(room30);

            room31.Date = "10012016";
            room31.Quantity = 4;
            room31.HotelId = aHotel8.id;
            room13.RoomType = h8room3.type;

            inventoryList.Add(room31);

            room32.Date = "10022016";
            room32.Quantity = 4;
            room32.HotelId = aHotel8.id;
            room32.RoomType = h8room4.type;

            inventoryList.Add(room32);


            room33.Date = "10032016";
            room33.Quantity = 4;
            room33.HotelId = aHotel9.id;
            room33.RoomType = h9room1.type;

            inventoryList.Add(room33);

            room34.Date = "10042016";
            room34.Quantity = 4;
            room34.HotelId = aHotel9.id;
            room34.RoomType = h9room2.type;

            inventoryList.Add(room34);

            room35.Date = "10052016";
            room35.Quantity = 4;
            room35.HotelId = aHotel9.id;
            room35.RoomType = h9room3.type;

            inventoryList.Add(room35);

            room36.Date = "10062016";
            room36.Quantity = 4;
            room36.HotelId = aHotel9.id;
            room36.RoomType = h9room4.type;

            inventoryList.Add(room36);


            room37.Date = "10072016";
            room37.Quantity = 4;
            room37.HotelId = aHotel10.id;
            room37.RoomType = h10room1.type;

            inventoryList.Add(room37);

            room38.Date = "10082016";
            room38.Quantity = 4;
            room38.HotelId = aHotel10.id;
            room38.RoomType = h10room2.type;

            inventoryList.Add(room38);

            room39.Date = "10092016";
            room39.Quantity = 4;
            room39.HotelId = aHotel10.id;
            room39.RoomType = h10room3.type;

            inventoryList.Add(room39);

            room40.Date = "10102016";
            room40.Quantity = 4;
            room40.HotelId = aHotel10.id;
            room40.RoomType = h10room4.type;

            inventoryList.Add(room40);




            StreamWriter writer = new StreamWriter("../../roominventory.xml");
            XmlSerializer serializer = new XmlSerializer(inventoryList.GetType());
            serializer.Serialize(writer, inventoryList);



            return true;
        }


    }

    public class Room
    {

        public string type { get; set; }
        public int dailyRate { get; set; }
        public string capacity { get; set; }


        public Room() { }

        public Room(string type, int dailyRate, string capacity)
        {

            this.type = type;
            this.dailyRate = dailyRate;
            this.capacity = capacity;

        }

    }

    public class InventoryType

    {

        public string Date { get; set; }
        public string HotelId { get; set; }
        public string RoomType { get; set; }
        public int Quantity { get; set; }



        public InventoryType() { }

        public InventoryType(string Date, string HotelId, string RoomType, int Quantity)
        {

            this.Date = Date;
            this.HotelId = HotelId;
            this.RoomType = RoomType;
            this.Quantity = Quantity;
        }
    }

    public class HotelFactory
    {
        public bool CreateHotelFile()
        {


            List<Hotel> hotelList = new List<Hotel>(10);

            //Hotel 1
            Hotel aHotel1 = new Hotel();


            aHotel1.name = "Old Glory";
            aHotel1.address = "10601 sw 48 st";
            aHotel1.id = "001";
            aHotel1.rating = "4.5";
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

            Room h1room2 = new Room();
            h1room2.capacity = "1/3";
            h1room2.dailyRate = 45;
            h1room2.type = "QB";

            aHotel1.listOfRooms.Add(h1room2);

            Room h1room3 = new Room();
            h1room3.capacity = "1/3";
            h1room3.dailyRate = 45;
            h1room3.type = "QB";

            aHotel1.listOfRooms.Add(h1room3);

            Room h1room4 = new Room();
            h1room4.capacity = "2/3";
            h1room4.dailyRate = 40;
            h1room4.type = "QB";

            aHotel1.listOfRooms.Add(h1room4);

            hotelList.Add(aHotel1);



            //Hotel 2
            Hotel aHotel2 = new Hotel();


            aHotel2.name = "Oldest Glory";
            aHotel2.address = "66954 nw 98 st";
            aHotel2.id = "002";
            aHotel2.rating = "5";
            aHotel2.varfeatures.laundry = false;
            aHotel2.varfeatures.aircon = true;
            aHotel2.varfeatures.breakfast = false;
            aHotel2.varfeatures.shuttle = true;
            aHotel2.distances.beach = 3;
            aHotel2.distances.shopping = 9;
            aHotel2.distances.airport = 4;

            Room h2room1 = new Room();
            h2room1.capacity = "1/4";
            h2room1.dailyRate = 55;
            h2room1.type = "KB";

            aHotel2.listOfRooms.Add(h2room1);

            Room h2room2 = new Room();
            h2room2.capacity = "1/2";
            h2room2.dailyRate = 35;
            h2room2.type = "TB";

            aHotel2.listOfRooms.Add(h2room2);

            Room h2room3 = new Room();
            h2room3.capacity = "1/3";
            h2room3.dailyRate = 45;
            h2room3.type = "QB";

            aHotel2.listOfRooms.Add(h2room3);

            Room h2room4 = new Room();
            h2room4.capacity = "2/3";
            h2room4.dailyRate = 40;
            h2room4.type = "QB";

            aHotel2.listOfRooms.Add(h2room4);

            hotelList.Add(aHotel2);


            //Hotel 3
            Hotel aHotel3 = new Hotel();


            aHotel3.name = "Oldester Glory";
            aHotel3.address = "84920 w 8 st";
            aHotel3.id = "003";
            aHotel3.rating = "3";
            aHotel3.varfeatures.laundry = false;
            aHotel3.varfeatures.aircon = true;
            aHotel3.varfeatures.breakfast = true;
            aHotel3.varfeatures.shuttle = false;
            aHotel3.distances.beach = 5;
            aHotel3.distances.shopping = 1;
            aHotel3.distances.airport = 2;



            Room h3room1 = new Room();
            h3room1.capacity = "1/4";
            h3room1.dailyRate = 55;
            h3room1.type = "KB";

            aHotel3.listOfRooms.Add(h3room1);

            Room h3room2 = new Room();
            h3room2.capacity = "1/2";
            h3room2.dailyRate = 35;
            h3room2.type = "TB";

            aHotel3.listOfRooms.Add(h3room2);

            Room h3room3 = new Room();
            h3room3.capacity = "1/3";
            h3room3.dailyRate = 45;
            h3room3.type = "QB";

            aHotel3.listOfRooms.Add(h3room3);

            Room h3room4 = new Room();
            h3room4.capacity = "2/3";
            h3room4.dailyRate = 40;
            h3room4.type = "QB";

            aHotel3.listOfRooms.Add(h3room4);

            hotelList.Add(aHotel3);


            //Hotel 4
            Hotel aHotel4 = new Hotel();


            aHotel4.name = "Oldesterest Glory";
            aHotel4.address = "82430 w 90 st";
            aHotel4.id = "004";
            aHotel4.rating = "2.5";
            aHotel4.varfeatures.laundry = true;
            aHotel4.varfeatures.aircon = true;
            aHotel4.varfeatures.breakfast = true;
            aHotel4.varfeatures.shuttle = true;
            aHotel4.distances.beach = 4;
            aHotel4.distances.shopping = 3;
            aHotel4.distances.airport = 2;



            Room h4room1 = new Room();
            h4room1.capacity = "1/4";
            h4room1.dailyRate = 55;
            h4room1.type = "KB";

            aHotel4.listOfRooms.Add(h4room1);

            Room h4room2 = new Room();
            h4room2.capacity = "1/2";
            h4room2.dailyRate = 35;
            h4room2.type = "TB";

            aHotel4.listOfRooms.Add(h4room2);

            Room h4room3 = new Room();
            h4room3.capacity = "1/3";
            h4room3.dailyRate = 45;
            h4room3.type = "QB";

            aHotel4.listOfRooms.Add(h4room3);

            Room h4room4 = new Room();
            h4room4.capacity = "2/3";
            h4room4.dailyRate = 40;
            h4room4.type = "QB";

            aHotel4.listOfRooms.Add(h4room4);

            hotelList.Add(aHotel4);



            //Hotel 5
            Hotel aHotel5 = new Hotel();


            aHotel5.name = "Oldesteresting Glory";
            aHotel5.address = "11832 nw 12 st";
            aHotel5.id = "005";
            aHotel5.rating = "4.5";
            aHotel5.varfeatures.laundry = true;
            aHotel5.varfeatures.aircon = true;
            aHotel5.varfeatures.breakfast = false;
            aHotel5.varfeatures.shuttle = false;
            aHotel5.distances.beach = 4;
            aHotel5.distances.shopping = 3;
            aHotel5.distances.airport = 3;



            Room h5room1 = new Room();
            h5room1.capacity = "2/4";
            h5room1.dailyRate = 45;
            h5room1.type = "KB";

            aHotel5.listOfRooms.Add(h5room1);

            Room h5room2 = new Room();
            h5room2.capacity = "1/2";
            h5room2.dailyRate = 35;
            h5room2.type = "TB";

            aHotel5.listOfRooms.Add(h5room2);

            Room h5room3 = new Room();
            h5room3.capacity = "2/3";
            h5room3.dailyRate = 55;
            h5room3.type = "QB";

            aHotel5.listOfRooms.Add(h5room3);

            Room h5room4 = new Room();
            h5room4.capacity = "2/3";
            h5room4.dailyRate = 40;
            h5room4.type = "QB";

            aHotel5.listOfRooms.Add(h5room4);

            hotelList.Add(aHotel5);


            //Hotel 6
            Hotel aHotel6 = new Hotel();


            aHotel6.name = "Oldesteresting Glories";
            aHotel6.address = "11234 nw 14 st";
            aHotel6.id = "006";
            aHotel6.rating = "4";
            aHotel6.varfeatures.laundry = false;
            aHotel6.varfeatures.aircon = false;
            aHotel6.varfeatures.breakfast = false;
            aHotel6.varfeatures.shuttle = false;
            aHotel6.distances.beach = 4;
            aHotel6.distances.shopping = 3;
            aHotel6.distances.airport = 3;



            Room h6room1 = new Room();
            h6room1.capacity = "2/4";
            h6room1.dailyRate = 45;
            h6room1.type = "KB";

            aHotel6.listOfRooms.Add(h6room1);

            Room h6room2 = new Room();
            h6room2.capacity = "1/2";
            h6room2.dailyRate = 35;
            h6room2.type = "TB";

            aHotel6.listOfRooms.Add(h6room2);

            Room h6room3 = new Room();
            h6room3.capacity = "2/3";
            h6room3.dailyRate = 55;
            h6room3.type = "QB";

            aHotel6.listOfRooms.Add(h6room3);

            Room h6room4 = new Room();
            h6room4.capacity = "2/3";
            h6room4.dailyRate = 40;
            h6room4.type = "QB";

            aHotel6.listOfRooms.Add(h6room4);

            hotelList.Add(aHotel6);


            //Hotel 7
            Hotel aHotel7 = new Hotel();


            aHotel7.name = "Oldesteresting Gloriesest";
            aHotel7.address = "98274 nw 16 st";
            aHotel7.id = "007";
            aHotel7.rating = "4.5";
            aHotel7.varfeatures.laundry = true;
            aHotel7.varfeatures.aircon = false;
            aHotel7.varfeatures.breakfast = false;
            aHotel7.varfeatures.shuttle = false;
            aHotel7.distances.beach = 5;
            aHotel7.distances.shopping = 3;
            aHotel7.distances.airport = 4;



            Room h7room1 = new Room();
            h7room1.capacity = "2/4";
            h7room1.dailyRate = 45;
            h7room1.type = "KB";

            aHotel7.listOfRooms.Add(h7room1);

            Room h7room2 = new Room();
            h7room2.capacity = "1/2";
            h7room2.dailyRate = 35;
            h7room2.type = "TB";

            aHotel7.listOfRooms.Add(h7room2);

            Room h7room3 = new Room();
            h7room3.capacity = "2/3";
            h7room3.dailyRate = 55;
            h7room3.type = "QB";

            aHotel7.listOfRooms.Add(h7room3);

            Room h7room4 = new Room();
            h7room4.capacity = "2/3";
            h7room4.dailyRate = 40;
            h7room4.type = "QB";

            aHotel7.listOfRooms.Add(h7room4);

            hotelList.Add(aHotel7);



            //Hotel 8
            Hotel aHotel8 = new Hotel();


            aHotel8.name = "Oldesteresting Gloriesester";
            aHotel8.address = "11234 nw 14 st";
            aHotel8.id = "008";
            aHotel8.rating = "5";
            aHotel8.varfeatures.laundry = false;
            aHotel8.varfeatures.aircon = false;
            aHotel8.varfeatures.breakfast = true;
            aHotel8.varfeatures.shuttle = true;
            aHotel8.distances.beach = 7;
            aHotel8.distances.shopping = 9;
            aHotel8.distances.airport = 600;



            Room h8room1 = new Room();
            h8room1.capacity = "2/4";
            h8room1.dailyRate = 45;
            h8room1.type = "KB";

            aHotel8.listOfRooms.Add(h8room1);

            Room h8room2 = new Room();
            h8room2.capacity = "1/2";
            h8room2.dailyRate = 35;
            h8room2.type = "TB";

            aHotel8.listOfRooms.Add(h8room2);

            Room h8room3 = new Room();
            h8room3.capacity = "2/3";
            h8room3.dailyRate = 55;
            h8room3.type = "QB";

            aHotel8.listOfRooms.Add(h8room3);

            Room h8room4 = new Room();
            h8room4.capacity = "2/3";
            h8room4.dailyRate = 40;
            h8room4.type = "QB";

            aHotel8.listOfRooms.Add(h8room4);

            hotelList.Add(aHotel8);


            //Hotel 9
            Hotel aHotel9 = new Hotel();


            aHotel9.name = "Oldesteresting Gloriesesterest";
            aHotel9.address = "11234 nw 14 st";
            aHotel9.id = "009";
            aHotel9.rating = "4";
            aHotel9.varfeatures.laundry = true;
            aHotel9.varfeatures.aircon = true;
            aHotel9.varfeatures.breakfast = false;
            aHotel9.varfeatures.shuttle = false;
            aHotel9.distances.beach = 4;
            aHotel9.distances.shopping = 3;
            aHotel9.distances.airport = 3;



            Room h9room1 = new Room();
            h9room1.capacity = "2/4";
            h9room1.dailyRate = 45;
            h9room1.type = "KB";

            aHotel9.listOfRooms.Add(h9room1);

            Room h9room2 = new Room();
            h9room2.capacity = "1/2";
            h9room2.dailyRate = 35;
            h9room2.type = "TB";

            aHotel9.listOfRooms.Add(h9room2);

            Room h9room3 = new Room();
            h9room3.capacity = "2/3";
            h9room3.dailyRate = 55;
            h9room3.type = "QB";

            aHotel9.listOfRooms.Add(h9room3);

            Room h9room4 = new Room();
            h9room4.capacity = "2/3";
            h9room4.dailyRate = 40;
            h9room4.type = "QB";

            aHotel9.listOfRooms.Add(h9room4);

            hotelList.Add(aHotel9);



            //Hotel 10
            Hotel aHotel10 = new Hotel();


            aHotel10.name = "Oldesteresting Gloriesesteresters";
            aHotel10.address = "13370 sw 9 st";
            aHotel10.id = "010";
            aHotel10.rating = "3";
            aHotel10.varfeatures.laundry = true;
            aHotel10.varfeatures.aircon = true;
            aHotel10.varfeatures.breakfast = true;
            aHotel10.varfeatures.shuttle = true;
            aHotel10.distances.beach = 4;
            aHotel10.distances.shopping = 5;
            aHotel10.distances.airport = 6;



            Room h10room1 = new Room();
            h10room1.capacity = "2/4";
            h10room1.dailyRate = 45;
            h10room1.type = "KB";

            aHotel10.listOfRooms.Add(h10room1);

            Room h10room2 = new Room();
            h10room2.capacity = "1/2";
            h10room2.dailyRate = 35;
            h10room2.type = "TB";

            aHotel10.listOfRooms.Add(h10room2);

            Room h10room3 = new Room();
            h10room3.capacity = "2/3";
            h10room3.dailyRate = 55;
            h10room3.type = "QB";

            aHotel10.listOfRooms.Add(h10room3);

            Room h10room4 = new Room();
            h10room4.capacity = "2/3";
            h10room4.dailyRate = 40;
            h10room4.type = "QB";

            aHotel10.listOfRooms.Add(h10room4);

            hotelList.Add(aHotel10);


            StreamWriter writer = new StreamWriter("../../hotels.xml");
            XmlSerializer serializer = new XmlSerializer(hotelList.GetType());
            serializer.Serialize(writer, hotelList);




            return true;
        }







    }

    public class Hotel
    {
        

        public string name { get; set; }
        public string address { get; set; }
        public string id { get; set; }
        public string rating { get; set; }
        public Features varfeatures { get; set; }
        public Distances distances { get; set; }
        public List<Room> listOfRooms { get; set; }


        public Hotel()
        {
            this.name = name;
            this.address = address;
            this.id = id;
            this.rating = rating;
            this.varfeatures = new Features();
            this.distances = new Distances();
            this.listOfRooms = new List<Room>();

        }

        public Hotel(string name, string address, string id, string rating)
        {

            this.name = name;
            this.address = address;
            this.id = id;
            this.rating = rating;
            this.varfeatures = new Features();
            this.distances = new Distances();
            this.listOfRooms = new List<Room>();


        }
    }

    public class HotelListItem
    {

        public string ID { get; set; }
        public string name { get; set; }
        public string rating { get; set; }

        public List<Room> RoomTypes { get; set; }



        public HotelListItem()
        {
            this.ID = ID;
            this.name = name;
            this.rating = rating;
            this.RoomTypes = new List<Room>();

        }

    }


    public class Distances
    {

        public int beach { get; set; }
        public int shopping { get; set; }
        public int airport { get; set; }


        public Distances() { }

        public Distances(int beach, int shopping, int airport)
        {

            this.beach = beach;
            this.shopping = shopping;
            this.airport = airport;

        }
    }



    public class Features
    {

        public bool laundry { get; set; }
        public bool aircon { get; set; }
        public bool breakfast { get; set; }
        public bool shuttle { get; set; }


        public Features() { }


        public Features(bool laundry, bool aircon, bool breakfast, bool shuttle)
        {

            this.laundry = laundry;
            this.aircon = aircon;
            this.breakfast = breakfast;
            this.shuttle = shuttle;


        }
    }


    public class RoomDeSerializer
    {

        public static List<Hotel> hotellist = new List<Hotel>();

        public bool deSerialzeNow()
        {



            XmlSerializer ser = new XmlSerializer(typeof(List<Hotel>));

            using (XmlReader reader = XmlReader.Create(@"..\..\Hotels.xml"))
            {
                hotellist = (List<Hotel>)ser.Deserialize(reader);
            }

            return true;


        }





    }

    public class ShowHotels
    {

        public bool hotelShower()
        {




           List<HotelListItem> itemList = new List<HotelListItem>(10);
            
            foreach (Hotel H in RoomDeSerializer.hotellist)
            {
                HotelListItem AnotherHotel = new HotelListItem();

                AnotherHotel.ID = H.id;
                AnotherHotel.name = H.name;
                AnotherHotel.rating = H.rating;

                AnotherHotel.RoomTypes = H.listOfRooms;

                List<Room> list = new List<Room>();
                Room Y = new Room();

                foreach (Room R in AnotherHotel.RoomTypes)
                {
                    Y = R;
                    if (R.type.Equals("QB"))
                    {
                        Y.type = roomTypes.QueenBed;
                    }

                    else if (R.type.Equals("TB"))
                    {
                        Y.type = roomTypes.TwinBed;
                    }

                    else if (R.type.Equals("KB"))
                    {
                        Y.type = roomTypes.KingBed;
                    }

                    list.Add(Y); 
                }

                AnotherHotel.RoomTypes = list;

                itemList.Add(AnotherHotel);

            }

            StreamWriter writer = new StreamWriter("../../newhotels.xml");
            XmlSerializer serializer = new XmlSerializer(itemList.GetType());
            serializer.Serialize(writer, itemList);
            writer.Close();
            return true;

        }



    }






    public class doThatHTML
    {

        public bool doTheHTML()
        {

            var xslMagic = new XslCompiledTransform();
            xslMagic.Load("../../_hotels.xslt");
            xslMagic.Transform("../../newhotels.xml", "../../horrayforhtml.html");


            return true;
        }

    }

    public class roomTypes
    {

        public static string QueenBed = "Queen bed";
        public static string KingBed = "Queen bed";
        public static string TwinBed = "Twin bed";


    }



}


