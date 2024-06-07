using Truco.Core.Cartas;
using Truco.Core.Equipes;

namespace Truco.Core.Eventos
{
    public abstract class EventosExternos
    {

        public static Carta Jogar(Jogador jogador)
        {
            if (jogador.Mao.Count == 0) throw new InvalidOperationException("Jogador não possui cartas pra jogar.");
            Random random = new();
            int index = random.Next(0, jogador.Mao.Count - 1);
            Carta resultado = jogador.Mao.PopAt(index);
            Console.WriteLine($"{jogador} jogou a carta {resultado}");
            return resultado;
        }

        public void JogadorRecebeuCarta(Jogador jogador, Carta carta)
        {
            Console.WriteLine($"{jogador} recebeu a carta {carta}");
        }
    }
}
