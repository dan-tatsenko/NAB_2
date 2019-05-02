﻿using System;
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
            View.SourceIdentifierChanged += View_SourceIdentifierChanged;      
        }

        private void View_SourceIdentifierChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void DownloadValues()
        {
            View.FillPaymentInstructions(BankingFile.GetPaymentInstructionsList());
            View.FillTransactionChannels(BankingFile.GetPaymentChannelsList());
        }
    }
}