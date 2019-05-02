using System;

namespace NAB
{
    class Transaction
    {
        enum PaymentInstructionTypes
        {
            Payment,
            ErrorCorrection,
            Reversal
        }
        enum PaymentChannels
        {
            WebPayment,
            InteractiveVoiceResponse,
            BankPayment,
            DirectPostPayment,
            PayInPerson
        }
        enum CreditCardTypes
        {
            Visa,
            Mastercard,
            AmericanExpress,
            DinersClub,
            JapanCreditBureau
        }

        private const string recordType = "50";

        private string sourceIdentifier;
        private string customerAccountNumber;
        private PaymentInstructionTypes paymentInstruction;
        private PaymentChannels paymentChannel;
        private string maskedCard;
        private string errorCorrectionReason;
        private int amount;
        private DateTime paymentDateTime;
        private DateTime settlementDate;
        private string bankTransactionID;
        private string authorizationCode;
        private string originalReference;

        public void FillByDefault()
        {
            Random r = new Random();
            sourceIdentifier = "264465";
            customerAccountNumber = "";
            paymentInstruction = PaymentInstructionTypes.Payment;
            paymentChannel = PaymentChannels.WebPayment;
            maskedCard = Card.Generate();
            errorCorrectionReason = "000";
            amount = 0;
            paymentDateTime = DateTime.Today.AddDays(-1);
            settlementDate = DateTime.Today;
            bankTransactionID = "BankTransID" + r.Next(9999).ToString();
            authorizationCode = "1007";
            originalReference = "REF";
        }

        public Transaction()
        {
            FillByDefault();
        }

        public string RecordType => recordType;
        public string SourceIdentifier
        {
            get => sourceIdentifier;
            set => sourceIdentifier = value.Substring(0, 10);
        }
        public string CustomerAccountNumber
        {
            get
            {
                if (customerAccountNumber!="")
                {
                    return customerAccountNumber.Substring(0, customerAccountNumber.Length - 1);
                }
                else
                {
                    return "";
                }
                
            }
            set
            {
                customerAccountNumber = value + "0";
            }
        }
        public string PaymentInstruction
        {
            get
            {
                string p = "";

                switch (paymentInstruction)
                {
                    case PaymentInstructionTypes.Payment:
                        p = "05";
                        break;
                    case PaymentInstructionTypes.ErrorCorrection:
                        p = "25";
                        break;
                    case PaymentInstructionTypes.Reversal:
                        p = "35";
                        break;
                };
                return p;
            }
            set
            {
                string code = value.Substring(0, 2);
                switch (code)
                {
                    case "05":
                        paymentInstruction = PaymentInstructionTypes.Payment;
                        break;
                    case "25":
                        paymentInstruction = PaymentInstructionTypes.ErrorCorrection;
                        break;
                    case "35":
                        paymentInstruction = PaymentInstructionTypes.Reversal;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid value for Payment Instruction");
                        break;
                }
            }
        }
        public string PaymentChannel
        {
            get
            {
                string c = "";

                switch (paymentChannel)
                {
                    case PaymentChannels.WebPayment:
                        c = "PBW";
                        break;
                    case PaymentChannels.InteractiveVoiceResponse:
                        c = "PBP";
                        break;
                    case PaymentChannels.BankPayment:
                        c = "BPY";
                        break;
                    case PaymentChannels.DirectPostPayment:
                        c = "DPP";
                        break;
                    case PaymentChannels.PayInPerson:
                        c = "PiP";
                        break;
                };
                return c;
            }

            set
            {
                string code = value.Substring(0, 3);
                switch (code)
                {
                    case "PBW":
                        paymentChannel = PaymentChannels.WebPayment;
                        break;
                    case "PBP":
                        paymentChannel = PaymentChannels.InteractiveVoiceResponse;
                        break;
                    case "BPY":
                        paymentChannel = PaymentChannels.BankPayment;
                        break;
                    case "DPP":
                        paymentChannel = PaymentChannels.DirectPostPayment;
                        break;
                    case "PiP":
                        paymentChannel = PaymentChannels.PayInPerson;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid value for Payment Channel");
                        break;
                }

            }
        }
        public string MaskedCard
        {
            get => maskedCard;
            set => maskedCard = value.Substring(0, 21);
        }
        public string ErrorCorrectionReason
        {
            get => errorCorrectionReason;
            set => errorCorrectionReason = value.Substring(0, 3);
        }
        public decimal Amount
        { get => (amount / 100);
            set => amount = (int)(value * 100);
        }
        public DateTime PaymentDateTime
        {
            get => paymentDateTime;
            set => paymentDateTime = value;
        }
        public DateTime SettelmentDate
        {
            get => settlementDate;
            set => settlementDate = value;
        }
        public string BankTransactionID 
        {
            get => bankTransactionID;
            set => bankTransactionID = value.Substring(0,30);
        }
        public string AuthorizationCode
        {
            get => authorizationCode;
            set => authorizationCode = value.Substring(0, 6);
        }
        public string OriginalReference
        {
            get => originalReference;
            set => originalReference = value.Substring(0, 20);
        }

        public override string ToString()
        {
            string result = "";
            result += RecordType;
            result += SourceIdentifier.PadLeft(10, '0');
            result += CustomerAccountNumber.PadLeft(20, ' ');
            result += PaymentInstruction;
            result += PaymentChannel.PadRight(21,' ');
            result += MaskedCard.PadRight(21, ' ');
            result += ErrorCorrectionReason.PadRight(3, '0');
            result += Amount.ToString().PadLeft(12, '0');
            result += PaymentDateTime.Year.ToString() + PaymentDateTime.Month.ToString("00") + PaymentDateTime.Day.ToString("00");
            result += PaymentDateTime.Hour.ToString("00") + PaymentDateTime.Minute.ToString("00") + PaymentDateTime.Second.ToString("00");
            result += SettelmentDate.Day.ToString("00") + SettelmentDate.Month.ToString("00") + SettelmentDate.Year.ToString();
            result += BankTransactionID.PadLeft(30, ' ');
            result += AuthorizationCode.PadLeft(6, ' ');
            result += OriginalReference.PadLeft(20, ' ');
            result += "".PadLeft(50, ' ');
            return result;
        }
    }
}