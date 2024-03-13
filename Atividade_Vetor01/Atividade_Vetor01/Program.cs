using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Vetor01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[20];
            int i;
            for (i = 0; i < Numeros.Length; i++)
            {
                Numeros[i] = i + 1;
                Console.WriteLine(Numeros[i]);
            }
            Console.ReadKey();
        }
    }
}
