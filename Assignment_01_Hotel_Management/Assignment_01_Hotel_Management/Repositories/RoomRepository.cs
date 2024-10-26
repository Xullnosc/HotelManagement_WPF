using Assignment_01_Hotel_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_Hotel_Management.Repositories;

public class RoomRepository
{
    private static List<Room> _rooms = new List<Room>()
    {
        new Room {RoomID = 0, RoomNumber = "101" ,RoomDescription = "Have bathroom", RoomMaxCapacity=3, RoomPricePerDate = 100000, 
            RoomStatus=1, RoomTypeID=1, RoomType = new RoomType { RoomTypeID = 1, RoomTypeName = "Single" } },
         new Room {RoomID = 1, RoomNumber = "102" ,RoomDescription = "Have bancony", RoomMaxCapacity=2, RoomPricePerDate = 200000,
            RoomStatus=1, RoomTypeID=2, RoomType = new RoomType { RoomTypeID = 2, RoomTypeName = "Double" } },
         new Room {RoomID = 2, RoomNumber = "201" ,RoomDescription = "Have netflix", RoomMaxCapacity=4, RoomPricePerDate = 400000,
            RoomStatus=1, RoomTypeID=3, RoomType = new RoomType { RoomTypeID = 3, RoomTypeName = "Suite" } }
    };

    private static List<RoomType> _roomTypes = new List<RoomType>
    {
        new RoomType { RoomTypeID = 1, RoomTypeName = "Single" },
        new RoomType { RoomTypeID = 2, RoomTypeName = "Double" },
        new RoomType { RoomTypeID = 3, RoomTypeName = "Suite" }
    }; 
    public static List<Room> GetAllRooms() => _rooms;

    public static void AddRoom(Room room)
    {
        var lastIndex = _rooms.Count - 1;
        room.RoomID = lastIndex + 1;

        var rt = _roomTypes.FirstOrDefault(x => x.RoomTypeID == room.RoomTypeID);
        if (rt != null)
        {
            room.RoomType = rt;
        }
        _rooms.Add(room);
    }

    public static void UpdateRoom(Room room)
    {
        var existingRoom = _rooms.FirstOrDefault(r => r.RoomID == room.RoomID);
        if (existingRoom != null)
        {
            existingRoom.RoomNumber = room.RoomNumber;
            existingRoom.RoomDescription = room.RoomDescription;
            existingRoom.RoomMaxCapacity = room.RoomMaxCapacity;
            existingRoom.RoomPricePerDate = room.RoomPricePerDate;
            existingRoom.RoomTypeID = room.RoomTypeID;

            var rt = _roomTypes.FirstOrDefault(x => x.RoomTypeID == room.RoomTypeID);
            if (rt != null)
            {
                existingRoom.RoomType = rt;
            }
        }
    }

    public static void DeleteRoom(int roomId)
    {
        var roomToDelete = _rooms.FirstOrDefault(r => r.RoomID == roomId);
        if (roomToDelete != null)
        {
            _rooms.Remove(roomToDelete);
        }
    }

    public static Room GetRoomById(int roomId)
    {
        return _rooms.FirstOrDefault(r => r.RoomID == roomId);
    }

    public static List<Room> SearchRooms(string searchText)
    {
        return _rooms.Where(r => r.RoomNumber.Contains(searchText) || r.RoomDescription.Contains(searchText)).ToList();
    }

    // Get all room types
    public static List<RoomType> GetRoomTypes()
    {
        return _roomTypes;
    }
}

