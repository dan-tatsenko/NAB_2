using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NAB
{
    class NABTransaction
    {
        string _recordType;
        string _sourceIdentifier;
        private string _transactionReferenceNumber;
        string _paymentInstruction;
        string _transactionReferenceNumber2;
        string _transactionReferenceNumber3;
        string _errorCorrectionReason;
        string _amount;
        string _paymentDate;
        string _paymentTime;
        string _settlementDate;
        string _bankTransactionID;
        string _authorizationCode;
        string _originalReference;

        public NABTransaction()
        {
            _recordType = "50";
        }

        public string RecordType { get => _recordType; set => _recordType = "50"; }
        public string SourceIdentifier
        {
            get => _sourceIdentifier;
            set
            {
                if (value.Length>10)
                {
                    _sourceIdentifier = value.Take(10).ToString();
                }
                else
                {
                    _sourceIdentifier = value;
                }
            }
        }

        public string TransactionReferenceNumber
        {
            get
            {
                return _transactionReferenceNumber.Substring(0,_transactionReferenceNumber.Length-1);
            }
            set
            {
                _transactionReferenceNumber = value+'0';
            }        
        }

        public string PaymentInstruction
        {
            get
            {
                return _paymentInstruction;
            }

            set
            {
                _paymentInstruction = value.Substring(0, 2);
            }
        }

        public string TransactionReferenceNumber2
        {
            get => _transactionReferenceNumber2;
            set
            {
                _transactionReferenceNumber2 = value.Substring(0, 3);
            }
        }
        public string TransactionReferenceNumber3 { get => _transactionReferenceNumber3; set => _transactionReferenceNumber3 = value; }
        public string ErrorCorrectionReason { get => _errorCorrectionReason; set => _errorCorrectionReason = value; }
        public string Amount { get => _amount; set => _amount = value+"00"; }
        public DateTime PaymentDate
        {
            get 
            {
                DateTime date;
                date = new DateTime(int.Parse(_paymentDate.Substring(0, 4)), int.Parse(_paymentDate.Substring(5, 2)), int.Parse(_paymentDate.Substring(7, 2)));
                return date;
            }
            set
            {
                string tmp;
                tmp = value.Year.ToString();
                tmp += value.Month.ToString("00");
                tmp += value.Day.ToString("00");
                _paymentDate = tmp;
            }
        }
        public string PaymentTime { get => _paymentTime; set => _paymentTime = value; }
        public string SettlementDate { get => _settlementDate; set => _settlementDate = value; }
        public string BankTransactionID { get => _bankTransactionID; set => _bankTransactionID = value; }
        public string AuthorizationCode { get => _authorizationCode; set => _authorizationCode = value; }
        public string OriginalReference { get => _originalReference; set => _originalReference = value; }
        

        public string  GenerateString()
        {
            string t = "";
            char filler = ' ';
            t += _recordType;
            t += _sourceIdentifier.PadLeft(10,'0');
            t += _transactionReferenceNumber.PadLeft(20,' ');
            t += _paymentInstruction.PadLeft(2, filler);
            t += _transactionReferenceNumber2.PadRight(21, filler);
            t += _transactionReferenceNumber3.PadRight(21, filler);
            t += _errorCorrectionReason.PadLeft(3, '0');
            t += _amount.PadLeft(12, '0');
            t += _paymentDate.PadLeft(8, '0');
            t += _paymentTime.PadLeft(6, '0');
            t += _settlementDate.PadLeft(8, ' ');
            t += _bankTransactionID.PadLeft(30, ' ');
            t += _authorizationCode.PadLeft(6, ' ');
            t += _originalReference.PadLeft(20, ' ');
            t += "".PadLeft(50, ' ');

            return t;
        }
    }
}
