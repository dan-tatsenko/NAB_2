namespace NAB
{
    partial class NABCreator
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
            this.grbCurrentRecord = new System.Windows.Forms.GroupBox();
            this.RecordTypeText = new System.Windows.Forms.TextBox();
            this.OriginalReferenceText = new System.Windows.Forms.TextBox();
            this.OriginalReferenceLabel = new System.Windows.Forms.Label();
            this.SaveTransactionButton = new System.Windows.Forms.Button();
            this.TransactionReferenceNumber3Text = new System.Windows.Forms.TextBox();
            this.TransactionReferenceNumber3Label = new System.Windows.Forms.Label();
            this.AuthorizationCodeText = new System.Windows.Forms.TextBox();
            this.AuthorizationCodeLabel = new System.Windows.Forms.Label();
            this.BankTransactionIDText = new System.Windows.Forms.TextBox();
            this.BankTransactionIDLabel = new System.Windows.Forms.Label();
            this.SettlementDateText = new System.Windows.Forms.TextBox();
            this.SettlementDateLabel = new System.Windows.Forms.Label();
            this.PaymentTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PaymentTimeLabel = new System.Windows.Forms.Label();
            this.PaymentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PaymentDateLabel = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ErrorCorrectionReasonText = new System.Windows.Forms.TextBox();
            this.ErrorCorrectionReasonLabel = new System.Windows.Forms.Label();
            this.PaymentChannelList = new System.Windows.Forms.ComboBox();
            this.TransactionReferenceNumber2Label = new System.Windows.Forms.Label();
            this.PaymentInstructionList = new System.Windows.Forms.ComboBox();
            this.PaymentInstructionLabel = new System.Windows.Forms.Label();
            this.TransactionReferenceNumberText = new System.Windows.Forms.TextBox();
            this.TransactionReferenceNumberLabel = new System.Windows.Forms.Label();
            this.SourceIdentifierText = new System.Windows.Forms.TextBox();
            this.SourceIdentifierLabel = new System.Windows.Forms.Label();
            this.RecordTypeLabel = new System.Windows.Forms.Label();
            this.AddTransactionButton = new System.Windows.Forms.Button();
            this.TransactionsListbox = new System.Windows.Forms.ListBox();
            this.DeleteTransactionButton = new System.Windows.Forms.Button();
            this.ExportFile = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grbCurrentRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCurrentRecord
            // 
            this.grbCurrentRecord.Controls.Add(this.RecordTypeText);
            this.grbCurrentRecord.Controls.Add(this.OriginalReferenceText);
            this.grbCurrentRecord.Controls.Add(this.OriginalReferenceLabel);
            this.grbCurrentRecord.Controls.Add(this.SaveTransactionButton);
            this.grbCurrentRecord.Controls.Add(this.TransactionReferenceNumber3Text);
            this.grbCurrentRecord.Controls.Add(this.TransactionReferenceNumber3Label);
            this.grbCurrentRecord.Controls.Add(this.AuthorizationCodeText);
            this.grbCurrentRecord.Controls.Add(this.AuthorizationCodeLabel);
            this.grbCurrentRecord.Controls.Add(this.BankTransactionIDText);
            this.grbCurrentRecord.Controls.Add(this.BankTransactionIDLabel);
            this.grbCurrentRecord.Controls.Add(this.SettlementDateText);
            this.grbCurrentRecord.Controls.Add(this.SettlementDateLabel);
            this.grbCurrentRecord.Controls.Add(this.PaymentTimePicker);
            this.grbCurrentRecord.Controls.Add(this.PaymentTimeLabel);
            this.grbCurrentRecord.Controls.Add(this.PaymentDatePicker);
            this.grbCurrentRecord.Controls.Add(this.PaymentDateLabel);
            this.grbCurrentRecord.Controls.Add(this.AmountText);
            this.grbCurrentRecord.Controls.Add(this.AmountLabel);
            this.grbCurrentRecord.Controls.Add(this.ErrorCorrectionReasonText);
            this.grbCurrentRecord.Controls.Add(this.ErrorCorrectionReasonLabel);
            this.grbCurrentRecord.Controls.Add(this.PaymentChannelList);
            this.grbCurrentRecord.Controls.Add(this.TransactionReferenceNumber2Label);
            this.grbCurrentRecord.Controls.Add(this.PaymentInstructionList);
            this.grbCurrentRecord.Controls.Add(this.PaymentInstructionLabel);
            this.grbCurrentRecord.Controls.Add(this.TransactionReferenceNumberText);
            this.grbCurrentRecord.Controls.Add(this.TransactionReferenceNumberLabel);
            this.grbCurrentRecord.Controls.Add(this.SourceIdentifierText);
            this.grbCurrentRecord.Controls.Add(this.SourceIdentifierLabel);
            this.grbCurrentRecord.Controls.Add(this.RecordTypeLabel);
            this.grbCurrentRecord.Location = new System.Drawing.Point(12, 12);
            this.grbCurrentRecord.Name = "grbCurrentRecord";
            this.grbCurrentRecord.Size = new System.Drawing.Size(635, 225);
            this.grbCurrentRecord.TabIndex = 0;
            this.grbCurrentRecord.TabStop = false;
            this.grbCurrentRecord.Text = "Current record";
            // 
            // RecordTypeText
            // 
            this.RecordTypeText.Location = new System.Drawing.Point(9, 33);
            this.RecordTypeText.MaxLength = 2;
            this.RecordTypeText.Name = "RecordTypeText";
            this.RecordTypeText.ReadOnly = true;
            this.RecordTypeText.Size = new System.Drawing.Size(120, 20);
            this.RecordTypeText.TabIndex = 33;
            this.RecordTypeText.Text = "50";
            // 
            // OriginalReferenceText
            // 
            this.OriginalReferenceText.Location = new System.Drawing.Point(499, 151);
            this.OriginalReferenceText.MaxLength = 20;
            this.OriginalReferenceText.Name = "OriginalReferenceText";
            this.OriginalReferenceText.Size = new System.Drawing.Size(120, 20);
            this.OriginalReferenceText.TabIndex = 13;
            // 
            // OriginalReferenceLabel
            // 
            this.OriginalReferenceLabel.AutoSize = true;
            this.OriginalReferenceLabel.Location = new System.Drawing.Point(496, 134);
            this.OriginalReferenceLabel.Name = "OriginalReferenceLabel";
            this.OriginalReferenceLabel.Size = new System.Drawing.Size(95, 13);
            this.OriginalReferenceLabel.TabIndex = 26;
            this.OriginalReferenceLabel.Text = "Original Reference";
            // 
            // SaveTransactionButton
            // 
            this.SaveTransactionButton.Location = new System.Drawing.Point(498, 188);
            this.SaveTransactionButton.Name = "SaveTransactionButton";
            this.SaveTransactionButton.Size = new System.Drawing.Size(121, 23);
            this.SaveTransactionButton.TabIndex = 31;
            this.SaveTransactionButton.Text = "Save Transaction";
            this.SaveTransactionButton.UseVisualStyleBackColor = true;
            this.SaveTransactionButton.Click += new System.EventHandler(this.SaveTransactionButton_Click);
            // 
            // TransactionReferenceNumber3Text
            // 
            this.TransactionReferenceNumber3Text.Location = new System.Drawing.Point(256, 33);
            this.TransactionReferenceNumber3Text.MaxLength = 21;
            this.TransactionReferenceNumber3Text.Name = "TransactionReferenceNumber3Text";
            this.TransactionReferenceNumber3Text.ReadOnly = true;
            this.TransactionReferenceNumber3Text.Size = new System.Drawing.Size(120, 20);
            this.TransactionReferenceNumber3Text.TabIndex = 5;
            // 
            // TransactionReferenceNumber3Label
            // 
            this.TransactionReferenceNumber3Label.AutoSize = true;
            this.TransactionReferenceNumber3Label.Location = new System.Drawing.Point(253, 16);
            this.TransactionReferenceNumber3Label.Name = "TransactionReferenceNumber3Label";
            this.TransactionReferenceNumber3Label.Size = new System.Drawing.Size(100, 13);
            this.TransactionReferenceNumber3Label.TabIndex = 24;
            this.TransactionReferenceNumber3Label.Text = "Masked Credit Card";
            // 
            // AuthorizationCodeText
            // 
            this.AuthorizationCodeText.Location = new System.Drawing.Point(499, 111);
            this.AuthorizationCodeText.MaxLength = 6;
            this.AuthorizationCodeText.Name = "AuthorizationCodeText";
            this.AuthorizationCodeText.Size = new System.Drawing.Size(120, 20);
            this.AuthorizationCodeText.TabIndex = 12;
            // 
            // AuthorizationCodeLabel
            // 
            this.AuthorizationCodeLabel.AutoSize = true;
            this.AuthorizationCodeLabel.Location = new System.Drawing.Point(496, 95);
            this.AuthorizationCodeLabel.Name = "AuthorizationCodeLabel";
            this.AuthorizationCodeLabel.Size = new System.Drawing.Size(96, 13);
            this.AuthorizationCodeLabel.TabIndex = 22;
            this.AuthorizationCodeLabel.Text = "Authorization Code";
            // 
            // BankTransactionIDText
            // 
            this.BankTransactionIDText.Location = new System.Drawing.Point(499, 72);
            this.BankTransactionIDText.MaxLength = 30;
            this.BankTransactionIDText.Name = "BankTransactionIDText";
            this.BankTransactionIDText.Size = new System.Drawing.Size(120, 20);
            this.BankTransactionIDText.TabIndex = 11;
            // 
            // BankTransactionIDLabel
            // 
            this.BankTransactionIDLabel.AutoSize = true;
            this.BankTransactionIDLabel.Location = new System.Drawing.Point(496, 56);
            this.BankTransactionIDLabel.Name = "BankTransactionIDLabel";
            this.BankTransactionIDLabel.Size = new System.Drawing.Size(105, 13);
            this.BankTransactionIDLabel.TabIndex = 20;
            this.BankTransactionIDLabel.Text = "Bank Transaction ID";
            // 
            // SettlementDateText
            // 
            this.SettlementDateText.Location = new System.Drawing.Point(499, 33);
            this.SettlementDateText.MaxLength = 8;
            this.SettlementDateText.Name = "SettlementDateText";
            this.SettlementDateText.ReadOnly = true;
            this.SettlementDateText.Size = new System.Drawing.Size(120, 20);
            this.SettlementDateText.TabIndex = 10;
            // 
            // SettlementDateLabel
            // 
            this.SettlementDateLabel.AutoSize = true;
            this.SettlementDateLabel.Location = new System.Drawing.Point(496, 16);
            this.SettlementDateLabel.Name = "SettlementDateLabel";
            this.SettlementDateLabel.Size = new System.Drawing.Size(83, 13);
            this.SettlementDateLabel.TabIndex = 18;
            this.SettlementDateLabel.Text = "Settlement Date";
            // 
            // PaymentTimePicker
            // 
            this.PaymentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PaymentTimePicker.Location = new System.Drawing.Point(256, 191);
            this.PaymentTimePicker.Name = "PaymentTimePicker";
            this.PaymentTimePicker.Size = new System.Drawing.Size(120, 20);
            this.PaymentTimePicker.TabIndex = 9;
            this.PaymentTimePicker.Value = new System.DateTime(2018, 12, 18, 15, 12, 55, 0);
            // 
            // PaymentTimeLabel
            // 
            this.PaymentTimeLabel.AutoSize = true;
            this.PaymentTimeLabel.Location = new System.Drawing.Point(253, 174);
            this.PaymentTimeLabel.Name = "PaymentTimeLabel";
            this.PaymentTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.PaymentTimeLabel.TabIndex = 16;
            this.PaymentTimeLabel.Text = "Payment Time";
            // 
            // PaymentDatePicker
            // 
            this.PaymentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaymentDatePicker.Location = new System.Drawing.Point(256, 151);
            this.PaymentDatePicker.Name = "PaymentDatePicker";
            this.PaymentDatePicker.Size = new System.Drawing.Size(120, 20);
            this.PaymentDatePicker.TabIndex = 8;
            this.PaymentDatePicker.ValueChanged += new System.EventHandler(this.PaymentDatePicker_ValueChanged);
            // 
            // PaymentDateLabel
            // 
            this.PaymentDateLabel.AutoSize = true;
            this.PaymentDateLabel.Location = new System.Drawing.Point(253, 134);
            this.PaymentDateLabel.Name = "PaymentDateLabel";
            this.PaymentDateLabel.Size = new System.Drawing.Size(74, 13);
            this.PaymentDateLabel.TabIndex = 14;
            this.PaymentDateLabel.Text = "Payment Date";
            // 
            // AmountText
            // 
            this.AmountText.Location = new System.Drawing.Point(256, 111);
            this.AmountText.MaxLength = 12;
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(120, 20);
            this.AmountText.TabIndex = 7;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(253, 95);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(43, 13);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "Amount";
            // 
            // ErrorCorrectionReasonText
            // 
            this.ErrorCorrectionReasonText.Location = new System.Drawing.Point(256, 72);
            this.ErrorCorrectionReasonText.MaxLength = 3;
            this.ErrorCorrectionReasonText.Name = "ErrorCorrectionReasonText";
            this.ErrorCorrectionReasonText.Size = new System.Drawing.Size(120, 20);
            this.ErrorCorrectionReasonText.TabIndex = 6;
            // 
            // ErrorCorrectionReasonLabel
            // 
            this.ErrorCorrectionReasonLabel.AutoSize = true;
            this.ErrorCorrectionReasonLabel.Location = new System.Drawing.Point(253, 56);
            this.ErrorCorrectionReasonLabel.Name = "ErrorCorrectionReasonLabel";
            this.ErrorCorrectionReasonLabel.Size = new System.Drawing.Size(120, 13);
            this.ErrorCorrectionReasonLabel.TabIndex = 10;
            this.ErrorCorrectionReasonLabel.Text = "Error Correction Reason";
            // 
            // PaymentChannelList
            // 
            this.PaymentChannelList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentChannelList.FormattingEnabled = true;
            this.PaymentChannelList.Items.AddRange(new object[] {
            "PBW",
            "PBP",
            "BPY",
            "DPP",
            "PiP"});
            this.PaymentChannelList.Location = new System.Drawing.Point(9, 190);
            this.PaymentChannelList.Name = "PaymentChannelList";
            this.PaymentChannelList.Size = new System.Drawing.Size(120, 21);
            this.PaymentChannelList.TabIndex = 4;
            // 
            // TransactionReferenceNumber2Label
            // 
            this.TransactionReferenceNumber2Label.AutoSize = true;
            this.TransactionReferenceNumber2Label.Location = new System.Drawing.Point(6, 174);
            this.TransactionReferenceNumber2Label.Name = "TransactionReferenceNumber2Label";
            this.TransactionReferenceNumber2Label.Size = new System.Drawing.Size(90, 13);
            this.TransactionReferenceNumber2Label.TabIndex = 8;
            this.TransactionReferenceNumber2Label.Text = "Payment Channel";
            // 
            // PaymentInstructionList
            // 
            this.PaymentInstructionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentInstructionList.FormattingEnabled = true;
            this.PaymentInstructionList.Items.AddRange(new object[] {
            "05",
            "25",
            "35"});
            this.PaymentInstructionList.Location = new System.Drawing.Point(9, 150);
            this.PaymentInstructionList.Name = "PaymentInstructionList";
            this.PaymentInstructionList.Size = new System.Drawing.Size(120, 21);
            this.PaymentInstructionList.TabIndex = 3;
            // 
            // PaymentInstructionLabel
            // 
            this.PaymentInstructionLabel.AutoSize = true;
            this.PaymentInstructionLabel.Location = new System.Drawing.Point(6, 134);
            this.PaymentInstructionLabel.Name = "PaymentInstructionLabel";
            this.PaymentInstructionLabel.Size = new System.Drawing.Size(100, 13);
            this.PaymentInstructionLabel.TabIndex = 6;
            this.PaymentInstructionLabel.Text = "Payment Instruction";
            // 
            // TransactionReferenceNumberText
            // 
            this.TransactionReferenceNumberText.Location = new System.Drawing.Point(9, 111);
            this.TransactionReferenceNumberText.MaxLength = 20;
            this.TransactionReferenceNumberText.Name = "TransactionReferenceNumberText";
            this.TransactionReferenceNumberText.Size = new System.Drawing.Size(120, 20);
            this.TransactionReferenceNumberText.TabIndex = 2;
            // 
            // TransactionReferenceNumberLabel
            // 
            this.TransactionReferenceNumberLabel.AutoSize = true;
            this.TransactionReferenceNumberLabel.Location = new System.Drawing.Point(6, 95);
            this.TransactionReferenceNumberLabel.Name = "TransactionReferenceNumberLabel";
            this.TransactionReferenceNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.TransactionReferenceNumberLabel.TabIndex = 4;
            this.TransactionReferenceNumberLabel.Text = "Account Number";
            // 
            // SourceIdentifierText
            // 
            this.SourceIdentifierText.Location = new System.Drawing.Point(9, 72);
            this.SourceIdentifierText.MaxLength = 10;
            this.SourceIdentifierText.Name = "SourceIdentifierText";
            this.SourceIdentifierText.ReadOnly = true;
            this.SourceIdentifierText.Size = new System.Drawing.Size(120, 20);
            this.SourceIdentifierText.TabIndex = 1;
            // 
            // SourceIdentifierLabel
            // 
            this.SourceIdentifierLabel.AutoSize = true;
            this.SourceIdentifierLabel.Location = new System.Drawing.Point(6, 56);
            this.SourceIdentifierLabel.Name = "SourceIdentifierLabel";
            this.SourceIdentifierLabel.Size = new System.Drawing.Size(84, 13);
            this.SourceIdentifierLabel.TabIndex = 2;
            this.SourceIdentifierLabel.Text = "Source Identifier";
            // 
            // RecordTypeLabel
            // 
            this.RecordTypeLabel.AutoSize = true;
            this.RecordTypeLabel.Location = new System.Drawing.Point(6, 16);
            this.RecordTypeLabel.Name = "RecordTypeLabel";
            this.RecordTypeLabel.Size = new System.Drawing.Size(69, 13);
            this.RecordTypeLabel.TabIndex = 1;
            this.RecordTypeLabel.Text = "Record Type";
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.Location = new System.Drawing.Point(597, 256);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(136, 23);
            this.AddTransactionButton.TabIndex = 32;
            this.AddTransactionButton.Text = "Add New Transaction";
            this.AddTransactionButton.UseVisualStyleBackColor = true;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddPaymentButton_Click);
            // 
            // TransactionsListbox
            // 
            this.TransactionsListbox.FormattingEnabled = true;
            this.TransactionsListbox.Location = new System.Drawing.Point(12, 256);
            this.TransactionsListbox.Name = "TransactionsListbox";
            this.TransactionsListbox.Size = new System.Drawing.Size(579, 264);
            this.TransactionsListbox.TabIndex = 1;
            // 
            // DeleteTransactionButton
            // 
            this.DeleteTransactionButton.Location = new System.Drawing.Point(597, 285);
            this.DeleteTransactionButton.Name = "DeleteTransactionButton";
            this.DeleteTransactionButton.Size = new System.Drawing.Size(136, 23);
            this.DeleteTransactionButton.TabIndex = 33;
            this.DeleteTransactionButton.Text = "Delete Transaction";
            this.DeleteTransactionButton.UseVisualStyleBackColor = true;
            this.DeleteTransactionButton.Click += new System.EventHandler(this.DeleteTransactionButton_Click);
            // 
            // ExportFile
            // 
            this.ExportFile.Location = new System.Drawing.Point(597, 497);
            this.ExportFile.Name = "ExportFile";
            this.ExportFile.Size = new System.Drawing.Size(136, 23);
            this.ExportFile.TabIndex = 34;
            this.ExportFile.Text = "Export to File";
            this.ExportFile.UseVisualStyleBackColor = true;
            this.ExportFile.Click += new System.EventHandler(this.ExportFile_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.CheckFileExists = true;
            this.SaveFileDialog.DefaultExt = "txt";
            this.SaveFileDialog.Title = "Save NAB Multi-Account File";
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // NABCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 537);
            this.Controls.Add(this.ExportFile);
            this.Controls.Add(this.DeleteTransactionButton);
            this.Controls.Add(this.TransactionsListbox);
            this.Controls.Add(this.AddTransactionButton);
            this.Controls.Add(this.grbCurrentRecord);
            this.MaximizeBox = false;
            this.Name = "NABCreator";
            this.Text = "NAB Multi-Account Files";
            this.Load += new System.EventHandler(this.NABCreator_Load);
            this.grbCurrentRecord.ResumeLayout(false);
            this.grbCurrentRecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private NABFile File;
        private Transaction CurrentTransaction;

        private System.Windows.Forms.GroupBox grbCurrentRecord;
        private System.Windows.Forms.Label RecordTypeLabel;
        private System.Windows.Forms.Label SourceIdentifierLabel;
        private System.Windows.Forms.TextBox SourceIdentifierText;
        private System.Windows.Forms.TextBox TransactionReferenceNumberText;
        private System.Windows.Forms.Label TransactionReferenceNumberLabel;
        private System.Windows.Forms.ComboBox PaymentInstructionList;
        private System.Windows.Forms.Label PaymentInstructionLabel;
        private System.Windows.Forms.TextBox ErrorCorrectionReasonText;
        private System.Windows.Forms.Label ErrorCorrectionReasonLabel;
        private System.Windows.Forms.ComboBox PaymentChannelList;
        private System.Windows.Forms.Label TransactionReferenceNumber2Label;
        private System.Windows.Forms.Label PaymentDateLabel;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.DateTimePicker PaymentTimePicker;
        private System.Windows.Forms.Label PaymentTimeLabel;
        private System.Windows.Forms.DateTimePicker PaymentDatePicker;
        private System.Windows.Forms.TextBox SettlementDateText;
        private System.Windows.Forms.Label SettlementDateLabel;
        private System.Windows.Forms.Label TransactionReferenceNumber3Label;
        private System.Windows.Forms.TextBox AuthorizationCodeText;
        private System.Windows.Forms.Label AuthorizationCodeLabel;
        private System.Windows.Forms.TextBox BankTransactionIDText;
        private System.Windows.Forms.Label BankTransactionIDLabel;
        private System.Windows.Forms.TextBox OriginalReferenceText;
        private System.Windows.Forms.Label OriginalReferenceLabel;
        private System.Windows.Forms.TextBox TransactionReferenceNumber3Text;
        private System.Windows.Forms.Button SaveTransactionButton;
        private System.Windows.Forms.Button AddTransactionButton;
        private System.Windows.Forms.TextBox RecordTypeText;
        private System.Windows.Forms.ListBox TransactionsListbox;
        private System.Windows.Forms.Button DeleteTransactionButton;
        private System.Windows.Forms.Button ExportFile;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

