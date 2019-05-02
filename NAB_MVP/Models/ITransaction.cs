using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAB_MVC.Models
{
    public interface ITransaction
    {
        decimal Amount { get; set; }
    }
}
