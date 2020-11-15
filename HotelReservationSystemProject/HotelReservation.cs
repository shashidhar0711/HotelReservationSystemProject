using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystemProject
{
    public class HotelReservation
    {
        // <summary>
        /// defining hotel list and dictionary
        /// </summary>
        List<Hotel> hotelList = new List<Hotel>();
        Dictionary<string, int> sortingCost = new Dictionary<string, int>();
        List<Hotel> rateList = new List<Hotel>();
        List<Hotel> minimumCostList = new List<Hotel>();
        List<Hotel> rewardsList = new List<Hotel>();

        //public int totalCost { get; private set; }

        /// <summary>
        /// Adds the hotel.
        /// </summary>
        public void AddHotel(string customerType)
        {
            try
            {
                if (customerType.Equals("regular"))
                {
                    /// Adding hotel details in to hotel list
                    hotelList.Add(new Hotel("LakeWood", 110, 90, 3));
                    hotelList.Add(new Hotel("BridgeWood", 150, 50, 4));
                    hotelList.Add(new Hotel("RidgeWood", 220, 150, 5));

                    /// Iterating through list and prints hotel regular rates
                    Console.WriteLine("------------------- Hotel Regular Rates ----------------------------");
                    foreach (var hotels in hotelList)
                    {
                        Console.WriteLine("hotelName : " + hotels.hotelName + " || " + "WeekDayRegularRates : " + hotels.weekDayRegularRates + " || " + "WeekEndRegularRates : " + hotels.weekEndRegularRates);
                    }
                }
                else if (customerType.Equals("rewards"))
                {
                    /// Adding hotel details in to hotel rewards list
                    rewardsList.Add(new Hotel("LakeWood", 80, 80));
                    rewardsList.Add(new Hotel("BridgeWood", 110, 50));
                    rewardsList.Add(new Hotel("RidgeWood", 100, 40));

                    /// Iterating through list and prints hotel rewards rates
                    Console.WriteLine("--------------------Hotel Rewards Rates---------------------------");
                    foreach (var hotels in rewardsList)
                    {
                        Console.WriteLine("hotelName : " + hotels.hotelName + " || " + "WeekDayRewardsRates : " + hotels.weekDayRewardsRates + " || " + "WeekEndRewardsRates : " + hotels.weekEndRewardsRates);
                    }
                }
                else
                {
                    throw new HotelCustomException("Invalid Customer Type! Need to give valid type", HotelCustomException.ExceptionType.INVALID_CUSTOMER);
                }
            }
            catch (HotelCustomException exception)
            {
                Console.WriteLine(exception.Message);
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
            try
            {
                if (endingDate > startingDate)
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
                    }
                    Console.WriteLine("-----------------------------------------------");
                    /// Iterating through dictionary to find cheapest cost of hotel price
                    foreach (KeyValuePair<string, int> sort in sortingCost.OrderBy(key => key.Value))
                    {
                        Console.WriteLine("Hotel Name : {0} || Total Price : {1}", sort.Key, sort.Value);
                        break;
                    }
                }
                else
                {
                    throw new HotelCustomException("Invalid date Type! Need to give valid date", HotelCustomException.ExceptionType.VALID_DATE_FORMAT);
                }
            }
            catch (HotelCustomException exception)
            {
                Console.WriteLine(exception.Message);
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
            foreach (var hotels in rateList.OrderBy(s => s.totalCost).ToList())
            {
                if (hotels.totalCost == rateList.Min(s => s.totalCost))
                {
                    minimumCostList.Add(hotels);
                }
            }
            /// Iterating through list and finding minimum cost
            foreach (var hotels in minimumCostList)
            {
                if (hotels.rating == minimumCostList.Max(s => s.rating))
                {
                    Console.WriteLine("------------------Cheapest Cost Hotel-----------------------------");
                    Console.WriteLine("Hotel Name : " + hotels.hotelName + "\nTotal Cost : " + hotels.totalCost + "\nRatings : " + hotels.rating);
                }
            }
            /// Itetating through list and finding maximum cost
            foreach (var hotels in rateList)
            {
                if (hotels.rating == rateList.Max(s => s.rating))
                {
                    Console.WriteLine("------------------Maximum Cost Hotel-----------------------------");
                    Console.WriteLine("Hotel Name : " + hotels.hotelName + "\nTotal Cost : " + hotels.totalCost + "\nRatings : " + hotels.rating);
                }
            }
        }
    }
}
