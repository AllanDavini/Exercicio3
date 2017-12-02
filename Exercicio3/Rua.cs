using System.Collections.Generic;
using System.Linq;

namespace Exercicio3
{
    public class Rua
    {
        public string Cep { get; set; }
        public string Nome { get; set; }

        public static List<Rua> Ordenar(List<Casa> casa)
        {
            Dictionary<Casa, Rua> criancas = new Dictionary<Casa, Rua>();
            foreach (var casas in casa)
            {
                criancas.Add(casas, casas.Rua);
            }
            criancas.OrderByDescending(x => x.Key.TotalDeCriancas);

            return criancas.Select(x => x.Value).ToList();
        }
    }
}