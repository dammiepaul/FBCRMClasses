﻿namespace FB_CRM_Lib.Structs
{
    public struct DealLoanType
    {
        public static string BAS => "BAS";  //BANKERS ACCEPTANCE 
        public static string CM1 => "CM1";  //COMMODITY - SPOT LEG 
        public static string CM2 => "CM2";  //COMMODITY - FORWARD LEG 
        public static string CMD => "CMD";  //Commodity Deposits 
        public static string CMM => "CMM";  //Murabaha Commodity Deposits 
        public static string CMP => "CMP";  //Commidity Placement 
        public static string COL => "COL";  //Collection 
        public static string CTD => "CTD";  //CUSTOMER TIME DEPOSITS 
        public static string CTR => "CTR";  //TIME DEPOSIT -REPURCHASE RELATED 
        public static string DLI => "DLI";  //INVOICE DISOUNTING 
        public static string ECC => "ECC";  //EXPORT CLEAN COLLECTION 
        public static string EDC => "EDC";  //EXPORT DOC. COLLECTION 
        public static string ELC => "ELC";  //Trade Innovation master reference 
        public static string ELG => "ELG";  //EXPORT(RECEIVED) GUARANTEE 
        public static string EQS => "EQS";  //MARGIN LOAN - SAUDI EQUITY 
        public static string EQU => "EQU";  //MARGIN LOAN - U.S. EQUITY 
        public static string ESB => "ESB";  //STAFF LOANS - END OF SERVICE 
        public static string ESC => "ESC";  //EXPORT STANDBY LC 
        public static string EXC => "EXC";  //Personal loans - Exceptions 
        public static string FRL => "FRL";  //FIXED RATE LOAN 
        public static string FRN => "FRN";  //FLOATING RATE NOTES 
        public static string FS1 => "FS1";  //MARKET SWAP - SPOT 
        public static string FS2 => "FS2";  //MARKET SWAP -FORWARD 
        public static string FXF => "FXF";  //EXCHANGE FORWARD 
        public static string FXS => "FXS";  //EXCHANGE SPOT 
        public static string GDB => "GDB";  //GOVERNMENT DEVELOPMENT BONDS 
        public static string GEN => "GEN";  //GENERAL PURPOSE LOAN 
        public static string HCC => "HCC";  //Real Estate Loans-Synd-No REP 
        public static string HCI => "HCI";  //Real Estate Loans-Corp Isl-No REP 
        public static string HFI => "HFI";  //Home Finance (IJARA) 
        public static string ICC => "ICC";  //IMPORT CLEAN COLLECTION 
        public static string ICI => "ICI";  //Income Producing RE - Corp Islamic 
        public static string IDC => "IDC";  //IMPORT DOC. COLLECTION 
        public static string ILC => "ILC";  //Trade Innovation master reference 
        public static string ILF => "ILF";  //INSTALLMENT LOAN - FIXED 
        public static string ILG => "ILG";  //IMPORT(RECEIVED) GUARANTEE 
        public static string INC => "INC";  //Inward Clean Collection 
        public static string IND => "IND";  //Inward Documentary Collection 
        public static string IPC => "IPC";  //Income Producing RE - Corporate 
        public static string ISC => "ISC";  //IMPORT STANDBY LC 
        public static string ISL => "ISL";  //SPLIT VALUE DATES - CUSTOMER 
        public static string LCR => "LCR";  //LETTER OF CREDIT REFINANCING 
        public static string LEA => "LEA";  //LEASING (ANNUITY) 
        public static string LMG => "LMG";  //Project Finance - MR (GBP) 
        public static string LMT => "LMT";  //PROJECT FINANCE - MARKET RATE 
        public static string LSN => "LSN";  //LEASING (30-DAYS) 
        public static string MET => "MET";  //BASE METALS 
        public static string MFD => "MFD";  //Mutual Funds Deposit 
        public static string MFF => "MFF";  //Murabaha finance facility 
        public static string MMD => "MMD";  //Murabaha fund Deposit 
        public static string MMF => "MMF";  //Murabaha Fund Loan 
        public static string MOB => "MOB";  //MOBILISATION LOAN 
        public static string MOR => "MOR";  //Mortgage Loans 
        public static string MOS => "MOS";  //Mortgage Finance 
        public static string MPF => "MPF";  //Personal loan - Murabaha 
        public static string MPG => "MPG";  //Murabaha Purchase Finance 
        public static string MPM => "MPM";  //Murabaha Purchase Finance 
        public static string MPS => "MPS";  //Murabaha Purchase Share 
        public static string MPT => "MPT";  //Finance Against Commodities 
        public static string MRI => "MRI";  //Residential Mort L-Retail Islamic 
        public static string MRR => "MRR";  //Residential Mortgage Loans-Retail 
        public static string MUR => "MUR";  //MURABAHA LOAN 
        public static string MUS => "MUS";  //Murabaha Equity Facility 
        public static string OCC => "OCC";  //Other Real Estate Loan-Corporate 
        public static string OCI => "OCI";  //Other RE Loan-Corporate Islamic 
        public static string OCL => "OCL";  //Outward Clean Collection 
        public static string ORI => "ORI";  //Other RE Loan-Retail Islamic 
        public static string ORR => "ORR";  //Other Real Estate Loan-Retail 
        public static string OUC => "OUC";  //Outward Clean Collection 
        public static string OUD => "OUD";  //Outward Documentary Collection 
        public static string PLS => "PLS";  //Personal loans 
        public static string PLT => "PLT";  //Personal Loan 
        public static string PSL => "PSL";  //PR-SHIPMENT LOAN 
        public static string RAO => "RAO";  //REPURCHASEMENT AGREEMENT OVERNIGHT 
        public static string RAT => "RAT";  //REPURCHASEMENT AGREEMENT TIME 
        public static string RED => "RED";  //RETAIL DEPOSITS 
        public static string REL => "REL";  //REAL ESTATE 
        public static string RRO => "RRO";  //REVERSE REPO OVERNIGHT 
        public static string RRT => "RRT";  //REVERSE REPO TIME 
        public static string RTD => "RTD";  //Repurchase Deposit 
        public static string SBG => "SBG";  //Standbys and Guarantees 
        public static string SEH => "SEH";  //Saudi Employees Housing Loan 
        public static string SGB => "SGB";  //SPECIAL GOVERNMENT BONDS 
        public static string SID => "SID";  //SIDF BRIDGING LOAN 
        public static string SLC => "SLC";  //Other RE Loan-Com Syndication 
        public static string SLI => "SLI";  //Income Producing RE - Syndication 
        public static string SLL => "SLL";  //SYNDICATED LOAN - LEAD 
        public static string SLM => "SLM";  //Staff Loan Murabaha 
        public static string SLP => "SLP";  //SYNDICATED LOAN PARTICIPATION 
        public static string SLS => "SLS";  //A/C Rec.-Future Employment Benefit 
        public static string SMD => "SMD";  //Commodity Deposits 
        public static string SMM => "SMM";  //Murabaha Commodity Deposits 
        public static string SMP => "SMP";  //Commodity Placement 
        public static string STD => "STD";  //Time Deposit 
        public static string STH => "STH";  //STAFF LOANS - HOUSING 
        public static string STN => "STN";  //Staff Loan(Normal) 
        public static string SWD => "SWD";  //INTERNAL SWAP DEPOSIT 
        public static string SWF => "SWF";  //FORWARD SWAP EXCHANGE 
        public static string SWL => "SWL";  //INTERNAL SWAP LOAN 
        public static string SWS => "SWS";  //SPOT SWAP EXCHANGE 
        public static string TBL => "TBL";  //TREASURY BILLS 
        public static string TDP => "TDP";  //TIME DEPOSITS (TAKINGS) 
        public static string TFA => "TFA";  //TRADE FINANCE ADVANCE 
        public static string TFD => "TFD";  //TRADE FINANCE DISCOUNTED LOAN 
        public static string TFX => "TFX";  //TRADE FINANCE FOREIGN EXCHANGE 
        public static string TFY => "TFY";  //Trade finance foreign exchange 
        public static string TPL => "TPL";  //TIME PLACEMENTS 
        public static string TRF => "TRF";  //TRANSFERABLE LC 
        public static string UCC => "UCC";  //Real Estate Loans-Corporate 
        public static string URR => "URR";  //RE Loans Retail 
        public static string WCL => "WCL";  //WORKING CAPITAL 

    }
}