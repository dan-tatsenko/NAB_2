using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAB_MVC.Models
{
    public class NABFile : IBankingFile
    {
        private Dictionary<string, string> PaymentInstructions = new Dictionary<string, string>
        {
            ["05"] = "05 - Payment",
            ["25"] = "25 - Refund",
            ["35"] = "35 - Chargeback"
        };
        private Dictionary<string, string> PaymentChannels = new Dictionary<string, string>
        {
            ["PBW"] = "PBW - WEB Payments",
            ["IVR"] = "IVR - Interactive Voice Response",
            ["BPY"] = "BPY - Bank Payment",
            ["DPP"] = "DPP - Direct Post Payment",
        };

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

        public void Add(Transaction transaction)
        {
            TransactionList.Add(transaction);
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
                CurrentTransactionIndex = Count - 1;
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
            foreach (string code in PaymentInstructions.Keys)
            {
                list.Add(PaymentInstructions.[code]);
            }
            return list;
        }

        public List<string> GetPaymentChannelsList()
        {
            List<string> list = new List<string>();
            foreach (string code in PaymentChannels.Keys)
            {
                list.Add(PaymentChannels.[code]);
            }
            return list;
        }
    }
}
