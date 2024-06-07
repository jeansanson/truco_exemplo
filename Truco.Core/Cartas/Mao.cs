using Truco.Core.Equipes;

namespace Truco.Core.Cartas
{
    public class Mao : List<Carta>
    {

        public Mao() { }

        public bool Cheia { get { return this.Count >= 3; } }

        public new void Add(Carta carta)
        {
            if (Cheia)
            {
                throw new InvalidOperationException("Jogador não pode receber cartas pois está de mão cheia");
            }
            base.Add(carta);
        }

        public Carta PopAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            Carta r = this[index];
            RemoveAt(index);
            return r;
        }

    }
}