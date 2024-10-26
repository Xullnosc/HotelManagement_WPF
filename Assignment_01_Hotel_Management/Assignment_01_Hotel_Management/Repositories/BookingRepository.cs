using Assignment_01_Hotel_Management.Entities;


namespace Assignment_01_Hotel_Management.Repositories;

public class BookingRepository
{
    private static List<Booking> _bookings = new List<Booking>();

    public static List<Booking> GetAllBookings()
    {
        return _bookings;
    }

    public static void AddBooking(Booking booking)
    {
        var room = RoomRepository.GetAllRooms().FirstOrDefault(room => room.RoomID == booking.RoomID);
        booking.Room = room;
        _bookings.Add(booking);
    }

    public static int GetNextBookingID()
    {
        return _bookings.Count > 0 ? _bookings.Max(b => b.BookingID) + 1 : 1;
    }
}

