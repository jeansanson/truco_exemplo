using Truco.Core.Cartas;

namespace Truco.Core.Equipes
{
    public class Jogador
    {

        public Jogador(Convidado convidado, Equipe equipe)
        {
            Nome = convidado.Nome;
            Equipe = equipe;
            Mao = new();
        }

        public string Nome { get; }

        public Equipe Equipe { get; }

        public Mao Mao { get; }

        public override string ToString()
        {
            return Nome;
        }

    }
}