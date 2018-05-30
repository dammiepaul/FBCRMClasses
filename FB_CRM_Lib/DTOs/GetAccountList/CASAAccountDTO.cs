using System.Collections.Generic;

namespace FB_CRM_Lib.DTOs.GetAccountList
{
    public class CASAAccountDTO
    {
        public string AccountNumber { get; set; }
        public string AccountDescription { get; set; }
        public string AccountStatus { get; set; }
        public string AccountType { get; set; }
        public decimal AvailableBalanceInAccountCurrency { get; set; }
        public decimal? AvailableBalanceInLocalCurrency { get; set; }
        public decimal? BookBalanceInAccountCurrency { get; set; }
        public decimal? BookBalanceInLocalCurrency { get; set; }
        public decimal? UnclearedBalanceInAccountCurrency { get; set; }
        public decimal? UnclearedBalanceInLocalCurrency { get; set; }
        public string AccountCurrency { get; set; }
        public bool? IsDormantAccount { get; set; }
        public string ProductType { get; set; }     //Check struct for CASAAccountProductType. This needs verification
        public string AccountOperationMode { get; set; }
        public string AccountOpeningDate { get; set; }
        public string IBAN { get; set; }
        public bool? DoesHoldExist { get; set; }
        public decimal? TotalHoldAmount { get; set; }
        public string QueryType { get; set; }   //Will always be CASA
        public string BranchCode { get; set; }
        public List<DataItemDTO> DataItem { get; set; }
    }
}