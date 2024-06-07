using System.Runtime.InteropServices;
using Truco.Core.Cartas;
using Truco.Core.Equipes;

namespace Truco.Core.Partidas
{
    public class Rotacao
    {

        private readonly List<Jogador> _jogadores = new();
        private Jogador _atual;

        public Rotacao(Partida partida)
        {
            ValidaModosConflitantes(partida);
            switch (partida.Modo)
            {
                case ModoEquipe.Dupla:
                    _jogadores.Add(partida.Aliados.Jogadores[0]);
                    _jogadores.Add(partida.Adversarios.Jogadores[0]);
                    _jogadores.Add(partida.Aliados.Jogadores[1]);
                    _jogadores.Add(partida.Adversarios.Jogadores[1]);
                    break;
                case ModoEquipe.Sozinho:
                    _jogadores.Add(partida.Aliados.Jogadores[0]);
                    _jogadores.Add(partida.Adversarios.Jogadores[0]);
                    break;
                default:
                    throw new NotImplementedException($"Modo {partida.Modo} não implementado.");
            }
            _atual = _jogadores.First();
        }

        public override string ToString()
        {
            return $"Atual: {Atual()}, Próximo: {PreverProximo(_atual)}";
        }

        public Jogador SelecionarProximo()
        {
            _atual = PreverProximo(_atual);
            return _atual;
        }

        Jogador Atual()
        {
            return _atual;
        }

        private static void ValidaModosConflitantes(Partida partida)
        {
            if (partida.Aliados.Modo == partida.Adversarios.Modo) return;
            throw new InvalidOperationException("Quantidade de jogadores dos times não podem ser diferentes.");
        }

        private Jogador PreverProximo(Jogador atual)
        {
            int indiceAtual = _jogadores.IndexOf(atual);
            if (indiceAtual == _jogadores.Count - 1)
            {
                return _jogadores[0];
            }
            return _jogadores[indiceAtual + 1];
        }
    }
}