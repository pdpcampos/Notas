using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1N2ComandoRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int resultado;
            do
            {
                Console.WriteLine("Digite sua primeira nota de 0 a 10");
                n1 = int.Parse(Console.ReadLine());

            }

            while (n1 > 10);


            do
            {
                Console.WriteLine("Digite sua segunda nota de 0 a 10");
                n2 = int.Parse(Console.ReadLine());
            }

            while (n2 > 10);

            resultado = (n1 + n2) / 2;

            if (resultado >= 7)
            {
                Console.WriteLine ("Aluno reprovado");
            }

            else
            {
                Console.WriteLine ("aluno reprovado");       
             
              }




            Console.WriteLine("O seu resultado final foi:  " + resultado);
            Console.ReadLine();
        }
    }
}
