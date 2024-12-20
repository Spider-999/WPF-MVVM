using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM.Exceptions;

namespace WPF_MVVM.Models
{
    // Holds all of the reservations
    internal class ReservationBook
    {
        // Map rooms to reservations 
        private readonly List<Reservation> _roomReservations;

        public ReservationBook() 
        {
            _roomReservations = new List<Reservation>();
        }

        public void AddReservation(Reservation reservation)
        {
            // Check if the reservation already exists
            foreach (var roomReservation in _roomReservations)
            {
                if (roomReservation.CheckOccupied(reservation))
                    throw new ReservationException(reservation, roomReservation);
            }

            _roomReservations.Add(reservation);
        }

        public void ViewReservations()
        {
            foreach(var roomReservation in _roomReservations)
                Console.WriteLine(roomReservation);
        }
    }
}
