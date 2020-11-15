using System;
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
        List<Hotel> rateList = new List<Hotel>();
        List<Hotel> minimumCostList = new List<Hotel>();

        public int totalCost { get; private set; }

        /// <summary>
        /// Adds the hotel.
        /// </summary>
        public void AddHotel()
        {
            /// Adding hotel details in to hotel list
            hotelList.Add(new Hotel("LakeWood", 110, 90, 3));
            hotelList.Add(new Hotel("BridgeWood", 150, 50, 4));
            hotelList.Add(new Hotel("RidgeWood", 220, 150, 5));

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
        public void FindingCheapestHotel(DateTime startingDate, DateTime endingDate, string checkInDay)
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
                rateList.Add(new Hotel(totalCost, hotels.hotelName, hotels.rating));

                /// Calling method to check and compute hotel week day and week End price 
                Console.WriteLine("-----------------------------------------------");
                /// Iterating through dictionary to find cheapest cost of hotel price
                foreach (KeyValuePair<string, int> sort in sortingCost.OrderBy(key => key.Value))
                {
                    Console.WriteLine("Hotel Name : {0} || Total Price : {1}", sort.Key, sort.Value);
                    break;
                }
            }
        }

        /// <summary>
        /// Finds the cheapest hotel with ratings.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        /// <param name="checkInDay">The check in day.</param>
        public void FindCheapestHotelWithRatings(DateTime checkInDate, DateTime checkOutDate, string checkInDay)
        {
            FindingCheapestHotel(checkInDate, checkOutDate, checkInDay);

            /// Iterating rating list to find minimum cost and, adds in minimumCostList
            foreach(var hotels in rateList.OrderBy(s => s.totalCost).ToList())
            {
                if (hotels.totalCost == rateList.Min(s => s.totalCost))
                {
                    minimumCostList.Add(hotels);
                }
            }
            foreach (var hotels in minimumCostList)
            {
                if (hotels.rating == minimumCostList.Max(s => s.rating))
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Hotel Name : " + hotels.hotelName + "\nTotal Cost : " + hotels.totalCost + "\nRatings : " + hotels.rating);
                }
            }
        }
    }
}
