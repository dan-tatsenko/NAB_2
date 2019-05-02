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
            DownloadValues();
            View.FileViewChanged += View_FileViewChanged;
        }

        private void View_FileViewChanged(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            t.SourceIdentifier = View.SourceIdetifierText;

            BankingFile.Add(t);
        }

        public void DownloadValues()
        {
            View.FillPaymentInstructions(BankingFile.GetPaymentInstructionsList());
            View.FillTransactionChannels(BankingFile.GetPaymentChannelsList());
        }
    }
}
