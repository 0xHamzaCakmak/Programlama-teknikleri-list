using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_list_int_tipli
{
    //ktg 10 adet sayıyı 1 liste doldurup sıralayan metodu yazınız.
    class Program
    {
        static List<int> Listsirala(List<int>a)
        { a.Sort();        return a;       }
        static void yaz(List<int> b)
        {
            foreach (int i in b)
                Console.Write(" " + i);
        }
        
        static void Main(string[] args)
        {
            List<int> gs = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
                gs.Add(r.Next(50));
            yaz(Listsirala(gs));

        }
    }
}
