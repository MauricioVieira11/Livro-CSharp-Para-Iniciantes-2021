

namespace BibliotecaV1
{
    class Revistas 
    {
        private int _MesPublicacao;
        private int _AnoCriacao;

        public Revistas(int mesPublicacao, int anoCriacao)
        {
            _MesPublicacao = mesPublicacao;
            _AnoCriacao = anoCriacao;
        }

        public int mesPublicacao
        {
            get { return _MesPublicacao} set { _MesPublicacao = value}
        }
        public int anoPublicacao
        {
            get { return _AnoCriacao} set { _AnoCriacao = value}
        }
    }
}
