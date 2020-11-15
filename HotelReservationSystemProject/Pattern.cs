using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HotelReservationSystemProject
{
    public class Pattern
    {
        /// <summary>
        /// Validates the date.
        /// </summary>
        /// <param name="checkFromDate">The check from date.</param>
        /// <exception cref="HotelReservationSystemProject.HotelCustomException">Invalid Date Format! Need to Valid Dates</exception>
        public void ValidateDate(string checkDateFormat)
        {
            try
            {
                /// pattern to validate date
                string pattern = "^[0-9]{1,2}[-/=]{1}[0-9]{1,2}[-/=]{1}[0-9]{4}$";
                if (Regex.Match(checkDateFormat, pattern).Success)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    throw new HotelCustomException("Invalid Date Format! Need to Valid Dates", HotelCustomException.ExceptionType.VALID_DATE_FORMAT);
                }
            }
            catch (HotelCustomException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
