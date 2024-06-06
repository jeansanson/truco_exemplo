namespace Truco.Core.Cartas
{
    public enum Naipe
    {
        Ouro = 0,
        Espadas = 1,
        Copas = 2,
        Paus = 3
    }

    public static class NaipeExtensions
    {
        public static bool MaisForteQue(this Naipe atual, Naipe contra)
        {
            return atual > contra;
        }
    }
}