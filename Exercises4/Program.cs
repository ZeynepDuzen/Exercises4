using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ise girmek için gerekenler ile ilgili kod blogu
            //yas 18' den kucuk ise basa don
            //yas >= 18 ise mezuniyet durumu girilsin
            //mezuniyet lisans degil ise basa don
            //mezuniyet lisans ise tebrik et,sertifika sor
            //sertifika var ise tebrik et ve ise alındıgını soyle
            //sertifika yok ise basa don

            
            int yas;
            string mezuniyet;
            string certficate;

            git:
            Console.WriteLine("Lütfen yasinizi girin : ");
            yas = Convert.ToInt32(Console.ReadLine());

            if (yas >= 18)
            {
                Console.WriteLine("Lütfen mezuniyet durumunuzu giriniz : ");
                mezuniyet = Console.ReadLine();
                if (mezuniyet == "lisans")
                {
                    Console.WriteLine("Tebrikler,gecerli bir lisans durumuna sahipsiniz");
                    Console.WriteLine("Yazılım sertifikanız : var/yok");
                    string sertificate = Console.ReadLine();
                    if (sertificate == "var")
                    {
                        Console.WriteLine("Tebrikler,ise alındınız");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen setifika için de gayret edin");
                        Console.WriteLine("Basa donmek ister misiniz? <e/h>");
                        char cevap3 = Convert.ToChar(Console.ReadLine());
                        if(cevap3 == 'E' || cevap3 == 'e')
                        {
                            Console.Clear();
                            goto git;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Gecerli bir mezuniyete sahip degilsiniz");
                    Console.WriteLine("Tekrar denemek ister misiniz ? <e/h>");
                    char cevap2 = Convert.ToChar(Console.ReadLine());

                    if (cevap2== 'e' || cevap2 == 'E')
                    {
                        Console.Clear();
                        goto git;
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Yasınız 18' den kucuk oldugu için basvuru yapamazsınız");
                Console.WriteLine("Tekrar denemek ister misiniz? <e/h>");
                char cevap = Convert.ToChar( Console.ReadLine());
                if (cevap == 'E' || cevap == 'e')
                {
                    Console.Clear();
                    goto git;
                }
            }

            Console.Read();
        }
    }
}
