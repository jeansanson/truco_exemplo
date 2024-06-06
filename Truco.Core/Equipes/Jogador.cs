using Truco.Core.Cartas;

namespace Truco.Core.Equipes
{
    public class Jogador
    {

        public readonly List<Carta> _cartas = new();

        public Jogador(Convidado convidado, Equipe equipe)
        {
            Nome = convidado.Nome;
            Equipe = equipe;
        }

        public string Nome { get; }

        public Equipe Equipe { get; }

        public bool MaoCheia { get { return _cartas.Count == 3; } }

        public override string ToString()
        {
            return Nome;
        }

        public void ReceberCarta(Carta carta)
        {
            if (MaoCheia)
            {
                throw new InvalidOperationException("Jogador não pode receber cartas pois está de mão cheia");
            }
            _cartas.Add(carta);
        }

    }
}