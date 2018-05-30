namespace FB_CRM_Lib.Structs
{
    public struct TransactionNature
    {
        public static string Dr => "DR";  //Debit Transaction
        public static string Cr => "CR";  //Credit Transaction
    }


    public struct TransactionNature2
    {
        public static string Dr { get { return "DR"; } }
        public static string Cr { get { return "CR"; } }
    }
}