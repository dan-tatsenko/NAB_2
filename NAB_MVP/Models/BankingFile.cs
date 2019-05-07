using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NAB_MVC.Models
{
    public class BankingFile : IBankingFile
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

        public int Index { get; private set; }
        public int Count => TransactionList.Count;
        public bool Saved { get; set; }

        public BankingFile()
        {
            TransactionList = new List<Transaction>();
            Index = -1;
            Saved = true;
        }

        public Transaction this[int index]
        {
            get => TransactionList[index];
            set => TransactionList[index] = value;
        }

        public void Add ()
        {
            TransactionList.Add(new Transaction());
            Index = Count - 1;
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
                if (Count=1)
                {

                }
            }
        }

        public void SaveToFile(string path)
        {
            FileStream f = File.Create(path);
            f.Close();
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (string line in ExportToList())
                {
                    sw.WriteLine(line);
                }  
            }
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

        public string GetPaymentInstructionDescription(string code)
        {
            return PaymentInstructions[code];
        }

        public string GetPaymentChannelDescription (string code)
        {
            return PaymentChannels[code];
        }

        public List<string> GetPaymentInstructionsList()
        {
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> keyValue in PaymentInstructions)
            {
                list.Add(keyValue.Value);
            }
            return list;
        }

        public List<string> GetPaymentChannelsList()
        {
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> keyValue in PaymentChannels)
            {
                list.Add(keyValue.Value);
            }
            return list;
        }

        public string GetPaymentInstructionCode(string desc)
        {
            return PaymentInstructions.FirstOrDefault(x => x.Value == desc).Key;
        }

        public string GetPaymentChannelCode(string desc)
        {
            return PaymentChannels.FirstOrDefault(x => x.Value == desc).Key;
        }
    }
}
