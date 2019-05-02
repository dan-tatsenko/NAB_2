using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAB_MVC.Views;

namespace NAB_MVC.Models
{
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
        
        public string PaymentInstruction { get; set; }
        public string PaymentChannel { get; set; }
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

        public override string ToString()
        {
            string r = "";

            r += _recordType;
            return r;
        }
    }
}
