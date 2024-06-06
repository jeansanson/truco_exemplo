using Truco.Core.Cartas;
using Xunit;

namespace Truco.Core.Tests
{
    public class BaralhoTest
    {
        [Fact]
        public void Constructor_WhenInstanceated_IsPopulated()
        {
            Baralho baralho = new();
            Assert.True(baralho.Count == 40);
        }

        [Fact]
        public void Embaralhar_WhenCalled_ChangesOrder()
        {
            Baralho baralho = new();
            List<Carta> orderedList = baralho.ToList();
            baralho.Embaralhar();
            foreach (Carta carta in orderedList)
            {
                Carta cartaDoBaralho = baralho.Dequeue();
                if (!carta.Equals(cartaDoBaralho))
                {
                    return;
                }
            }
            Assert.Fail("O baralho não foi embaralhado.");
        }
    }
}