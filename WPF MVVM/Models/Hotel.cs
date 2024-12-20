using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Models
{
    internal class Hotel
    {
        private readonly ReservationBook _reservationBook;
        private string _name {  get; set; }

        public Hotel(string name)
        {
            _reservationBook = new ReservationBook();
            _name = name;
        }

        public void AddHotelReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }

        public void ViewHotelReservations()
        {
            _reservationBook.ViewReservations();
        }
    }
}
