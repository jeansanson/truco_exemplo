using Truco.Core.Cartas;
using Truco.Core.Equipes;
using Truco.Core.Partidas;

namespace Truco.Core.Eventos
{
    public class EventosInternos
    {
        private readonly EventosExternos _externos;

        public EventosInternos(EventosExternos eventos)
        {
            _externos = eventos;
        }

        public void DistribuirCartas(Baralho baralho, Rotacao rotacao)
        {
            baralho.Embaralhar();
            List<Jogador> jogadores = new();
            while (jogadores.All(jogador => !jogador.Mao.Cheia))
            {
                Jogador jogador = rotacao.SelecionarProximo();
                if (!jogadores.Contains(jogador))
                {
                    jogadores.Add(jogador);
                }
                Carta carta = baralho.Dequeue();
                jogador.Mao.Add(carta);
                _externos.JogadorRecebeuCarta(jogador, carta);
            }
        }
    }
}
