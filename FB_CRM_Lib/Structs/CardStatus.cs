namespace FB_CRM_Lib.Structs
{
    public struct CardStatus
    {
        public static string Unknown => "Unknown";                              //Unknown card
        public static string Active => "Active";                                //Active
        public static string WaitingForActivation => "WaitingForActivation";    //Waiting For Activation (Not yet issued)
        public static string Blocked => "Blocked";                              //Blocked
        public static string Expired => "Expired";                              //Expired
        public static string Cancelled => "Cancelled";                          //Cancelled (by Bank)
        public static string Fraud => "Fraud";                                  //Fraudulent use
        public static string WaitingForPrint => "WaitingForPrint";             //Waiting For the printing of Plastic (Not yet Printed)

    }
}