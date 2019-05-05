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
            View.AddTransactionRequested += View_AddTransactionRequested;
            View.ViewChanged += View_ViewChanged;
            View.SaveTransacationRequested += View_SaveTransacationRequested;
            View.SaveFileRequested += View_SaveFileRequested;
        }

        private void View_SaveFileRequested(object sender, SavingFileEventArgs e)
        {
            UpdateBankingFile();
            BankingFile.SaveToFile(e.Path);  
        }

        private void View_SaveTransacationRequested(object sender, EventArgs e)
        {
            UpdateBankingFile();
        }

        private void View_ViewChanged(object sender, EventArgs e)
        {
            BankingFile.Saved = false;
        }

        private void View_AddTransactionRequested(object sender, EventArgs e)
        {
            if (!BankingFile.Saved)
            {
                UpdateBankingFile();
            }
            BankingFile.Add();
            UpdateView();
            BankingFile.Saved = true;
        }

        public void UpdateView()
        {
            int i = BankingFile.Index;

            View.SourceIdetifierText = BankingFile[i].SourceIdentifier;
            View.AccountNumberText = BankingFile[i].AccountNumber;
            View.PaymentInstructionText = BankingFile.GetPaymentInstructionDescription(BankingFile[i].PaymentInstruction.Substring(0,2));
            View.PaymentChannelText = BankingFile.GetPaymentChannelDescription(BankingFile[i].PaymentChannel.Substring(0, 3));
            View.CreditCardText = BankingFile[i].MaskedCreditCard;
            View.ErrorCorrectionReasonText = BankingFile[i].ErrorCorrectionCode;
            View.AmountText = (BankingFile[i].Amount * 100).ToString("0.##");
            View.PaymentDate = BankingFile[i].PaymentDateTime;
            View.PaymentTime = BankingFile[i].PaymentDateTime;
            View.SettlementTime = BankingFile[i].SettlementDate;
            View.BankTransactionIDText = BankingFile[i].BankTransactionID;
            View.AuthorisationCodeText = BankingFile[i].AuthorisationCode;
            View.OriginalRefText = BankingFile[i].OriginalReference;
            View.FillList(BankingFile.ExportToList(), BankingFile.Index);
        }

        public void UpdateBankingFile()
        {
            int i = BankingFile.Index;

            BankingFile[i].SourceIdentifier = View.SourceIdetifierText;
            BankingFile[i].AccountNumber = View.AccountNumberText;
            BankingFile[i].PaymentInstruction = BankingFile.GetPaymentInstructionCode(View.PaymentInstructionText);
            BankingFile[i].PaymentChannel = BankingFile.GetPaymentChannelCode(View.PaymentChannelText);
            BankingFile[i].ErrorCorrectionCode = View.ErrorCorrectionReasonText;
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
            View.FillList(BankingFile.ExportToList(), BankingFile.Index);
        }
    }
}
