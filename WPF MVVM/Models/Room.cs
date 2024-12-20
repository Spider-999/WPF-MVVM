using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Models
{
    internal class Room
    {
        private int _floorNumber;
        private int _roomNumber;


        public Room(int floorNumber, int roomNumber)
        {
            _floorNumber = floorNumber;
            _roomNumber = roomNumber;
        }

        public bool CompareRooms(Room reservationRoom)
        {
            // If the reservation room has the same number and the same floor
            // as another room then we cant make the reservation for that room
            if (reservationRoom._floorNumber == _floorNumber &&
               reservationRoom._roomNumber == _roomNumber)
                return false;

            return true;
        }
    }
}
