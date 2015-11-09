using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraCSharpTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextReader leitor = Console.In;
            //string linha = leitor.ReadLine();
            string linha = Console.ReadLine();
            while (linha != null)
            {
                Console.WriteLine("Linha: " + linha);
                //linha = leitor.ReadLine();
                linha = Console.ReadLine();
            }
            Console.WriteLine("Pressionado Ctrl + Z");
        }
    }
}
