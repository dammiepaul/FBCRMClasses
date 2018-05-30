namespace FB_CRM_Lib.Structs
{
    public struct TFApplicationState
    {
        public static string Preinitiated => "Preinitiated";
        public static string Initiated => "Initiated";
        public static string SubmittedToBank => "SubmittedToBank";
        public static string PendingForExecution => "PendingForExecution";
        public static string CancelledByCustomer => "CancelledByCustomer";
        public static string AcceptedByBank => "AcceptedByBank";
        public static string AwaitingInformation => "AwaitingInformation";
        public static string RejectedByBank => "RejectedByBank";
        public static string Approved => "Approved";

    }
}