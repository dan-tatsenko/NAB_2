using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAB_MVC.Models
{
    public class NABFile : IBankingFile
    {
        private List<Transaction> TransactionList;
        private bool CurrentTransactionSaved;
        private int CurrentTransactionIndex;
        public int Count => TransactionList.Count;

        public NABFile()
        {
            TransactionList = new List<Transaction>();
            CurrentTransactionIndex = -1;
        }

        public Transaction this[int index]
        {
            get => TransactionList[index];
            set => TransactionList[index] = value;
        }

        public event EventHandler TransactionAdded;
        public event EventHandler TransactionDeleted;
        public event EventHandler TransactionChanged;

        public void Add(Transaction transaction)
        {
            TransactionList.Add(transaction);
            TransactionAdded(this, new EventArgs());
            CurrentTransactionSaved = false;
        }

        public List<string> ExportToList()
        {
            List<string> result = new List<string>();
            foreach (var item in TransactionList)
            {
                result.Add(item.ToString());
            }
            return result;
        }

        public void Remove(int index)
        {
            if (index>=0 && index<Count)
            {
                TransactionList.RemoveAt(index);
                TransactionDeleted(this, new EventArgs());
            }
        }

        public void SaveToFile(string path)
        {
            throw new NotImplementedException();
        }

        public decimal TotalTransactionAmount()
        {
            decimal r = 0;
            foreach (var t in TransactionList)
            {
                r += t.Amount;
            }
            return r;
        }

        public List<string> GetPaymentInstructionsList()
        {
            List<string> list = new List<string>();
            list.Add("05 - Payment");
            list.Add("25 - Refund");
            list.Add("35 - Chargeback");
            return list;
        }

        public List<string> GetPaymentChannelsList()
        {
            List<string> list = new List<string>();
            list.Add("PBW - WEB Payments");
            list.Add("IVR - Interactive Voice Response");
            list.Add("BPY - Bank Payment");
            list.Add("DPP - Direct Post Payment");
            return list;
        }
    }
}
