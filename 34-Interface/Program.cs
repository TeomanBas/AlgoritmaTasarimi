using _34_Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        IBankaHesap MevduatHesabi = new MevduatHesabi();
        MevduatHesabi.Yatir(1000);
        MevduatHesabi.Cek(100);
        MevduatHesabi.Cek(500);
        Console.WriteLine(MevduatHesabi.ToString());

        Console.WriteLine(new string('-',50));

        IBankaHesap mevduatHesabi2 = new MevduatHesabi();
        ITransfer aktifHesap = new AktifHesap();
        mevduatHesabi2.Yatir(1000);
        aktifHesap.Yatir(5000);
        aktifHesap.TransferYap(mevduatHesabi2, 200);
        Console.WriteLine(aktifHesap.ToString());
    }
}