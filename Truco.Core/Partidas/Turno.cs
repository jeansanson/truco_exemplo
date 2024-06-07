using Truco.Core.Cartas;
using Truco.Core.Equipes;

namespace Truco.Core.Partidas
{
    public class Turno
    {

        private readonly Carta _vira;
        private readonly Rotacao _rotacao;
        private readonly ContextoInterno _contexto;

        public Turno(ContextoInterno contexto)
        {
            _contexto = contexto;
            _rotacao = new Rotacao(contexto.Partida);
            _contexto.EventosInternos.DistribuirCartas(_contexto.Baralho, _rotacao);
            _vira = _contexto.Baralho.Dequeue();
        }

        public Rotacao Rotacao { get { return _rotacao; } }

    }
}