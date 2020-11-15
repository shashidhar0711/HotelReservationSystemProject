using System;

namespace HotelReservationSystemProject
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// Adding hotel details and ratings
            Console.WriteLine("Welocme to Hotel Registration");
            HotelReservation hotelRegistration = new HotelReservation();
            hotelRegistration.AddHotel();
        }
    }
}
