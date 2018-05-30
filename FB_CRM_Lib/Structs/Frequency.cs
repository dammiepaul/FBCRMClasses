namespace FB_CRM_Lib.Structs
{
    //Frequency of eStatement, Full statement and Loan payment schedule
    public struct Frequency
    {
        public static string NotAvailable => "NAV";
        public static string Monthly => "MON";
        public static string Quarterly => "QTR";
        public static string HalfYearky => "HYR";
        public static string Yearly => "YER";

    }
}