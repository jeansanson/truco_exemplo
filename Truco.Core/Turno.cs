using Truco.Core.Equipes;

namespace Truco.Core.Cartas
{
    public class Turno
    {

        private readonly Carta _vira;
        private readonly Rotacao _rotacao;

        public Turno(Partida partida)
        {
            _rotacao = new Rotacao(partida);

            // distribui cartas
            partida.Baralho.Embaralhar();

            List<Jogador> jogadores = new();
            while (jogadores.All(jogador => !jogador.MaoCheia))
            {
                Jogador jogador = _rotacao.SelecionarProximo();
                if (!jogadores.Contains(jogador))
                {
                    jogadores.Add(jogador);
                }
                jogador.ReceberCarta(partida.Baralho.Dequeue());
            }

            // seleciona carta especial
            _vira = partida.Baralho.Dequeue();
        }

    }
}