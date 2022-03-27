using AspNetCoreTemplate.Common;
using System;
using System.Globalization;

namespace AspNetCoreTemplate.Services.DateParser
{
    public class DateTimeParserService : IDateTimeParserService
    {
        public DateTime ConvertStrings(string date, string time)
        {
            string dateString = date + " " + time;
            string format = GlobalConstants.DateTimeFormats.DateTimeFormat;

            DateTime dateTime = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

            return dateTime;
        }
    }
}
