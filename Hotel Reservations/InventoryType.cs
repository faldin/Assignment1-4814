using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations
{ 


public class InventoryType

{

    public string Date { get; set; }
    public int HotelId { get; set; }
    public string RoomType { get; set; }
    public int Quantity { get; set; }

        

    public InventoryType() { }

    public InventoryType(string Date, int HotelId, string RoomType, int Quantity)
    {

        this.Date = Date;
        this.HotelId = HotelId;
        this.RoomType = RoomType;
        this.Quantity = Quantity;
    }
}
}
