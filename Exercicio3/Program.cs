using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rua> rua = new List<Rua>
            {
                new Rua{Cep = "03282001", Nome = "Rua do Oratorio"},
                new Rua{Cep = "03282002", Nome = "Rua da Mooca"},
                new Rua{Cep = "03282003", Nome = "Avenida Dom Pedro"},
                new Rua{Cep = "03282004", Nome = "Avenida Ibirapuera"},
                new Rua{Cep = "03282005", Nome = "Avenida Ayrton Senna"},
            };

            List<Casa> casa = new List<Casa>()
            {
                new Casa(rua[0], 120, 2),
                new Casa(rua[1], 45, 1),
                new Casa(rua[2], 48, 0),
                new Casa(rua[3], 13, 3),
                new Casa(rua[4], 7, 5),
            };

            List<Rua> ordenado = Ordernar(casa);

            foreach (var order in ordenado)
            {
                Console.WriteLine($"{order.Nome} / {order.Cep} - Número de Crianças : {casa.Find(x => x.Rua.Cep.Equals(order.Cep)).TotalDeCriancas}");
            }

            Console.ReadKey();
        }

        private static List<Rua> Ordernar(List<Casa> casa)
        {
            Dictionary<int, Rua> criancas = new Dictionary<int, Rua>();
            foreach (var casas in casa)
            {
                criancas.Add(casas.TotalDeCriancas, casas.Rua);
            }

            criancas = criancas.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            
            return criancas.Select(x => x.Value).ToList();
        }
    }
}
