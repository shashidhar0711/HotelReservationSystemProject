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
            Console.WriteLine("Welocme to Hotel Registration");
            HotelReservation hotelRegistration = new HotelReservation();
            Console.WriteLine("Enter the type of Customer(Regular/Rewards)");
            string customerType = Console.ReadLine();
            hotelRegistration.AddHotel(customerType.ToLower());

            /// Taking starting and ending date from console and,
            /// to find difference and cheapest hotel
            Console.WriteLine("Enter the checkDate from start date ddmmyyyy");
            string checkFromDate = Console.ReadLine();
            Console.WriteLine("Enter the checkDate to date ddmmyyyy");
            string checkToDate = Console.ReadLine();
            Console.WriteLine("Enter Check-In day");
            string checkInDay = Console.ReadLine();
            DateTime startingDate = DateTime.Parse(checkFromDate);
            DateTime endingDate = DateTime.Parse(checkToDate);
            hotelRegistration.FindCheapestHotelWithRatings(startingDate, endingDate, checkInDay.ToLower());
        }
    }
}
