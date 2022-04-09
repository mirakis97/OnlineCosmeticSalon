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
            public const string Index = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649513323/wp7885170-beauty-parlour-wallpapers_nnybgh.jpg";

            public const string CoverBackground = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649513105/photo-1588421357574-87938a86fa28_pp2wxl.jpg";

            public const string Footer = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874219/footer_rvuuls.jpg";

            // BlogPosts
            public const string MakeupBag = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649495161/Image-1-2048x1365_bcam8s.jpg";
            public const string FallMakeUp = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649495678/fall-leaves-1474322117_qadfwa.jpg";
            public const string MakeUpTips = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649495951/%D0%B8%D0%B7%D1%82%D0%B5%D0%B3%D0%BB%D0%B5%D0%BD_%D1%84%D0%B0%D0%B9%D0%BB_xx6isr.jpg";
            public const string SummerHair = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649496175/Braided-Ponytail-1080x1620_e87zhy.jpg";

            // Categories
            public const string Hair = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649512413/summer-hairstyles-for-women_xkbrgk.jpg";
            public const string HairExtension = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649512498/1-1_uj5snr.jpg";
            public const string Massage = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649512590/istockphoto-1182967465-612x612_podsbg.jpg";
            public const string Nails = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649512964/photo-1604654894610-df63bc536371_phxgkc.jpg";

            // Salons
            public const string Hair1 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649514591/monse_lqyhhg.jpg";
            public const string Hair2 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649514638/8_Myths_and_Truths_About_Hair_Loss_portada_opt_qf1gmt.jpg";
            public const string Hair3 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649514708/image_meth0w.jpg";
            public const string HairExtension1 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649514879/f1a4ec447ba80d6d2d970587e58acd20_bxjhn0.jpg";
            public const string HairExtension2 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649514927/71N2OkhnWFL._SL1001__b5zehq.jpg";
            public const string HairExtension3 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649514986/image_1_qf5ufo.jpg";
            public const string Massage1 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649515033/2020-12-21_nocaw8.jpg";
            public const string Massage2 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649515063/20180803160843_cu8kox.jpg";
            public const string Massage3 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649515091/mASSAGE_SETUP_xkggsi.jpg";
            public const string Nails1 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649514446/00f2d2bae4f3755cb10a7171fc825d80_d8sufm.jpg";
            public const string Nails2 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649514485/nails1_lynncq.webp";
            public const string Nails3 = "https://res.cloudinary.com/dck6iktyj/image/upload/v1649514525/83462927-491199604909972-4769799099605554255-n_owiisy.webp";
        }
        
        public static class DateTimeFormats
        {
            public const string DateFormat = "dd-MM-yyyy";

            public const string TimeFormat = "h:mmtt";

            public const string DateTimeFormat = "dd-MM-yyyy h:mmtt";
        }
        public static class SeededDataCounts
        {
            public const int BlogPosts = 4;

            public const int Categories = 4;

            public const int Services = 70;

            public const int Cities = 5;

            public const int Salons = 12;

            public const int Appointments = 65;
        }
    }
}
