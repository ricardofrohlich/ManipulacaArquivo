using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArquivoLista
{
    internal class Arquivo
    {
        private string _nome;
        private StreamWriter _sw;
        private StreamReader _sr;
        public string Mensagem { get; set; }
        
        public string Nome {
            get
            {
                return _nome;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nome = value;
                }                
            } 
        }
        public Arquivo(string nome)
        {
            Nome = nome;
        }

        public void CriaAbreArquivo()
        {
            _sw = new StreamWriter("C:\\Arquivo\\" + Nome + ".txt", true, Encoding.UTF8);
        }

        public void LerArquivo()
        {
            string linha;
            _sr = new StreamReader("C:\\Arquivo\\" + Nome + ".txt");
            linha = _sr.ReadLine();
            while(linha!= null)
            {
                Console.WriteLine(linha);
                linha = _sr.ReadLine();
            }
            _sr.Close();
        }

        public void GravarMensagem(string mensagem)
        {
            _sw.WriteLine(mensagem);
        }

        public void FecharArquivo()
        {
            _sw.Close();
        }

    }
}
