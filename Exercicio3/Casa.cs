namespace Exercicio3
{
    public class Casa
    {
        public Casa(Rua rua, int numero, int totalDeCriancas)
        {
            Rua = rua;
            Numero = numero;
            TotalDeCriancas = totalDeCriancas;
        }

        public Rua Rua { get; set; }
        public int Numero { get; set; }
        public int TotalDeCriancas { get; set; }
        
    }
}