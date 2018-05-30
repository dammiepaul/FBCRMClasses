namespace FB_CRM_Lib.Structs
{
    public struct CustomerSegment
    {
        public static int NotSpecified => 1;
        public static int Core => 2;
        public static int Corporate => 3;
        public static int External => 4;
        public static int NotAvailable => 5;
        public static int Prestige => 6;
        public static int Royal => 7;
        public static int StaffInternal => 8;

    }
}