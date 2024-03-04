double cifttoplam = 0, tektoplam = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write("{0}. sayıyı girin:", i + 1);
    double sayi = Convert.ToDouble(Console.ReadLine());
    if (sayi % 2 == 0)
        cifttoplam = cifttoplam + sayi;
    else
        tektoplam = tektoplam + sayi;
}
Console.WriteLine("Çiftlerin toplamı={0}\nTeklerin toplamı={1}", cifttoplam, tektoplam);
Console.ReadKey();