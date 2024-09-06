using System;

namespace ALISVERISOTOMOSYONU
{
    class Program
    {
        static int hesap = 0;
        static void hesapode(int hesap)
        {

            Console.WriteLine("Ödeyeceğiniz hesap...: " +hesap+ "TL");

        }
        static void eklenen(int eklenen) 
        {
            hesap = hesap + eklenen;        
        }
        static void Main(string[] args)
        { int secim;
            do
            {
                Console.WriteLine("**************ANA MENÜ***************");
                Console.WriteLine("1-Tavuk Dürüm...: 15TL");
                Console.WriteLine("2-Et Dürüm...: 20TL");
                Console.WriteLine("3-Ayran..: 5TL");
                Console.WriteLine("4-Şalgam..: 5TL");
                Console.WriteLine("5-Sipariş İptal");
                Console.WriteLine("6-Hesap İste");
                Console.WriteLine("_______________________________________________________");
                Console.WriteLine("Lütfen seçmek istediğiniz seçeneğin numarasını giriniz");
                 secim = Convert.ToInt32(Console.ReadLine());

                if (secim==1)
                {
                    eklenen(15);
                    Console.WriteLine("______________________");
                    Console.WriteLine("Tavuk Dürüm Eklediniz");
                    Console.WriteLine("______________________");
                }
                else if (secim==2)
                {
                    eklenen(20);
                    Console.WriteLine("______________________");
                    Console.WriteLine("Et Dürüm eklediniz");
                    Console.WriteLine("______________________");
                }
                else if (secim==3)
                {
                    eklenen(5);
                    Console.WriteLine("______________________");
                    Console.WriteLine("Ayran eklediniz");
                    Console.WriteLine("______________________");
                }
                else if (secim==4)
                {
                    eklenen(5);
                    Console.WriteLine("Şalgam eklediniz");
                }
                else if (secim==5)
                {
                    Console.WriteLine("______________________");
                    Console.WriteLine("Siparişiniz iptal edildi");
                    Console.WriteLine("______________________");
                    break;             
                }
                else if (secim==6)
                {
                    Console.WriteLine("______________________");
                    hesapode(hesap);

                }
                else
                {
                    break;
                }





            } while (secim!=6);

            Console.ReadKey();
        }
        
    }
}
