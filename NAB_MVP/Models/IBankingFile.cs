using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAB_MVC.Models
{
    public interface IBankingFile
    {
        event EventHandler NewTransactionAdded;

        int Count { get; }
        int Index { get; set; }
        List<string> TransactionList { get; }

        void Add();
        void Remove(int index);
        Transaction this [int index] {get; set;}

        List<string> PaymentInstructionsList { get; }
        List<string> PaymentChannelsList { get; }

        string GetPaymentInstructionDescription(string code);
        string GetPaymentChannelDescription(string code);
        string GetPaymentInstructionCode(string desc);
        string GetPaymentChannelCode(string desc);
        void SaveToFile(string path);

    }
}
