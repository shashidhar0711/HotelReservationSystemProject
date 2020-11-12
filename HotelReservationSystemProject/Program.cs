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
            Console.WriteLine("Welcome to Hotel Reservation System");
            /// An object is created for hotel class 
            /// Invoking during object creation
            HotelReservation hotelOne = new HotelReservation("LakeWood", 110);
            HotelReservation hotelTwo = new HotelReservation("BridgeWood", 160);
            HotelReservation hotelThree = new HotelReservation("RidgeWood", 220);

            /// printing hotel names and regular rates
            Console.WriteLine(hotelOne.ToString());
            Console.WriteLine(hotelTwo.ToString());
            Console.WriteLine(hotelThree.ToString());
        }    
    }
}
