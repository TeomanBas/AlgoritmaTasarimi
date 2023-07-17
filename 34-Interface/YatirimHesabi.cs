using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Interface
{
    internal class YatirimHesabi : IBankaHesap
    {
        private decimal _Bakiye;
        public decimal Bakiye => _Bakiye;

        public bool Cek(decimal miktar)
        {
            if(_Bakiye >= miktar)
            {
                _Bakiye -= miktar;
                return true;
            }
            Console.WriteLine("yetersiz bakiye");
            return false;
        }

        public void Yatir(decimal miktar)
        {
            _Bakiye += miktar;
        }
        public override string ToString() => $"yaritim hesabı bakiyesi {_Bakiye,6:C}";
    }
}
