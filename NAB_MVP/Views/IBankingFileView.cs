using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAB_MVC.Views
{
    public class SavingFileEventArgs : EventArgs
    {
        public string Path { get; set; }

        public SavingFileEventArgs(string path)
        {
            Path = path;
        }
    }
    public interface IBankingFileView
    {
        string SourceIdetifierText { get; set; }
        string AccountNumberText { get; set; }
        string PaymentInstructionText { get; set; }
        string PaymentChannelText { get; set; }
        string CreditCardText { get; set; }
        string ErrorCorrectionReasonText { get; set; }
        string AmountText { get; set; }
        DateTime PaymentDate { get; set; }
        DateTime PaymentTime { get; set; }
        DateTime SettlementTime { get; set; }
        string BankTransactionIDText { get; set; }
        string AuthorisationCodeText { get; set; }
        string OriginalRefText { get; set; }

        string TransactionLine { get; set; }

        void FillPaymentInstructions(List<string> list);
        void FillTransactionChannels(List<string> list);
        void FillList(List<string> list, int selected);

        event EventHandler AddTransactionRequested;
        event EventHandler SaveTransacationRequested;
        event EventHandler DeleteTransactionRequested;
        event EventHandler ViewChanged;
        event EventHandler<SavingFileEventArgs> SaveFileRequested;
    }
}
