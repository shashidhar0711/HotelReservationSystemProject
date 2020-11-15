using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystemProject
{
    public class HotelReservation
    {
        /// <summary>
        /// defining hotel list and dictionary
        /// </summary>
        List<Hotel> hotelList = new List<Hotel>();
        Dictionary<string, int> sortingCost = new Dictionary<string, int>();

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
        /// <param name="checkInDay">The check in day.</param>
        public void calculatingHotelPrices(DateTime startingDate, DateTime endingDate, string checkInDay)
        {
            int totalCost = 0;
            TimeSpan dateDifference = endingDate.Subtract(startingDate);
            foreach (var hotels in hotelList)
            {
                /// By looping untill Condtion ends
                for (int i = 0; i <= dateDifference.TotalDays; i++)
                {
                    /// if given day is week end then, calculate the week end rates
                    /// if not calculates week day rates
                    if (checkInDay.Equals("saturday") || checkInDay.Equals("sunday"))
                    {
                        totalCost = totalCost + hotels.weekEndRegularRates;
                    }
                    else
                    {
                        totalCost = totalCost + hotels.weekDayRegularRates;
                    }
                }
                Console.WriteLine("Hotel Name : " + hotels.hotelName + " || " + "Total Price : " + totalCost);
                /// Adding key and values in to dictionary
                sortingCost.Add(hotels.hotelName, totalCost);
            }
        }

        /// <summary>
        /// Findings the cheapest hotel.
        /// </summary>
        /// <param name="startingDate">The starting date.</param>
        /// <param name="endingDate">The ending date.</param>
        /// <param name="checkInDay">The check in day.</param>
        public void FindingCheapestHotel(DateTime startingDate, DateTime endingDate, string checkInDay)
        {
            /// Callind method to check and compute hotel week day and week End price 
            calculatingHotelPrices(startingDate, endingDate, checkInDay);
            Console.WriteLine("-----------------------------------------------");
            /// Iterating through dictionary to find cheapest cost of hotel price
            foreach (KeyValuePair<string, int> sort in sortingCost.OrderBy(key => key.Value))
            {
                Console.WriteLine("Hotel Name : {0} || Total Price : {1}", sort.Key, sort.Value);
                break;
            }
        }
    }
}
