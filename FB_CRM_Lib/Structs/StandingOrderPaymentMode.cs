namespace FB_CRM_Lib.Structs
{
    public struct StandingOrderPaymentMode
    {
        public static string PayUntillFurtherNotice => "PayUntillFurtherNotice";
        public static string PayUntillSpecificDateReached => "PayUntillSpecificDateReached";
        public static string PayUntillNumberofPaymentsReached => "PayUntillNumberofPaymentsReached";
        public static string PaymentsStopped => "PaymentsStopped";
        public static string FinalPaymentMade => "FinalPaymentMade";

    }
}