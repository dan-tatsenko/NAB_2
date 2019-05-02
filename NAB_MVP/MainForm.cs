using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAB_MVC.Views;
using NAB_MVC.Models;
using NAB_MVC.Controllers;

namespace NAB_MVC
{
    public partial class frmMainForm : Form, IBankingFileView
    {
        //private readonly NABFile NABfile;
        private TransactionController Controller = null;

        public event EventHandler TransactionAdded;
        public event EventHandler TransactionDeleted;
        public event EventHandler TransactionChanged;
        public event EventHandler SourceIdentifierChanged;

        public frmMainForm(NABFile file)
        {
            Controller = new TransactionController(this, file);
            InitializeComponent();
            Controller.DownloadValues();
        }
    
        public string TransactionLine { get => lblTransactionString.Text; set => lblTransactionString.Text=value; }
        public string SourceIdetifierText { get => txtSourceIdentifier.Text; set => txtSourceIdentifier.Text = value; }
        public string AccountNumberText { get => txtAccountNumber.Text; set => txtAccountNumber.Text = value; }
        public string PaymentInstructionText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PaymentChannelText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreditCardText { get => txtCreditCard.Text; set => txtCreditCard.Text = value; }
        public string ErrorCorrectionReasonText { get => txtErrorCorrectionReason.Text; set => txtErrorCorrectionReason.Text = value; }
        public string AmountText { get => txtAmount.Text; set => txtAmount.Text = value; }
        public DateTime PaymentDate { get => dtpPaymentDate.Value; set => dtpPaymentDate.Value = value; }
        public DateTime PaymentTime { get => dtpPaymentTime.Value; set => dtpPaymentTime.Value = value; }
        public DateTime SettlementTime { get => dtpSettlementDate.Value; set => dtpSettlementDate.Value = value; }
        public string BankTransactionIDText { get => txtBankTransactionID.Text; set => txtBankTransactionID.Text = value; }
        public string AuthorisationCodeText { get => txtAuthorisationCode.Text; set => txtAuthorisationCode.Text = value; }
        public string OriginalRefText { get => txtOriginalReference.Text; set => txtOriginalReference.Text = value; }

        public void FillTransactionChannels(List<string> list)
        {
            cbxPaymentChannel.Items.Clear();
            foreach (var item in list)
            {
                cbxPaymentChannel.Items.Add(item);
            }
        }
        public void FillPaymentInstructions(List<string> list)
        {
            cbxPaymentInstruction.Items.Clear();
            foreach (var item in list)
            {
                cbxPaymentInstruction.Items.Add(item);
            }
        }

        private void txtSourceIdentifier_TextChanged(object sender, EventArgs e)
        {
            SourceIdentifierChanged(this, new EventArgs());
        }
    }
}
