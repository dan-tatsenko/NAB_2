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

        public event EventHandler AddTransactionRequested;
        public event EventHandler ViewChanged;
        public event EventHandler SaveTransacationRequested;
        public event EventHandler<SavingFileEventArgs> SaveFileRequested;
        public event EventHandler DeleteTransactionRequested;

        public frmMainForm()
        {
            InitializeComponent();
        }


        public string TransactionLine { get => lblTransactionString.Text; set => lblTransactionString.Text = value; }
        public string SourceIdetifierText { get => txtSourceIdentifier.Text; set => txtSourceIdentifier.Text = value; }
        public string AccountNumberText { get => txtAccountNumber.Text; set => txtAccountNumber.Text = value; }
        public string PaymentInstructionText
        {
            get
            {
                int i = cbxPaymentInstruction.SelectedIndex;
                return cbxPaymentInstruction.Items[i].ToString();
            }
            
            set => cbxPaymentInstruction.SelectedIndex = cbxPaymentInstruction.Items.IndexOf(value);
        }
        public string PaymentChannelText
        {
            get
            {
                int i = cbxPaymentChannel.SelectedIndex;
                return cbxPaymentChannel.Items[i].ToString();
            }

            set => cbxPaymentChannel.SelectedIndex = cbxPaymentChannel.Items.IndexOf(value);
        }
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
            cbxPaymentChannel.Items.AddRange(list.ToArray());
        }
        public void FillPaymentInstructions(List<string> list)
        {
            cbxPaymentInstruction.Items.Clear();
            cbxPaymentInstruction.Items.AddRange(list.ToArray());
        }

        private void txtSourceIdentifier_TextChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void btnAddNewTransaction_Click(object sender, EventArgs e)
        {
            AddTransactionRequested(this, new EventArgs());
            lstFile.Enabled = true;
            txtAccountNumber.Enabled = true;
            txtAmount.Enabled = true;
            txtAuthorisationCode.Enabled = true;
            txtBankTransactionID.Enabled = true;
            txtCreditCard.Enabled = true;
            txtErrorCorrectionReason.Enabled = true;
            txtOriginalReference.Enabled = true;
            txtSourceIdentifier.Enabled = true;
            dtpPaymentDate.Enabled = true;
            dtpPaymentTime.Enabled = true;
            dtpSettlementDate.Enabled = true;
            cbxPaymentChannel.Enabled = true;
            cbxPaymentInstruction.Enabled = true;
            btnSaveTransaction.Enabled = true;
        }

        public void FillList(List<string> list, int selected)
        {
            lstFile.Items.Clear();
            foreach (string line in list)
            {
                lstFile.Items.Add(line);
            }
            lstFile.SelectedIndex = selected;
        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void cbxPaymentInstruction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void cbxPaymentChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void txtCreditCard_TextChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void txtErrorCorrectionReason_TextChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void dtpPaymentDate_ValueChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void dtpPaymentTime_ValueChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void dtpSettlementDate_ValueChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void txtBankTransactionID_TextChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void txtAuthorisationCode_TextChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void txtOriginalReference_TextChanged(object sender, EventArgs e)
        {
            ViewChanged(this, new EventArgs());
        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            SaveTransacationRequested(this, new EventArgs());
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            DeleteTransactionRequested(this, new EventArgs());
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SavingFileEventArgs args = new SavingFileEventArgs(SaveFileDialog.FileName);
            SaveFileRequested(this, args);
        }


    }
}
