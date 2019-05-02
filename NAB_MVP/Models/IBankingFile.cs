using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAB_MVC.Models
{
    public interface IBankingFile
    {
        int Count { get; }
        void Add(Transaction transaction);
        void Remove(int index);
        Transaction this [int index] {get; set;}

        List<string> GetPaymentInstructionsList();
        List<string> GetPaymentChannelsList();

        decimal TotalTransactionAmount();
        void SaveToFile(string path);
        List<string> ExportToList();
    }
}
