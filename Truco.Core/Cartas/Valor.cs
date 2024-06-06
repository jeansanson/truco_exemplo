namespace Truco.Core.Cartas
{
    public enum Valor
    {
        Quatro = 0,
        Cinco = 1,
        Seis = 2,
        Sete = 3,
        Rainha = 4,
        Valete = 5,
        Rei = 6,
        As = 7,
        Dois = 8,
        Tres = 9
    }

    public static class ValorExtensions
    {
        public static bool MaisForteQue(this Valor atual, Valor contra)
        {
            return atual > contra;
        }
    }
}