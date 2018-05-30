namespace FB_CRM_Lib.Structs
{
    public struct AccountStatus
    {
        public static string Active => "AccountActive";
        public static string Deceased => "AccountDeceased ";
        public static string Liquidated => "AccountLiquidated";
        public static string Closed => "AccountClosed";

    }
}