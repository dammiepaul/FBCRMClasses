namespace FB_CRM_Lib.Structs
{
    public struct ChannelCode
    {
        public static int Undefined => 0;
        public static int Internet => 1;
        public static int BackOffice => 2;
        public static int CallCenterOrCRM => 3;
        public static int Branch => 4;
        public static int Mimicking => 5;
        public static int BackOfficeCorporate => 6;
        public static int Mobile => 7;
        public static int CallCentre => 9;
        public static int ASTOrTablet => 10;
        public static int VirtualGreeter => 11;
        public static int LOSorLMS => 12;
        public static int SMSBanking => 13;
        public static int ATM => 14;                    //ATM Machines
        public static int IVR => 15;                    //Interactive Voice Response
        public static int SST => 16;                    //Self Service Terminal
    }
}