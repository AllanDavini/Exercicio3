using System.Collections.Generic;

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
            
            Dictionary<Casa, Rua> vacina = new Dictionary<Casa, Rua>();
        }
    }
}
