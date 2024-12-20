using System.Configuration;
using System.Data;
using System.Windows;
using WPF_MVVM.Models;

namespace WPF_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("new hotel");
            hotel.AddHotelReservation(new Reservation
                (new Room(1,1), 
                new DateTime(2025, 1, 25), 
                new DateTime(2025, 1, 28))
                );
            hotel.ViewHotelReservations();
            base.OnStartup(e);
        }
    }

}
