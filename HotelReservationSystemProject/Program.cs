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
            /// printing welcome message
            /// creating a references of object class
            Console.WriteLine("Welocme to Hotel Registration");
            HotelReservation hotelRegistration = new HotelReservation();
            Pattern pattern = new Pattern();

            /// Taking the customer type from console
            Console.WriteLine("Enter the type of Customer(Regular/Rewards)");
            string customerType = Console.ReadLine();
            hotelRegistration.AddHotel(customerType.ToLower());

            /// Taking starting and ending date from console and,
            /// Validating date format using Regular expression
            Console.WriteLine("Enter the checkDate from start date ddmmyyyy");
            string checkFromDate = Console.ReadLine();
            pattern.ValidateDate(checkFromDate);

            Console.WriteLine("Enter the checkDate to date ddmmyyyy");
            string checkToDate = Console.ReadLine();
            pattern.ValidateDate(checkToDate);

            Console.WriteLine("Enter Check-In day");
            string checkInDay = Console.ReadLine();

            DateTime startingDate = DateTime.Parse(checkFromDate);
            DateTime endingDate = DateTime.Parse(checkToDate);
            hotelRegistration.FindCheapestHotelWithRatings(startingDate, endingDate, checkInDay.ToLower());
        }
    }
}
