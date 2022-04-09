namespace AspNetCoreTemplate.Common
{
    public static class GlobalConstants
    {
        public const string AdministratorRoleName = "Administrator";

        public const string ManagerRoleName = "Manager";

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
        public static class AccountsSeeding
        {
            public const string Password = "123456789";

            public const string AdministratorEmail = "mirakis97@administrator.com";

            public const string ManagerEmail = "vasilev97@manager.com";

            public const string UserEmail = "user@user.com";
        }
        public static class ErrorMessages
        {
            public const string Title = "Title must be between 5 and 60 characters.";

            public const string Content = "Content must be between 700 and 3500 characters.";

            public const string Author = "Author name must be between 2 and 40 characters.";

            public const string Name = "Name must be between 2 and 40 characters.";

            public const string Description = "Description must be between 50 and 700 characters.";

            public const string Address = "Address must be between 5 and 100 characters.";

            public const string Image = "Please select a JPG, JPEG or PNG image smaller than 1MB.";

            public const string DateTime = "Please select a valid DATE and TIME from the datepicker calendar on the left.";

            public const string Rating = "Please choose a valid number of stars from 1 to 5.";
        }
        public static class Images
        {
            public const string Index = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874219/index_iyfzwc.jpg";

            public const string CoverBackground = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874218/cover-bg_nnwh6d.jpg";

            public const string Footer = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874219/footer_rvuuls.jpg";

            // BlogPosts
            public const string MakeupBag = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649495161/Image-1-2048x1365_bcam8s.jpg";
            public const string FallMakeUp = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649495678/fall-leaves-1474322117_qadfwa.jpg";
            public const string MakeUpTips = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649495951/%D0%B8%D0%B7%D1%82%D0%B5%D0%B3%D0%BB%D0%B5%D0%BD_%D1%84%D0%B0%D0%B9%D0%BB_xx6isr.jpg";
            public const string SummerHair = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649496175/Braided-Ponytail-1080x1620_e87zhy.jpg";
   
            // Categories
            

            // Salons
            
        }
        
        public static class DateTimeFormats
        {
            public const string DateFormat = "dd-MM-yyyy";

            public const string TimeFormat = "h:mmtt";

            public const string DateTimeFormat = "dd-MM-yyyy h:mmtt";
        }
        public static class SeededDataCounts
        {
            public const int BlogPosts = 5;

            public const int Categories = 6;

            public const int Services = 70;

            public const int Cities = 8;

            public const int Salons = 18;

            public const int Appointments = 65;
        }
    }
}
