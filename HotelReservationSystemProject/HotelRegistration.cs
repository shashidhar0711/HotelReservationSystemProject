using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProject
{
    public class HotelRegistration
    {
        /// <summary>
        /// defining hotel list and dictionary
        /// </summary>
        List<Hotel> hotelList = new List<Hotel>();
        SortedDictionary<int, string> sortingCost = new SortedDictionary<int, string>();

        /// <summary>
        /// Adds the hotel.
        /// </summary>
        public void AddHotel()
        {
            /// Adding hotel details in to hotel list
            hotelList.Add(new Hotel("LakeWood", 110, 90));
            hotelList.Add(new Hotel("BridgeWood", 150, 50));
            hotelList.Add(new Hotel("RidgeWood", 220, 150));

            /// Iterating through list
            foreach (var hotels in hotelList)
            {
                Console.WriteLine(hotels.ToString());
            }
        }

        /// <summary>
        /// Calculatings the hotel prices.
        /// </summary>
        /// <param name="startingDate">The starting date.</param>
        /// <param name="endingDate">The ending date.</param>
        public void calculatingHotelPrices(DateTime startingDate, DateTime endingDate)
        {
            int totalCost = 0;
            TimeSpan DateDifference = endingDate.Subtract(startingDate);
            foreach (var hotels in hotelList)
            {
                /// By looping untill Condtion ends
                for (int i = 0; i < DateDifference.TotalDays; i++)
                {
                    totalCost = totalCost + hotels.weekDayRegularRates;
                }
                Console.WriteLine("Hotel Name : " + hotels.hotelName, "Total Price : " + totalCost);
                /// Adding key and values in to dictionary
                sortingCost.Add(totalCost, hotels.hotelName);
            }
        }
        /// <summary>
        /// cheapestHotel method is used to find the cheapest hotel among the present hotels.
        /// </summary>
        /// <param name="checkInDate"></param>
        /// <param name="checkOutDate"></param>
        public void FindingCheapestHotel(DateTime startingDate, DateTime endingDate)
        {
            calculatingHotelPrices(startingDate, endingDate);
            foreach (var hotelPrice in sortingCost)
            {
                /// In sorted dictionary should get cheapest
                Console.WriteLine("Cheapest Hotel Name : " + hotelPrice.Value, "Cheapest Cost : " + hotelPrice.Key);
                break;
            }
        }
    }
}
