namespace Truco.Core.Equipes
{
    public class Equipe
    {
        private readonly Jogador[] _jogadores;
        private readonly ModoEquipe _modo;

        public Equipe(string nome, Convidado primeiro)
        {
            ArgumentNullException.ThrowIfNull(primeiro, nameof(primeiro));
            _jogadores = new Jogador[] { new Jogador(primeiro, this) };
            _modo = ModoEquipe.Sozinho;
            Nome = nome;
        }

        public Equipe(string nome, Convidado primeiro, Convidado segundo)
        {
            ArgumentNullException.ThrowIfNull(primeiro, nameof(primeiro));
            ArgumentNullException.ThrowIfNull(segundo, nameof(segundo));
            _jogadores = new Jogador[] { new Jogador(primeiro, this), new Jogador(segundo, this) };
            _modo = ModoEquipe.Dupla;
            Nome = nome;
        }

        public string Nome { get; set; }

        public ModoEquipe Modo { get { return _modo; } }

        public Jogador[] Jogadores { get { return _jogadores; } }

        public override string ToString()
        {
            return Nome;
        }

    }
}