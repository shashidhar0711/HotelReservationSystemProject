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
            hotelRegistration.AddHotel();

            /// Taking starting and ending date from console and,
            /// to find difference and cheapest hotel
            Console.WriteLine("Enter the checkDate from start date ddmmyyyy");
            string checkFromDate = Console.ReadLine();
            Console.WriteLine("Enter the checkDate to date ddmmyyyy");
            string checkToDate = Console.ReadLine();
            Console.WriteLine("Enter Check-In day");
            string checkDay = Console.ReadLine();
            /// Converting in to lower case
            string checkInDay = checkDay.ToLower();
            DateTime startingDate = DateTime.Parse(checkFromDate);
            DateTime endingDate = DateTime.Parse(checkToDate);
            hotelRegistration.FindingCheapestHotel(startingDate, endingDate, checkInDay);
        }
    }
}
