using Truco.Core.Equipes;
using Truco.Core.Eventos;
using Truco.Core.Partidas;
using Xunit;

namespace Truco.Core.Tests
{
    public class PartidaTest
    {
        [Fact]
        public void Constructor_WhenInstanceated_SetupIsCompleted()
        {
            Convidado aliadoUm = new("Nathan");
            Convidado aliadoDois = new("Vinicius");
            Equipe aliados = new("Liga das lendas", aliadoUm, aliadoDois);

            Convidado advUm = new("Guilherme");
            Convidado advDois = new("Carlos");
            Equipe adversarios = new("Vai lorant", advUm, advDois);

            Partida partida = new(aliados, adversarios, new EventosExternosBase());

            // verificar se o setup foi realizado com sucesso
        }
    }
}