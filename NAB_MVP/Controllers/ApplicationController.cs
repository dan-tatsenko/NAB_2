using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAB_MVC.Views;
using NAB_MVC.Models;


namespace NAB_MVC.Controllers
{
    public class ApplicationController
    {
        IBankingFileView View;
        IBankingFile BankingFile;
        

        public ApplicationController(IBankingFileView view, IBankingFile file)
        {
            View = view;
            BankingFile = file;
            View.EnabledView = false;

            View.AddTransactionRequested += View_AddTransactionRequested;
            View.UpdateTransacationRequested += View_UpdateTransacationRequested;
            View.SaveFileRequested += View_SaveFileRequested;
            View.DeleteTransactionRequested += View_DeleteTransactionRequested;
            View.SelectedIndexChanged += View_SelectedIndexChanged;
            BankingFile.NewTransactionAdded += BankingFile_NewTransactionAdded;
        }

        private void BankingFile_NewTransactionAdded(object sender, EventArgs e)
        {
            UpdateFields();
            View.UpdateListDataSource(BankingFile.TransactionList, BankingFile.Index);
        }

        private void View_SelectedIndexChanged(object sender, SelectedIndexChangedEventArg e)
        {
            UpdateBankingFile();
            BankingFile.Index = e.NewIndex;
            UpdateFields();
            View.UpdateListDataSource(BankingFile.TransactionList, BankingFile.Index);
        }

        private void View_DeleteTransactionRequested(object sender, DeletingTransactionEventArg deletingTransactionEventArg)
        {
            BankingFile.Remove(deletingTransactionEventArg.DeletingIndex);
            UpdateFields();
            View.UpdateListDataSource(BankingFile.TransactionList, BankingFile.Index);
        }

        private void View_SaveFileRequested(object sender, SavingFileEventArgs e)
        {
            UpdateBankingFile();
            View.UpdateListDataSource(BankingFile.TransactionList, BankingFile.Index);
            BankingFile.SaveToFile(e.Path);  
        }

        private void View_UpdateTransacationRequested(object sender, EventArgs e)
        {
            UpdateBankingFile();
            View.UpdateListDataSource(BankingFile.TransactionList, BankingFile.Index);
        }

        private void View_AddTransactionRequested(object sender, EventArgs e)
        {
            if (!View.EnabledView)
            {
                View.EnabledView = true;
                View.ClearView();
            }
            BankingFile.Add();
        }

        public void UpdateFields()
        {
            int i = BankingFile.Index;
            if (i >= 0)
            {
                View.SourceIdetifierText = BankingFile[i].SourceIdentifier;
                View.AccountNumberText = BankingFile[i].AccountNumber;
                View.PaymentInstructionText = BankingFile.GetPaymentInstructionDescription(BankingFile[i].PaymentInstruction.Substring(0, 2));
                View.PaymentChannelText = BankingFile.GetPaymentChannelDescription(BankingFile[i].PaymentChannel.Substring(0, 3));
                View.CreditCardText = BankingFile[i].MaskedCreditCard;
                View.ErrorCorrectionReasonText = BankingFile[i].ErrorCorrectionCode;
                View.AmountText = (BankingFile[i].Amount / 100).ToString("0.##");
                View.PaymentDate = BankingFile[i].PaymentDateTime;
                View.PaymentTime = BankingFile[i].PaymentDateTime;
                View.SettlementTime = BankingFile[i].SettlementDate;
                View.BankTransactionIDText = BankingFile[i].BankTransactionID;
                View.AuthorisationCodeText = BankingFile[i].AuthorisationCode;
                View.OriginalRefText = BankingFile[i].OriginalReference;
            }
            else
            {
                View.ClearView();
                View.EnabledView = false;
            }
        }

        public void UpdateBankingFile()
        {
            int i = BankingFile.Index;
            if (i >= 0)
            {

                BankingFile[i].SourceIdentifier = View.SourceIdetifierText;
                BankingFile[i].AccountNumber = View.AccountNumberText;
                BankingFile[i].PaymentInstruction = BankingFile.GetPaymentInstructionCode(View.PaymentInstructionText);
                BankingFile[i].PaymentChannel = BankingFile.GetPaymentChannelCode(View.PaymentChannelText);
                BankingFile[i].ErrorCorrectionCode = View.ErrorCorrectionReasonText;

                BankingFile[i].Amount = Convert.ToInt32(decimal.Parse(View.AmountText) * 100);
                BankingFile[i].PaymentDateTime = new DateTime(View.PaymentDate.Year, View.PaymentDate.Month,
                                                                View.PaymentDate.Day, View.PaymentTime.Hour,
                                                                View.PaymentTime.Minute, View.PaymentTime.Second);
                BankingFile[i].SettlementDate = View.SettlementTime;
                BankingFile[i].BankTransactionID = View.BankTransactionIDText;
                BankingFile[i].AuthorisationCode = View.AuthorisationCodeText;
                BankingFile[i].OriginalReference = View.OriginalRefText;
            }
        }
    }
}
