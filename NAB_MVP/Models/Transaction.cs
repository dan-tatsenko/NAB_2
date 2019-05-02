using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAB_MVC.Views;

namespace NAB_MVC.Models
{
    public enum PaymentInstructionType
    {
        Payment,            //05 - Payment
        ErrorCorrection,    //25 - Refund
        Reversal            //35 - Chargeback
    }

   public enum PaymentChannelType
    {
        WebPayment,                 //PBW - WEB Payments
        InteractiveVoiceResponse,   //IVR - Interactive Voice Response
        BankPayment,                //BPY - Bank Payment
        DirectPostPayment,          //DPP - Direct Post Payment
        PayInPerson                 //PiP - Payment in Person
    }

    public class Transaction : ITransaction
    {
        public Transaction()
        {
            _recordType = "50";
        }

        public event EventHandler<EventArgs> AmountChanged;

        private decimal _amount;
        private string _recordType;

        public string RecordType { get => _recordType; }

        public string SourceIdentifier { get => SourceIdentifier; set => value.Take(10); }
        public string AccountNumber { get; set; }
        
        public PaymentInstructionType PaymentInstruction { get; set; }
        public PaymentChannelType PaymentChannel { get; set; }
        public string MaskedCreditCard { get; set; }
        public byte ErrorCorrectionReason { get; set; }
        public decimal Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
                AmountChanged(this, new EventArgs());
            }
        }
        public DateTime PaymentDateTime { get; set; }
        public DateTime SettlementDate { get; set; }
        public string BankTransactionID { get; set; }
        public string AuthorisationCode { get; set; }
        public string OriginalReference { get; set; }

        public string PaymentInstructionCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string ToString()
        {
            string r = "";

            r += _recordType;
            return r;
        }
    }
}
