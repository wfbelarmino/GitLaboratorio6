using System;

namespace Laboratorio6
{
    class Program
    {
        private const int V = 1;

        static void Main(string[] args) 
        {
            Banco banco = new Banco();
            
            Pessoa a = new(1200);

            banco.AddConta(a);

            Conta money = a.Money;
            Console.WriteLine("Pessoa: " + a.Nome + " Tem" + a.Money.Valor);
            banco.Depositar(a, 568);

            Console.WriteLine("Pessoa: " + a.Nome + " Tem" + a.Money.Valor);
            Console.ReadKey();           
        }
    }
}
