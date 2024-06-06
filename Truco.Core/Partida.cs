using Truco.Core.Equipes;

namespace Truco.Core.Cartas
{
    public class Partida
    {
        private Turno _turno;

        public Partida(Equipe aliados, Equipe adversarios)
        {
            Aliados = aliados;
            Adversarios = adversarios;
            Baralho = new();
            ValidaModosConflitantes();
            _turno = new Turno(this);
        }

        public Equipe Aliados { get; }

        public Equipe Adversarios { get; }

        public Baralho Baralho { get; }

        public ModoEquipe Modo { get { return Aliados.Modo; } }

        private void ValidaModosConflitantes()
        {
            if (Aliados.Modo == Adversarios.Modo) return;
            throw new InvalidOperationException("Quantidade de jogadores dos times não podem ser diferentes.");
        }
    }
}