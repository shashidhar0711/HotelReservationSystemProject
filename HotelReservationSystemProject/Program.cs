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
            Console.WriteLine("Hello World!");
            HotelRegistration hotelRegistration = new HotelRegistration();
            hotelRegistration.AddHotel();

            /// Taking starting and ending date from console and,
            /// to find difference and cheapest hotel
            Console.WriteLine("Enter the checkDate from start date ddmmyyyy");
            string checkFromDate = Console.ReadLine();
            Console.WriteLine("Enter the checkDate to date ddmmyyyy");
            string checkToDate = Console.ReadLine();
            DateTime startingDate = DateTime.Parse(checkFromDate);
            DateTime endingDate = DateTime.Parse(checkToDate);

            /// Calling a method to find cheapest cost of hotel
            hotelRegistration.FindingCheapestHotel(startingDate, endingDate);
        }
    }
}
