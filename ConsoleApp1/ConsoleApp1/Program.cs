using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto

            Pessoa p = new Pessoa();
            p.peso = 100.00;
            p.altura = 1.70;
            p.Mensagem();

            Console.ReadLine();
        }
    }
}
