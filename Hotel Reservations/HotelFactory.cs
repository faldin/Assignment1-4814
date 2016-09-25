﻿using System;
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


            StreamWriter writer = new StreamWriter("../../hotels.xml");
            XmlSerializer serializer = new XmlSerializer(hotelList.GetType());
            serializer.Serialize(writer, hotelList);




            return true;
        }







    }
}
