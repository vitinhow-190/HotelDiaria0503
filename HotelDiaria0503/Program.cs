using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDiaria0503
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Informe o valor da diaria do hotel: ");
            int ValorDiaria = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de adultos que se hospedarão: ");
            int adultos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de crianças que se hospedarão: ");
            int criancas = int.Parse(Console.ReadLine());

            ValorDiaria = (ValorDiaria * adultos) + (ValorDiaria / 2) * criancas;

            Console.WriteLine("O valor por dia da familia sera de: " +  ValorDiaria.ToString("C"));
            Console.ReadKey();

            Console.WriteLine("Informe quantos dias de hospedajem vc deseja: ");
            int dias = int.Parse(Console.ReadLine());

            dias = ValorDiaria * dias;

            Console.WriteLine("O valor total da hospedajem é de: " + dias.ToString("C"));
            Console.ReadKey();

            Console.WriteLine("Informe o valor total de parcelas desejadas: ");
            int parcelas = int.Parse(Console.ReadLine());

            dias = dias / parcelas;

            Console.WriteLine("O valor de cada parcela é de: " + dias.ToString("C"));
            Console.ReadKey();



        }
    }
}
