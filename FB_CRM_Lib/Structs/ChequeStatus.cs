namespace FB_CRM_Lib.Structs
{
    public struct ChequeStatus
    {
        public static string Presented => "PR";
        public static string Returned => "RT";
        public static string Cleared => "CL";
        public static string Postdated => "PD";
        public static string Stopped => "ST";
        public static string Issued => "IS";

    }
}