using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    class InteracaoUsuario
    {
        private string _MensagemDigitada;
        public string Mensagem
        {
            get
            {
                return _MensagemDigitada;
            }
            set
            {
                _MensagemDigitada = value;
            }
        }

        public void SolicitarDigitacao()
        {
            _MensagemDigitada = Console.ReadLine();

        }

        public void MostrarDigitacao()
        {
            Console.WriteLine(_MensagemDigitada);
        }

    }
}
