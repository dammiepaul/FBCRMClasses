namespace FB_CRM_Lib.Structs
{
    //Statuses for Trade Finance Documents i.e. LC, LG, Documents etc
    public struct TradeFinanceStatus
    {
        public static string Expired => "Expired";
        public static string Live => "Live";
        public static string New => "New";
        public static string Cancelled => "Cancelled";
        public static string Bookoff => "Bookoff";
        public static string Unspecified => "Unspecified";

    }
}