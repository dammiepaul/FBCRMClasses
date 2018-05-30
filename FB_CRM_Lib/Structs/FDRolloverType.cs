namespace FB_CRM_Lib.Structs
{
    public struct FDRolloverType
    {
        public static string DontRolloverPrincipalorInterest => "T";
        public static string RolloverPrincipalAndInterest => "I";
        public static string RolloverOnlyInterest => "P";
        public static string RolloverOnlyPrincipal => "O";
        public static string RolloverSpecialAmount => "S";

    }
}