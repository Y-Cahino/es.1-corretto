using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._1_corretto
{
    internal class Program
    {
        static void compara(int x, int y)
        {
            if(x<y)
            {
                Console.WriteLine("L'ordine esatto è: "+ x+y);
            }
            else if(x>y)
            {
                Console.WriteLine("L'ordine esatto è:"+y+x);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inseire primo numero: ");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire secondo numero");
            int y=int.Parse(Console.ReadLine());
        }
    }
}
