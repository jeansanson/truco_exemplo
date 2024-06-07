using Truco.Core.Cartas;
using Truco.Core.Equipes;
using Truco.Core.Eventos;

namespace Truco.Core.Partidas
{
    public class ContextoInterno
    {
        public ContextoInterno(
            Partida partida,
            Baralho baralho,
            EventosInternos eventosInternos
            )
        {
            Partida = partida;
            Baralho = baralho;
            EventosInternos = eventosInternos;
            Turnos = new List<Turno>();
        }

        public Partida Partida { get; }

        public Baralho Baralho { get; }

        public EventosInternos EventosInternos { get; }

        public List<Turno> Turnos { get; }

        public void InicializaNovoTurno()
        {
            Turnos.Add(new Turno(this));
        }

        public Turno TurnoAtual()
        {
            if (Turnos.Count == 0)
            {
                InicializaNovoTurno();
            }
            return Turnos.Last();
        }

    }
}