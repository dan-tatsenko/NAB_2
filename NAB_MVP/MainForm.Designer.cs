namespace NAB_MVC
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblPaymentInstruction = new System.Windows.Forms.Label();
            this.cbxPaymentInstruction = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.lblTransactionString = new System.Windows.Forms.Label();
            this.lblSourceIdentifier = new System.Windows.Forms.Label();
            this.txtSourceIdentifier = new System.Windows.Forms.TextBox();
            this.lblPaymentChanell = new System.Windows.Forms.Label();
            this.cbxPaymentChannel = new System.Windows.Forms.ComboBox();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.lblErrorCorrectionReason = new System.Windows.Forms.Label();
            this.txtErrorCorrectionReason = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentTime = new System.Windows.Forms.Label();
            this.dtpPaymentTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSettlementDate = new System.Windows.Forms.DateTimePicker();
            this.lblBankTransactionID = new System.Windows.Forms.Label();
            this.txtBankTransactionID = new System.Windows.Forms.TextBox();
            this.lblAuthorisationCode = new System.Windows.Forms.Label();
            this.txtAuthorisationCode = new System.Windows.Forms.TextBox();
            this.lblOriginalReference = new System.Windows.Forms.Label();
            this.txtOriginalReference = new System.Windows.Forms.TextBox();
            this.btnResetTransaction = new System.Windows.Forms.Button();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 36);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(118, 33);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // lblPaymentInstruction
            // 
            this.lblPaymentInstruction.AutoSize = true;
            this.lblPaymentInstruction.Location = new System.Drawing.Point(12, 68);
            this.lblPaymentInstruction.Name = "lblPaymentInstruction";
            this.lblPaymentInstruction.Size = new System.Drawing.Size(100, 13);
            this.lblPaymentInstruction.TabIndex = 2;
            this.lblPaymentInstruction.Text = "Payment Instruction";
            // 
            // cbxPaymentInstruction
            // 
            this.cbxPaymentInstruction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentInstruction.FormattingEnabled = true;
            this.cbxPaymentInstruction.Location = new System.Drawing.Point(118, 62);
            this.cbxPaymentInstruction.Name = "cbxPaymentInstruction";
            this.cbxPaymentInstruction.Size = new System.Drawing.Size(100, 21);
            this.cbxPaymentInstruction.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(258, 36);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(398, 33);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(538, 89);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(219, 23);
            this.btnAddTransaction.TabIndex = 6;
            this.btnAddTransaction.Text = "Save Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            // 
            // lblTransactionString
            // 
            this.lblTransactionString.AutoSize = true;
            this.lblTransactionString.Location = new System.Drawing.Point(12, 156);
            this.lblTransactionString.Name = "lblTransactionString";
            this.lblTransactionString.Size = new System.Drawing.Size(0, 13);
            this.lblTransactionString.TabIndex = 7;
            // 
            // lblSourceIdentifier
            // 
            this.lblSourceIdentifier.AutoSize = true;
            this.lblSourceIdentifier.Location = new System.Drawing.Point(12, 9);
            this.lblSourceIdentifier.Name = "lblSourceIdentifier";
            this.lblSourceIdentifier.Size = new System.Drawing.Size(84, 13);
            this.lblSourceIdentifier.TabIndex = 8;
            this.lblSourceIdentifier.Text = "Source Identifier";
            // 
            // txtSourceIdentifier
            // 
            this.txtSourceIdentifier.Location = new System.Drawing.Point(118, 6);
            this.txtSourceIdentifier.Name = "txtSourceIdentifier";
            this.txtSourceIdentifier.Size = new System.Drawing.Size(100, 20);
            this.txtSourceIdentifier.TabIndex = 9;
            this.txtSourceIdentifier.TextChanged += new System.EventHandler(this.txtSourceIdentifier_TextChanged);
            // 
            // lblPaymentChanell
            // 
            this.lblPaymentChanell.AutoSize = true;
            this.lblPaymentChanell.Location = new System.Drawing.Point(12, 98);
            this.lblPaymentChanell.Name = "lblPaymentChanell";
            this.lblPaymentChanell.Size = new System.Drawing.Size(90, 13);
            this.lblPaymentChanell.TabIndex = 10;
            this.lblPaymentChanell.Text = "Payment Channel";
            // 
            // cbxPaymentChannel
            // 
            this.cbxPaymentChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentChannel.FormattingEnabled = true;
            this.cbxPaymentChannel.Location = new System.Drawing.Point(118, 92);
            this.cbxPaymentChannel.Name = "cbxPaymentChannel";
            this.cbxPaymentChannel.Size = new System.Drawing.Size(100, 21);
            this.cbxPaymentChannel.TabIndex = 11;
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Location = new System.Drawing.Point(12, 124);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(59, 13);
            this.lblCreditCard.TabIndex = 12;
            this.lblCreditCard.Text = "Credit Card";
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(118, 121);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(100, 20);
            this.txtCreditCard.TabIndex = 13;
            // 
            // lblErrorCorrectionReason
            // 
            this.lblErrorCorrectionReason.AutoSize = true;
            this.lblErrorCorrectionReason.Location = new System.Drawing.Point(258, 9);
            this.lblErrorCorrectionReason.Name = "lblErrorCorrectionReason";
            this.lblErrorCorrectionReason.Size = new System.Drawing.Size(120, 13);
            this.lblErrorCorrectionReason.TabIndex = 14;
            this.lblErrorCorrectionReason.Text = "Error Correction Reason";
            // 
            // txtErrorCorrectionReason
            // 
            this.txtErrorCorrectionReason.Location = new System.Drawing.Point(398, 6);
            this.txtErrorCorrectionReason.Name = "txtErrorCorrectionReason";
            this.txtErrorCorrectionReason.Size = new System.Drawing.Size(100, 20);
            this.txtErrorCorrectionReason.TabIndex = 15;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(258, 65);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(74, 13);
            this.lblPaymentDate.TabIndex = 16;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(398, 62);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(100, 20);
            this.dtpPaymentDate.TabIndex = 17;
            this.dtpPaymentDate.Value = new System.DateTime(2019, 4, 27, 0, 6, 7, 0);
            // 
            // lblPaymentTime
            // 
            this.lblPaymentTime.AutoSize = true;
            this.lblPaymentTime.Location = new System.Drawing.Point(258, 98);
            this.lblPaymentTime.Name = "lblPaymentTime";
            this.lblPaymentTime.Size = new System.Drawing.Size(74, 13);
            this.lblPaymentTime.TabIndex = 18;
            this.lblPaymentTime.Text = "Payment Time";
            // 
            // dtpPaymentTime
            // 
            this.dtpPaymentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPaymentTime.Location = new System.Drawing.Point(398, 92);
            this.dtpPaymentTime.Name = "dtpPaymentTime";
            this.dtpPaymentTime.Size = new System.Drawing.Size(100, 20);
            this.dtpPaymentTime.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Settlement Date";
            // 
            // dtpSettlementDate
            // 
            this.dtpSettlementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSettlementDate.Location = new System.Drawing.Point(398, 121);
            this.dtpSettlementDate.Name = "dtpSettlementDate";
            this.dtpSettlementDate.Size = new System.Drawing.Size(100, 20);
            this.dtpSettlementDate.TabIndex = 21;
            // 
            // lblBankTransactionID
            // 
            this.lblBankTransactionID.AutoSize = true;
            this.lblBankTransactionID.Location = new System.Drawing.Point(535, 9);
            this.lblBankTransactionID.Name = "lblBankTransactionID";
            this.lblBankTransactionID.Size = new System.Drawing.Size(105, 13);
            this.lblBankTransactionID.TabIndex = 22;
            this.lblBankTransactionID.Text = "Bank Transaction ID";
            // 
            // txtBankTransactionID
            // 
            this.txtBankTransactionID.Location = new System.Drawing.Point(657, 6);
            this.txtBankTransactionID.Name = "txtBankTransactionID";
            this.txtBankTransactionID.Size = new System.Drawing.Size(100, 20);
            this.txtBankTransactionID.TabIndex = 23;
            // 
            // lblAuthorisationCode
            // 
            this.lblAuthorisationCode.AutoSize = true;
            this.lblAuthorisationCode.Location = new System.Drawing.Point(535, 36);
            this.lblAuthorisationCode.Name = "lblAuthorisationCode";
            this.lblAuthorisationCode.Size = new System.Drawing.Size(96, 13);
            this.lblAuthorisationCode.TabIndex = 24;
            this.lblAuthorisationCode.Text = "Authorisation Code";
            // 
            // txtAuthorisationCode
            // 
            this.txtAuthorisationCode.Location = new System.Drawing.Point(657, 33);
            this.txtAuthorisationCode.Name = "txtAuthorisationCode";
            this.txtAuthorisationCode.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorisationCode.TabIndex = 25;
            // 
            // lblOriginalReference
            // 
            this.lblOriginalReference.AutoSize = true;
            this.lblOriginalReference.Location = new System.Drawing.Point(535, 65);
            this.lblOriginalReference.Name = "lblOriginalReference";
            this.lblOriginalReference.Size = new System.Drawing.Size(95, 13);
            this.lblOriginalReference.TabIndex = 26;
            this.lblOriginalReference.Text = "Original Reference";
            // 
            // txtOriginalReference
            // 
            this.txtOriginalReference.Location = new System.Drawing.Point(657, 62);
            this.txtOriginalReference.Name = "txtOriginalReference";
            this.txtOriginalReference.Size = new System.Drawing.Size(100, 20);
            this.txtOriginalReference.TabIndex = 27;
            // 
            // btnResetTransaction
            // 
            this.btnResetTransaction.Location = new System.Drawing.Point(538, 118);
            this.btnResetTransaction.Name = "btnResetTransaction";
            this.btnResetTransaction.Size = new System.Drawing.Size(219, 23);
            this.btnResetTransaction.TabIndex = 28;
            this.btnResetTransaction.Text = "Reset Transaction";
            this.btnResetTransaction.UseVisualStyleBackColor = true;
            // 
            // lstFile
            // 
            this.lstFile.FormattingEnabled = true;
            this.lstFile.Location = new System.Drawing.Point(12, 172);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(486, 225);
            this.lstFile.TabIndex = 29;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 410);
            this.Controls.Add(this.lstFile);
            this.Controls.Add(this.btnResetTransaction);
            this.Controls.Add(this.txtOriginalReference);
            this.Controls.Add(this.lblOriginalReference);
            this.Controls.Add(this.txtAuthorisationCode);
            this.Controls.Add(this.lblAuthorisationCode);
            this.Controls.Add(this.txtBankTransactionID);
            this.Controls.Add(this.lblBankTransactionID);
            this.Controls.Add(this.dtpSettlementDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPaymentTime);
            this.Controls.Add(this.lblPaymentTime);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.txtErrorCorrectionReason);
            this.Controls.Add(this.lblErrorCorrectionReason);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.cbxPaymentChannel);
            this.Controls.Add(this.lblPaymentChanell);
            this.Controls.Add(this.txtSourceIdentifier);
            this.Controls.Add(this.lblSourceIdentifier);
            this.Controls.Add(this.lblTransactionString);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cbxPaymentInstruction);
            this.Controls.Add(this.lblPaymentInstruction);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "frmMainForm";
            this.Text = "Banking Interfaces - NAB Multi-Account File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblPaymentInstruction;
        private System.Windows.Forms.ComboBox cbxPaymentInstruction;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Label lblTransactionString;
        private System.Windows.Forms.Label lblSourceIdentifier;
        private System.Windows.Forms.TextBox txtSourceIdentifier;
        private System.Windows.Forms.Label lblPaymentChanell;
        private System.Windows.Forms.ComboBox cbxPaymentChannel;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.Label lblErrorCorrectionReason;
        private System.Windows.Forms.TextBox txtErrorCorrectionReason;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentTime;
        private System.Windows.Forms.DateTimePicker dtpPaymentTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSettlementDate;
        private System.Windows.Forms.Label lblBankTransactionID;
        private System.Windows.Forms.TextBox txtBankTransactionID;
        private System.Windows.Forms.Label lblAuthorisationCode;
        private System.Windows.Forms.TextBox txtAuthorisationCode;
        private System.Windows.Forms.Label lblOriginalReference;
        private System.Windows.Forms.TextBox txtOriginalReference;
        private System.Windows.Forms.Button btnResetTransaction;
        private System.Windows.Forms.ListBox lstFile;
    }
}

