using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NAB
{
    public partial class NABCreator : Form
    {
        public NABCreator()
        {
            File = new NABFile();
            CurrentTransaction = new Transaction();
            File.AddTransaction(CurrentTransaction);
            InitializeComponent();
        }

        private void ReflectCurrentTransaction()
        {
            SourceIdentifierText.Text = CurrentTransaction.SourceIdentifier;
            BankTransactionIDText.Text = CurrentTransaction.BankTransactionID;
            TransactionReferenceNumber3Text.Text = CurrentTransaction.MaskedCard;
            PaymentInstructionList.SelectedIndex = PaymentInstructionList.Items.IndexOf(CurrentTransaction.PaymentInstruction);
            PaymentChannelList.SelectedIndex = PaymentChannelList.Items.IndexOf(CurrentTransaction.PaymentChannel);
            AuthorizationCodeText.Text = CurrentTransaction.AuthorizationCode;
            OriginalReferenceText.Text = CurrentTransaction.OriginalReference;
            PaymentDatePicker.Value = CurrentTransaction.PaymentDateTime;
            PaymentTimePicker.Value = CurrentTransaction.PaymentDateTime;
            SettlementDateText.Text = CurrentTransaction.SettelmentDate.ToString("dMMyyyy");
            ErrorCorrectionReasonText.Text = CurrentTransaction.ErrorCorrectionReason;
        }

        private void ReflectNABFile()
        {
            TransactionsListbox.Items.Clear();
            List<string> t = new List<string>();
            t = File.ExportToList();
            foreach (string s in t)
            {
                TransactionsListbox.Items.Add(s);
            }
        }

        private void NABCreator_Load(object sender, EventArgs e)
        {
            ReflectCurrentTransaction();
            ReflectNABFile();
        }

        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            CurrentTransaction.FillByDefault();
            File.AddTransaction(CurrentTransaction);
            ReflectCurrentTransaction();
            ReflectNABFile();
        }

        private void SaveTransactionButton_Click(object sender, EventArgs e)
        {
            File.UpgradeCurrentTransaction(CurrentTransaction);
        }

        private void PaymentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            SettlementDateText.Text = PaymentDatePicker.Value.ToString("dMMyyyy");
        }

        private void DeleteTransactionButton_Click(object sender, EventArgs e)
        {
            int selected_index;
            selected_index = TransactionsListbox.SelectedIndex;
            if (selected_index>=0)
            {
                TransactionsListbox.Items.RemoveAt(selected_index);
            }
        }

        private void ExportFile_Click(object sender, EventArgs e)
        {


            if (TransactionsListbox.Items.Count>0)
            {

                SaveFileDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no transactions to save", "NAB Multi-Account File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string  path = SaveFileDialog.FileName;
            string header = "00";
            string trailer = "99";

            StreamWriter file = System.IO.File.CreateText(path);

            header += "ID".PadLeft(10, ' ');
            header += "AGILITY_TEST".PadRight(20, ' ');
            header += "666666".PadLeft(6, '0');
            header += "999999999".PadLeft(9, '0');
            header += DateTime.Today.ToString("yyyyMMd");
            header += DateTime.Now.ToString("HHmmss");
            header += "SETT101".PadRight(10, ' ');
            header += " ".PadLeft(148, ' ');

            trailer += "Client ID".PadLeft(10, '0');
            trailer += "NumOfPaym".PadLeft(9, '0');
            trailer += "AmountOfPayment".PadLeft(15, '0');
            trailer += "NumberOfF".PadLeft(9, '0');
            trailer += "AmountOfFeeChar".PadLeft(15, '0');
            trailer += "NumberOfE".PadLeft(9, '0');
            trailer += "AmountOfErrorCo".PadLeft(15, '0');
            trailer += "TotalAmountOfSe".PadLeft(15, '0');
            trailer += " ".PadLeft(120, ' ');

            file.WriteLine(header);
            foreach (string line in TransactionsListbox.Items)
            {
                file.WriteLine(line);    
            }
            file.WriteLine(trailer);
            file.Close();
        }
    }
}
