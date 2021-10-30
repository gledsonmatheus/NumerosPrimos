using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = false;
            string escolha = "";
            int num = 0, resto;


            do
            {
                resto = 0;
                try
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------verificar números primos--------------------------");
                    Console.WriteLine("digite um valor para descobrir de e um numero primo. (valores inteiro)");
                    num = int.Parse(Console.ReadLine());
                    if (num > 1)
                    {
                        for (int i = 2; i < num; i++)
                        {
                            if (i != num && num % i == 0)
                            {
                                resto += 1;
                            }

                        }
                    }
                    if (resto >= 1)
                    {
                        Console.WriteLine("O número não é primo. ");
                    }
                    else
                    {
                        Console.WriteLine("O número é primo. ");
                    }


                }
                finally
                {
                    Console.WriteLine("deseja verificar outro numero ? (s/n)");
                    escolha = Console.ReadLine();

                    if (escolha.ToLower() == "s") { continua = true; }
                }
            } while (continua);
            Console.WriteLine("digite qualquer tecla para sair.");
            Console.ReadLine();

        }
    }
}
