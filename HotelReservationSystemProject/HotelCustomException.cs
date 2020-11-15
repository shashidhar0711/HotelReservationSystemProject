using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProject
{
    public class HotelCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_CUSTOMER, VALID_DATE_FORMAT
        }

        /// <summary>
        /// The type
        /// </summary>
        public ExceptionType type;

        /// <summary>
        /// Initializes a new instance of the <see cref="HotelCustomException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="type">The type.</param>
        public HotelCustomException(string message, ExceptionType type) : base(message)
        {
            this.type = type;
        }
    }
}
