using Truco.Core.Equipes;
using Truco.Core.Partidas;

namespace Truco.Core.Cartas
{
    public class Baralho : Queue<Carta>
    {

        public Baralho()
        {
            Array naipes = Enum.GetValues(typeof(Naipe));
            Array valores = Enum.GetValues(typeof(Valor));
            foreach (Naipe naipe in naipes)
            {
                foreach (Valor valor in valores)
                {
                    Carta carta = new(valor, naipe);
                    Enqueue(carta);
                }
            }
        }

        /**
        atualmente substitui o "corte" do baralho do jogador a esquerda de quem dá as cartas
        o corte pode ser implementado selecionando um indice e invertendo os batches entre eles
         */
        public void Embaralhar() 
        {
            List<Carta> lista = this
                .OrderBy(_ => Random.Shared.Next())
                .ToList();
            Clear();
            foreach (Carta carta in lista)
            {
                Enqueue(carta);
            }
        }

    }
}