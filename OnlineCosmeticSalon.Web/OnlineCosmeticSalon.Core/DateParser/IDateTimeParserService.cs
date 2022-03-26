namespace OnlineCosmeticSalon.Core.DateParser
{
    public interface IDateTimeParserService
    {
        DateTime ConvertStrings(string date, string time);
    }
}
