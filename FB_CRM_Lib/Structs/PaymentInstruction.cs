namespace FB_CRM_Lib.Structs
{
    //Charges Payment Instruction
    public struct PaymentInstruction
    {
        public static string Beneficiary => "BEN";  //Beneficiary
        public static string Ourself => "OUR";      //Ourself (Applicant)
        public static string Shared => "SHA";       //Shared
        public static string Deffered => "DEF";     //Deffered

    }
}