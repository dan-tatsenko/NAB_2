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
        public event EventHandler NewTransactionAdded;

        private List<Transaction> transactionList;


        public int Index { get; set; }
        public int Count => transactionList.Count;

        public List<string> TransactionList
        {
            get
            {
                List<string> result = new List<string>();
                foreach (var item in transactionList)
                {
                    result.Add(item.ToString());
                }
                return result;
            }
        }

        public List<string> PaymentInstructionsList
        {
            get
            {
                List<string> list = new List<string>();
                foreach (KeyValuePair<string, string> keyValue in PaymentInstructions)
                {
                    list.Add(keyValue.Value);
                }
                return list;
            }
        }

        public List<string> PaymentChannelsList
        {
            get
            {
                List<string> list = new List<string>();
                foreach (KeyValuePair<string, string> keyValue in PaymentChannels)
                {
                    list.Add(keyValue.Value);
                }
                return list;
            }
        }

        public BankingFile()
        {
            transactionList = new List<Transaction>();
            Index = -1;
        }

        public Transaction this[int index]
        {
            get => transactionList[index];
            set => transactionList[index] = value;
        }

        public void Add ()
        {
            transactionList.Add(new Transaction());
            Index = Count - 1;
            NewTransactionAdded(this, EventArgs.Empty);
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < Count)
            {
                Index = index;

                if (index==Count-1) //Unlese we delete last element
                {
                    Index = index - 1; //new index will be 1 less
                }
                transactionList.RemoveAt(index);
            }
        }

        public void SaveToFile(string path)
        {
            FileStream f = File.Create(path);
            f.Close();
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                sw.WriteLine(FileHeader());
                foreach (string line in TransactionList)
                {
                    //sw.WriteLine(line.Remove(13,1).Insert(31,"0"));
                    sw.WriteLine(line);
                } 
                sw.WriteLine(FileTrailer());
            }
        }

        private string FileHeader()
        {
            string header = "";
            header += "00";
            header += "NTA08".PadLeft(10);
            header += "FUTURE".PadRight(20);
            header += "085933".PadRight(6);
            header += "742637203".PadRight(9);
            header += DateTime.Today.Year.ToString().PadRight(4,'0');
            header += DateTime.Today.Month.ToString().PadRight(2, '0');
            header += DateTime.Today.Day.ToString().PadRight(2, '0');
            header += DateTime.Today.Hour.ToString().PadRight(2, '0');
            header += DateTime.Today.Minute.ToString().PadRight(2, '0');
            header += DateTime.Today.Second.ToString().PadRight(2, '0');
            header += "SETT101".PadRight(10);
            header += "".PadRight(148);
            return header;
        }

        private string FileTrailer()
        {
            string trailer = "";
            trailer += "99";
            trailer += "NTA08".PadLeft(10);

            int n = 0;
            foreach (Transaction t in transactionList)
            {
                if (t.PaymentInstruction=="05")
                {
                    n++;
                }
            }
            trailer += n.ToString().PadLeft(9,'0');

            int s = 0;
            foreach (Transaction t in transactionList)
            {
                if (t.PaymentInstruction == "05")
                {
                    s += t.Amount;
                }
            }
            trailer += s.ToString().PadLeft(15, '0');

            trailer += "0".PadRight(9, '0');
            trailer += "0".PadRight(15, '0');

            foreach (Transaction t in transactionList)
            {
                if (t.PaymentInstruction == "15" || t.PaymentInstruction == "25" || t.PaymentInstruction == "35")
                {
                    n++;
                }
            }
            trailer += n.ToString().PadLeft(9, '0');

            foreach (Transaction t in transactionList)
            {
                if (t.PaymentInstruction == "15" || t.PaymentInstruction == "25" || t.PaymentInstruction == "35")
                {
                    s += t.Amount;
                }
            }
            trailer += s.ToString().PadLeft(15, '0');
            trailer += "0".PadRight(15,'0');
            trailer += "".PadRight(120);
            return trailer;
        }

        public string GetPaymentInstructionDescription(string code)
        {
            return PaymentInstructions[code];
        }

        public string GetPaymentChannelDescription (string code)
        {
            return PaymentChannels[code];
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
