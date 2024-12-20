using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM.Models;

namespace WPF_MVVM.Exceptions
{
    internal class ReservationException : Exception
    {
        private readonly Reservation _existingReservation;
        private readonly Reservation _newReservation;

        public ReservationException(Reservation existingReservation, Reservation newReservation) 
        { 
            _existingReservation = existingReservation;
            _newReservation = newReservation;
        }

        public ReservationException(string? message, Reservation existingReservation, Reservation newReservation) : base(message)
        {
            _existingReservation = existingReservation;
            _newReservation = newReservation;
        }
    }
}
