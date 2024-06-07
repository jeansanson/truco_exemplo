using Truco.Core.Cartas;
using Truco.Core.Equipes;
using Truco.Core.Eventos;

namespace Truco.Core.Partidas
{
    public class Partida
    {
        private ContextoInterno _contextoInterno;

        public Partida(Equipe aliados, Equipe adversarios, EventosExternos eventosExternos)
        {
            Aliados = aliados;
            Adversarios = adversarios;
            EventosInternos eventosInternos = new(eventosExternos);
            _contextoInterno = new(this, new Baralho(), eventosInternos);
            _contextoInterno.InicializaNovoTurno();
        }

        public Equipe Aliados { get; }

        public Equipe Adversarios { get; }

        public ModoEquipe Modo { get { return Aliados.Modo; } }

    }
}