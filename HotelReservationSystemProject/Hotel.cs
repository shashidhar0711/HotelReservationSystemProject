using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProject
{
    public class Hotel
    {
        /// <summary>
        /// Variables
        /// </summary>
        public string hotelName;
        public int weekDayRegularRates;
        public int weekEndRegularRates;
        public int rating;

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="weekDayRegularRates">The week day regular rates.</param>
        /// <param name="weekEndRegularRates">The week end regular rates.</param>
        /// <param name="rating">The rating.</param>
        public Hotel(string hotelName, int weekDayRegularRates, int weekEndRegularRates, int rating)
        {
            this.hotelName = hotelName;
            this.weekDayRegularRates = weekDayRegularRates;
            this.weekEndRegularRates = weekEndRegularRates;
            this.rating = rating;
        }

        /// <summary>
        /// Sets the name of the hotel.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        public void setHotelName(string hotelName)
        {
            this.hotelName = hotelName;
        }

        /// <summary>
        /// Sets the week day regular rates.
        /// </summary>
        /// <param name="weekDayRegularRates">The week day regular rates.</param>
        public void setWeekDayRegularRates(int weekDayRegularRates)
        {
            this.weekDayRegularRates = weekDayRegularRates;
        }

        /// <summary>
        /// Sets the week end regular rates.
        /// </summary>
        /// <param name="weekEndRegularRates">The week end regular rates.</param>
        public void SetWeekEndRegularRates(int weekEndRegularRates)
        {
            this.weekEndRegularRates = weekEndRegularRates;
        }

        /// <summary>
        /// Sets the rating.
        /// </summary>
        /// <param name="rating">The rating.</param>
        public void SetRating(int rating)
        {
            this.rating = rating;
        }

        /// <summary>
        /// Gets the name of the hotel.
        /// </summary>
        /// <returns></returns>
        public string GetHotelName()
        {
            return hotelName;
        }

        /// <summary>
        /// Gets the week day regular rates.
        /// </summary>
        /// <returns></returns>
        public int GetWeekDayRegularRates()
        {
            return weekDayRegularRates;
        }

        /// <summary>
        /// Gets the week end regular rates.
        /// </summary>
        /// <returns></returns>
        public int GetWeekEndRegularRates()
        {
            return weekEndRegularRates;
        }

        /// <summary>
        /// Gets the rating.
        /// </summary>
        /// <returns></returns>
        public int GetRating()
        {
            return rating;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        override
        public string ToString()
        {
            return "hotelName : " + hotelName + " || " + "WeekDayRegularRates : " + weekDayRegularRates + " || " + "WeekEndRegularRates : " + weekEndRegularRates + " || " + "HotelRating : " + rating;
        }
    }
}
