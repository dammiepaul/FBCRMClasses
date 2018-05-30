namespace FB_CRM_Lib.Structs
{
    //Reasons for Account closing
    public struct AccountClosureReason
    {
        public static string PersonalReason => "PER";
        public static string NotInUse => "NIU";
        public static string BuyingCar => "BUC";
        public static string BuyingHouse => "BUH";
        public static string FoundBetterDeal => "FBD";
        public static string Travel => "TRA";
        public static string Vacation => "VAC";
        public static string HealthRelated => "HRD";

    }
}