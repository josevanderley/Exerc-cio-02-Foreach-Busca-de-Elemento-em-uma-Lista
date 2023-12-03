using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_02_Foreach_Busca_de_Elemento_em_uma_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            {
                
                List<string> palavras = new List<string> { "casa", "carro", "cachorro", "gato" };

                Console.WriteLine("Digite uma palavra:");
                string palavra = Console.ReadLine();

                bool encontrada = false;
                foreach (string p in palavras)
                {
                    if (p == palavra)
                    {
                        encontrada = true;
                        break;
                    }
                }

                if (encontrada)
                {
                    Console.WriteLine("A palavra '" + palavra + "' foi encontrada.");
                }
                else
                {
                    Console.WriteLine("A palavra '" + palavra + "' não foi encontrada.");

                    Console.ReadKey();  
                }
            }
        }
    }
}
   
