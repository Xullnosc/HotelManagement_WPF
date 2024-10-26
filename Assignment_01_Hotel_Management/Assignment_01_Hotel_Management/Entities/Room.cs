using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_Hotel_Management.Entities;

public class Room
{
    public int RoomID { get; set; }
    public string RoomNumber { get; set; }
    public string RoomDescription { get; set; }
    public int RoomMaxCapacity { get; set; }
    public int RoomStatus { get; set; } // 1 = Active, 2 = Deleted
    public decimal RoomPricePerDate { get; set; }
    public int RoomTypeID { get; set; }
    public RoomType RoomType { get; set; }
}
