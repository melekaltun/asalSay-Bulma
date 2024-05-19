internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("birinci sayı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayı değerini giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int asalSayisi = 0;


            if (sayi1 == 1)
            {
                sayi1++;
            }

            if (sayi1 > sayi2)
            {
                int k = sayi1;
                sayi1 = sayi2;
                sayi2 = k;
            }

            for (int i = sayi1; i <= sayi2; i++)
            {
                asalSayisi = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        asalSayisi++;
                    }
                }
                if (asalSayisi == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("sınır değerini aştınız.");
        }
    }
}