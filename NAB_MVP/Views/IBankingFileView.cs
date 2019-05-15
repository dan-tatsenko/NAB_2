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

    public class DeletingTransactionEventArg: EventArgs
    {
        public DeletingTransactionEventArg(int deletingIndex)
        {
            DeletingIndex = deletingIndex;
        }

        public int DeletingIndex { get; }

    }

    public class SelectedIndexChangedEventArg: EventArgs
    {
        public SelectedIndexChangedEventArg(int newIndex)
        {
            NewIndex = newIndex;
        }

        public  int NewIndex { get; }
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

        bool IsViewEnabled { get; set; }
        void UpdateListDataSource(List<string> data, int index);
        void ClearView();

        event EventHandler AddTransactionRequested;
        event EventHandler UpdateTransacationRequested;
        event EventHandler<DeletingTransactionEventArg> DeleteTransactionRequested;
        event EventHandler<SavingFileEventArgs> SaveFileRequested;
        event EventHandler<SelectedIndexChangedEventArg> SelectedIndexChanged;
    }
}
