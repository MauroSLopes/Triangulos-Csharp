using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulosConsole
{
    public class Triangulos
    {

        public int lado { get; set; }

        public Triangulos() 
        {
            Console.Write("Digite a altura do triangulo desejado: ");
            this.lado = Convert.ToInt32(Console.ReadLine());
        }
        public void calcularEqui()
        {
            for (int i = 1; i <= lado; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= lado; i++)
            {
                for (int j = lado; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void calcularDiferente()
        {
            for (int i = 1; i <= lado; i++)
            {
                for (int j = 0; j < ((i*2)-1); j++)
                { 
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void calcularRet()
        {
            for(int i = 1; i <= lado; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
