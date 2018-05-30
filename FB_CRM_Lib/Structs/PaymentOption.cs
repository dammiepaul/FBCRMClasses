namespace FB_CRM_Lib.Structs
{
    //Bill Payment options for Credit card and Utility accounts
    public struct PaymentOption
    {
        public static string NotAvailable => "NA";
        public static string MinimumDue => "MD";
        public static string OutstandingAmount => "OA";
        public static string FixedPercentage => "FP";

    }
}