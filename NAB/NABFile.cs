using System;
using System.Collections.Generic;
using System.IO;

namespace NAB
{
    class NABFile
    {
        private List<Transaction> transactions;
        private string header= "00     NTA08";
        private string trailer= "99     NTA08";
        private int currentTransactionIndex;

        public NABFile()
        {
            transactions = new List<Transaction>();
        }

        public void SaveToFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(header.PadLeft(219,' '));
            foreach (var t in transactions)
            {
                file.WriteLine(t.ToString());
            }
            file.WriteLine(trailer.PadLeft(219, ' '));
        }

        public List<string> ExportToList()
        {
            List<string> result = new List<string>();
            foreach (Transaction t in transactions)
            {
                result.Add(t.ToString());
            }
            return result;
        }

        public  int AddTransaction (Transaction t)
        {
            transactions.Add(t);
            currentTransactionIndex = transactions.Count - 1;
            return currentTransactionIndex;
        }

        public int DeleteTransaction(int index)
        {
            if (transactions.Count>0 & index>=0)
            {
                transactions.RemoveAt(index);
                return transactions.Count - 1;
            }
            else
            {
                return -1;
            }     
        }

        public int UpgradeTransaction(int index, Transaction t)
        {
            try
            {
                transactions[index] = t;
            }
            catch (Exception)
            {

                throw new ArgumentOutOfRangeException(index.ToString(), "Out of range in NAB File Transaction list");
            }
            return 0;
        }

        public int UpgradeCurrentTransaction(Transaction t)
        {
            UpgradeTransaction(currentTransactionIndex, t);
            return 0;
        }
    }
}
