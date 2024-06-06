namespace Truco.Core.Cartas
{
    public class Carta
    {
        public Carta(Valor valor, Naipe naipe)
        {
            Valor = valor;
            Naipe = naipe;
        }

        public readonly Valor Valor;

        public readonly Naipe Naipe;

        public override string ToString()
        {
            return $"{Valor} De {Naipe}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Carta carta &&
                   Valor == carta.Valor &&
                   Naipe == carta.Naipe;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Valor, Naipe);
        }

        //public bool MaisForteQue(Carta carta)
        //{
        //    bool valorMaisForte = Valor.MaisForteQue(carta.Valor);
        //    if (valorMaisForte) return true;
        //    return Naipe.MaisForteQue(carta.Naipe);
        //}
    }
}