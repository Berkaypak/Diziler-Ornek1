using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_Örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("ELEMAN SAYISINI KULLANICININ BELİRLEDİĞİ BİR DİZİYİ RASTGELE SAYILARLA DOLDURUP SAYILARIN EN BÜYÜĞÜNÜ VE EN KÜÇÜĞÜNÜ BULAN PROGRAM");
         Console.WriteLine("---------------------------------------");
         Console.Write("ELEMAN SAYISINI GİRİNİZ : ");
         int es = Convert.ToInt32(Console.ReadLine());
         int[] dz = new int[es];
         Random r = new Random();
         int b = 0; int k = 0; int j = 1;
        for (int i = 0; i < es; i++)
            {
         dz[i] = r.Next(100);
         for (; j < 2; j++)
                {
         k = dz[i];  // dizinin ilk elemanı döngü içinde belli olduğu için tek tur atan bir döngüye ihtiyaç duyuldu.
                }
         Console.WriteLine("DİZİNİN ELEMANLARI : " + dz[i]);
         if (dz[i] > b) b = dz[i];
         if (dz[i] < k) k = dz[i];
            }
         Console.WriteLine("DİZİNİN EN BÜYÜK SAYISI : {0}", b);
         Console.WriteLine("DİZİNİN EN KÜÇÜK SAYISI : {0}", k);
         Console.ReadLine();


        }
    }
}
