using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Interface
{
    internal interface ITransfer :IBankaHesap
    {
        bool TransferYap(IBankaHesap aliciHesap, decimal miktar);
    }
}
