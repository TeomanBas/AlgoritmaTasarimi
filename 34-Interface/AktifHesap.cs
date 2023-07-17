using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Interface
{
    public class AktifHesap : ITransfer
    {
        private decimal _Bakiye;
        public decimal Bakiye => _Bakiye;

        public bool Cek(decimal miktar)
        {
            if (_Bakiye >= miktar)
            {
                _Bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\abakiye yetersiz");
            return false;
        }

        public void Yatir(decimal miktar)
        {
            _Bakiye += miktar;
        }

        bool ITransfer.TransferYap(IBankaHesap aliciHesap, decimal miktar)
        {
            bool sonuc = Cek(miktar);
            if (sonuc)
            {
                aliciHesap.Yatir(miktar);
            }
            return sonuc;
        }
        public override string ToString() => $"Aktif Hesap bakiye bilgisi {_Bakiye,6:C}";
    }
}
