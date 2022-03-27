namespace AspNetCoreTemplate.Common
{
    public static class GlobalConstants
    {
        public const string AdministratorRoleName = "Administrator";

        public const string SystemName = "Online Cosmetic Salon";

        public const string CloudName = "Cosmetic-salon";
        public static class DataValidations
        {
            public const int TitleMaxLength = 60;

            public const int TitleMinLength = 5;

            public const int ContentMaxLength = 3500;

            public const int ContentMinLength = 700;

            public const int NameMaxLength = 40;

            public const int NameMinLength = 2;

            public const int DescriptionMaxLength = 700;

            public const int DescriptionMinLength = 50;

            public const int AddressMaxLength = 100;

            public const int AddressMinLength = 5;
        }
        public static class DateTimeFormats
        {
            public const string DateFormat = "dd-MM-yyyy";

            public const string TimeFormat = "h:mmtt";

            public const string DateTimeFormat = "dd-MM-yyyy h:mmtt";
        }
        public static class SeededDataCounts
        {
            // public const int BlogPosts = 4;

            public const int Categories = 6;

            //public const int Services = 55;

            // public const int Cities = 2;

            //public const int Salons = 18;

            //public const int Appointments = 54;
        }
    }
}
