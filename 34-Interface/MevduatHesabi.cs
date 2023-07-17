using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Interface
{
    public class MevduatHesabi : IBankaHesap
    {
        private decimal _Bakiye;

        decimal IBankaHesap.Bakiye => _Bakiye;

        public bool Cek(decimal miktar)
        {
            if (_Bakiye >= miktar)
            {
                _Bakiye -= miktar;
                return true;
            }
            Console.WriteLine("bakiye yetersiz");
            return false;
        }

        public void Yatir(decimal miktar)
        {
            _Bakiye += miktar;
        }

        public override string? ToString() => $"Mevduat hesabi bakiye bilgisi {_Bakiye,6:C}";

    }
}
