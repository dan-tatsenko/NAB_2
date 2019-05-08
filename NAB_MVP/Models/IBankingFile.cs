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
        int Index { get; set; }
        bool Saved { get; set; }

        void Add();
        void Remove(int index);
        Transaction this [int index] {get; set;}

        List<string> GetPaymentInstructionsList();
        List<string> GetPaymentChannelsList();
        string GetPaymentInstructionDescription(string code);
        string GetPaymentChannelDescription(string code);
        string GetPaymentInstructionCode(string desc);
        string GetPaymentChannelCode(string desc);
        decimal TotalTransactionAmount();
        void SaveToFile(string path);
        List<string> ExportToList();
    }
}
