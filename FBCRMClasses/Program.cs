using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FB_CRM_Lib.Structs;
using FB_CRM_LibStructs;

namespace FBCRMClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var typeOfTransaction = "Dr";

            if (typeOfTransaction.ToUpper() == TransactionNature.Dr)
            {
                Console.WriteLine("Debit Transaction = " + TransactionNature.Dr);
            }
            else
            {
                Console.WriteLine("Credit Transaction = " + TransactionNature.Cr);
            }

            Console.WriteLine(QueryType.CASA_FD_LOAN);
            Console.WriteLine(IdentityDocumentType.CompanyRegistration);
            Console.WriteLine(NationalityResidencyCode.Nigeria);
            Console.WriteLine(ChannelCode.BackOfficeCorporate);
            Console.WriteLine(AccountStatus.Active);
            Console.WriteLine(CardStatus.WaitingForActivation);
            Console.WriteLine(TransactionType.Pending);
            Console.WriteLine(FDRolloverType.RolloverPrincipalAndInterest);
            Console.WriteLine(Salutation.Mrs);
            Console.WriteLine(MaritalStatus.Married);
            Console.WriteLine(Gender.Male);
            Console.WriteLine(MailingAddress.Residence);
            Console.WriteLine(PreferredLanguage.English);
            Console.WriteLine(EducationCode.Graduate);
            Console.WriteLine(IncomeSource.Investment);
            Console.WriteLine(ResidencyType.RentedApartment);
            Console.WriteLine(InsuranceType.NotSubscribed);
            Console.WriteLine(CustomerSegment.External);
            Console.WriteLine(CustomerSubSegment.PayrollDiamond);
            Console.WriteLine(AddressType.HomeCountry);
            Console.WriteLine(JobWorkSector.InformationTechnology);
            Console.WriteLine(JobTitle.DoctorDentistPhysician);
            Console.WriteLine(TransportationType.PublicTransportation);
            Console.WriteLine(AccountOperationMode.AND);
            Console.WriteLine(Frequency.Monthly);
            Console.WriteLine(ChequeStatus.Presented);
            Console.WriteLine(PaymentOption.FixedPercentage);
            Console.WriteLine(DeliveryOption.Courier);
            Console.WriteLine(CardType.DebitCard);
            Console.WriteLine(PrepaidProductCode.GiftCard);
            Console.WriteLine(FTAccountType.Account);
            Console.WriteLine(BatchType.BulkUpload);
            Console.WriteLine(PaymentInstruction.Beneficiary);
            Console.WriteLine(AccountClosureReason.FoundBetterDeal);
            Console.WriteLine(StandingOrderFrequency.HalfYearly);
            Console.WriteLine(StandingOrderPaymentMode.PayUntillNumberofPaymentsReached);
            Console.WriteLine(TradeFinanceStatus.New);
            Console.WriteLine(TransactionCode.Cash);
            Console.WriteLine(TFApplicationState.Approved);

            Console.Write("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
