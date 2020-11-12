﻿using System;
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
        //public int weekEndRegularRates;

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="weekDayRegularRates">The week day regular rates.</param>
        /// <param name="weekEndRegularRates">The week end regular rates.</param>
        public Hotel(string hotelName, int weekDayRegularRates)
        {
            this.hotelName = hotelName;
            this.weekDayRegularRates = weekDayRegularRates;
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
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public string ToString()
        {
            return "hotelName : " + hotelName + " || " + "WeekDayRegularRates : " + weekDayRegularRates;
        }
    }
}
