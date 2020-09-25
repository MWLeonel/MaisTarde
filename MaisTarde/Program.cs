using System;
using System.Runtime.InteropServices;

namespace MaisTarde
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime horaAtual;
            DateTime noite;

            string horaCurta;
            string noiteCurta;

            horaAtual = DateTime.Now;
            horaCurta = horaAtual.ToShortTimeString();
            Console.WriteLine("Hora Atual");
            Console.WriteLine(horaCurta);
            Console.Write("\n");

            noite = horaAtual.AddHours(6).AddMinutes(30);
            noiteCurta = noite.ToShortTimeString();
            Console.WriteLine("Mais Tarde");
            Console.WriteLine(noiteCurta);
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
