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
            View.FillPaymentInstructions(BankingFile.GetPaymentInstructionsList());
            View.FillTransactionChannels(BankingFile.GetPaymentChannelsList());
            View.EnabledView = false;
            //View.ClearView();
            
            View.AddTransactionRequested += View_AddTransactionRequested;
            //View.ViewChanged += View_ViewChanged;
            View.SaveTransacationRequested += View_SaveTransacationRequested;
            View.SaveFileRequested += View_SaveFileRequested;
            View.DeleteTransactionRequested += View_DeleteTransactionRequested;
            View.SelectedIndexChanged += View_SelectedIndexChanged;
        }

        private void View_SelectedIndexChanged(object sender, SelectedIndexChangedEventArg e)
        {
            if (!BankingFile.Saved)
            {
                UpdateBankingFile();
                View.FillList(BankingFile.ExportToList());
            }
            BankingFile.Index = e.NewIndex;
            UpdateView();
            BankingFile.Saved = true;
        }

        private void View_DeleteTransactionRequested(object sender, DeletingTransactionEventArg deletingTransactionEventArg)
        {
            BankingFile.Remove(deletingTransactionEventArg.DeletingIndex);
            UpdateView();
            View.FillList(BankingFile.ExportToList());
            BankingFile.Saved = true;
        }

        private void View_SaveFileRequested(object sender, SavingFileEventArgs e)
        {
            UpdateBankingFile();
            View.FillList(BankingFile.ExportToList());
            BankingFile.SaveToFile(e.Path);  
        }

        private void View_SaveTransacationRequested(object sender, EventArgs e)
        {
            UpdateBankingFile();
            View.FillList(BankingFile.ExportToList());
        }

        private void View_ViewChanged(object sender, EventArgs e)
        {
            BankingFile.Saved = false;
        }

        private void View_AddTransactionRequested(object sender, EventArgs e)
        {
            //If there is no transactions, all elements are enabled and user tries to add first one
            if (!View.EnabledView)
            {
                View.EnabledView = true; //Enable elements and clear them
                View.ClearView();
                BankingFile.Saved = true;
            }

            //If user is editing transacation and have not saved changes
            if (!BankingFile.Saved)
            {
                UpdateBankingFile(); //Save all changes to banking file
            }
            BankingFile.Add();
            UpdateView();
            View.FillList(BankingFile.ExportToList());
            BankingFile.Saved = true;
        }

        public void UpdateView()
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
                BankingFile[i].MaskedCreditCard = View.CreditCardText;
                decimal a = 0m;
                decimal.TryParse(View.AmountText, out a);
                BankingFile[i].Amount = a * 100;
                BankingFile[i].PaymentDateTime = View.PaymentDate.Date;
                BankingFile[i].PaymentDateTime = View.PaymentTime;
                BankingFile[i].SettlementDate = View.SettlementTime;
                BankingFile[i].BankTransactionID = View.BankTransactionIDText;
                BankingFile[i].AuthorisationCode = View.AuthorisationCodeText;
                BankingFile[i].OriginalReference = View.OriginalRefText;
                BankingFile.Saved = true;
            }
        }
    }
}
