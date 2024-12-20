using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Models
{
    internal class Reservation
    {
        private Room _room { get; }
        private DateTime _startReservation;
        private DateTime _endReservation;

        public Reservation(Room room, DateTime startReservation, DateTime endReservation)
        {
            _room = room;
            _startReservation = startReservation;
            _endReservation = endReservation;
        }

        internal bool CheckOccupied(Reservation roomReservation)
        {
            if(_room.CompareRooms(roomReservation._room))
                return false;

            // Check reservation dates logic
            return roomReservation._startReservation < _endReservation &&
                   roomReservation._endReservation > _startReservation;
        }
    }
}
