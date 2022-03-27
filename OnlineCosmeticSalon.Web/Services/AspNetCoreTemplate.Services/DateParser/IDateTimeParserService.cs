using System;

namespace AspNetCoreTemplate.Services.DateParser
{
    public interface IDateTimeParserService
    {
        DateTime ConvertStrings(string date, string time);
    }
}
