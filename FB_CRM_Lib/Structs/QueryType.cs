namespace FB_CRM_Lib.Structs
{
    public struct QueryType
    {
        public static string CASA => "CASA";                    //Current & Saving Account
        public static string FD => "FD";                        //Fixed Deposit Account
        public static string LOAN => "LOAN";                    //Loan Account
        public static string OTHER => "OTHER";                  //Other Account
        public static string CASA_FD => "CASA_FD";              //CASA and FD Accounts
        public static string CASA_LOAN => "CASA_LOAN";          //CASA and LOAN Accounts
        public static string CASA_OTHER => "CASA_OTHER";        //CASA and OTHER Accounts
        public static string FD_LOAN => "FD_LOAN";              //FD and LOAN Accounts
        public static string FD_OTHER => "FD_OTHER";            //FD and OTHER Accounts
        public static string LOAN_OTHER => "LOAN_OTHER";        //LOAN and OTHER Accounts
        public static string CASA_FD_LOAN => "CASA_FD_LOAN";    //CASA, FD and LOAN Accounts
        public static string ALL => "ALL";                      //All types of Accounts and Cards
        public static string CC => "CC";                        //Credit Card
        public static string DC => "DC";                        //Debit Card
        public static string PC => "PC";                        //Prepaid Card
        public static string CC_DC => "CC_DC";                  //Credit Card and Debit Card
        public static string CC_PC => "CC_PC";                  //Credit Card and Prepaid Card
        public static string DC_PC => "DC_PC";                  //Debit Card and Prepaid Card
        public static string DC_PC_CC => "DC_PC_CC";            //Debit, Prepaid and Credit Card
    }
}