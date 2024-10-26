﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_Hotel_Management.Entities;

public class Booking
{
    public int BookingID { get; set; }
    public int CustomerID { get; set; }

    public int RoomID { get; set; }
    public Room? Room { get; set; }

    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public string? BookingStatus { get; set; }

    public decimal TotalPrice { get; set; }
}
