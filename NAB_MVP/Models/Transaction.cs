using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAB_MVC.Views;

namespace NAB_MVC.Models
{
    public class Transaction
    {
        public Transaction()
        {
            Random r = new Random();
            recordType = "50";
            sourceIdentifier = "26" + r.Next(1000, 9999).ToString(); ;
            accountNumber = "000000";
            paymentInstruction = "05";
            paymentChannel = "PBW" + r.Next(1000,9999).ToString();
            maskedCreditCard = "VI4012..." + r.Next(1000, 9999).ToString();
            errorCorrectionCode = "000";
            amount = 0;
            paymentDateTime = DateTime.Today;
            settlementDate = DateTime.Today;
            bankTransactionID = "NAB" + r.Next(1000, 9999).ToString(); ;
            authorisationCode = r.Next(1000, 9999).ToString(); ;
            originalReference = "TestingBankFile";
        }

      
        private string recordType;
        private string sourceIdentifier;
        private string accountNumber;
        private string paymentInstruction;
        private string paymentChannel;
        private string maskedCreditCard;
        private string errorCorrectionCode;
        private decimal amount;
        private DateTime paymentDateTime;
        private DateTime settlementDate;
        private string bankTransactionID;
        private string authorisationCode;
        private string originalReference;

        public string RecordType { get => recordType; }
        public string SourceIdentifier
        {
            get => sourceIdentifier;
            set
            {
                if (value.Length>10)
                {
                    sourceIdentifier = value.Substring(0, 10);
                }
                else sourceIdentifier = value;
            }
        }
        public string AccountNumber
        {
            get => accountNumber;
            set
            {
                if (value.Length>20)
                {
                    accountNumber = value.Substring(0, 20);
                }
                else accountNumber = value;

            }
        }
        public string PaymentInstruction
        {
            get => paymentInstruction;
            set
            {
                if (value.Length > 2)
                {
                    paymentInstruction = value.Substring(0, 2);
                }
                else paymentInstruction = value;
            }
        }
        public string PaymentChannel
        {
            get => paymentChannel;
            set
            {
                string s = paymentChannel.Remove(0,3).Insert(0, value); 
                if (s.Length > 21)
                {
                    paymentChannel = s.Substring(0, 21);
                }
                else paymentChannel = s;
            } 
        }
        public string MaskedCreditCard
        {
            get => maskedCreditCard;
            set
            {
                if (value.Length > 21)
                {
                    maskedCreditCard = value.Substring(0, 21);
                }
                else maskedCreditCard = value;
            }
        }

        public string ErrorCorrectionCode
        {
            get => errorCorrectionCode;
            set
            {
                if (value.Length > 3)
                {
                    errorCorrectionCode = value.Substring(0, 3);
                }
                else errorCorrectionCode = value;

            }
        }
        public decimal Amount
        {
            get => amount;
            set => amount = value;
        }
        public DateTime PaymentDateTime
        {
            get => paymentDateTime;
            set => paymentDateTime = value;
        }
        public DateTime SettlementDate
        {
            get => settlementDate;
            set => settlementDate = value;
        }
        public string BankTransactionID
        {
            get => bankTransactionID;
            set
            {
                if (value.Length > 30)
                {
                    bankTransactionID = value.Substring(0, 30);
                }
                else bankTransactionID = value;
            }

        }
        public string AuthorisationCode
        {
            get => authorisationCode;
            set
            {
                if (value.Length > 6)
                {
                    authorisationCode = value.Substring(0, 6);
                }
                else authorisationCode = value;
            }

        }
        public string OriginalReference
        {
            get => originalReference;
            set
            {
                if (value.Length > 20)
                {
                    originalReference = value.Substring(0, 20);
                }
                else originalReference = value;
            }

        }

        public override string ToString()
        {
            string r = "";

            r += recordType;
            r += sourceIdentifier.PadLeft(10,'0');
            r += accountNumber.PadLeft(20);
            r += paymentInstruction.PadLeft(2, '0');
            r += paymentChannel.PadRight(21);
            r += maskedCreditCard.PadRight(21);
            r += errorCorrectionCode.PadLeft(3, '0');
            r += amount.ToString("00").PadLeft(12, '0');
            r += paymentDateTime.Year.ToString();
            r += paymentDateTime.Month.ToString("00");
            r += paymentDateTime.Day.ToString("00");
            r += paymentDateTime.Hour.ToString("00");
            r += paymentDateTime.Minute.ToString("00");
            r += paymentDateTime.Second.ToString("00");
            r += settlementDate.Year.ToString("00");
            r += settlementDate.Month.ToString("00");
            r += settlementDate.Day.ToString("00");
            r += bankTransactionID.PadRight(30);
            r += authorisationCode.PadRight(6);
            r += originalReference.PadRight(20);
            r = r.PadRight(219);   
            return r;
        }
    }
}
