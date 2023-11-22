namespace ArquivoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, mensagem;
            Console.WriteLine("Digite o nome do arquivo: ");
            nome = Console.ReadLine();
            Arquivo a = new Arquivo(nome);
            int op;
            while(true)
            {
                Console.WriteLine("Menu do sistema de anotações: ");
                Console.WriteLine("1 - para escrever uma anotação");
                Console.WriteLine("2 - para ler as anotações");
                op = int.Parse(Console.ReadLine()); 
                if(op == 1)
                {
                    a.CriaAbreArquivo();
                    Console.WriteLine("Digite uma mensagem para ser armazenada: ");
                    Console.WriteLine("Digite SAIR para finalizar!");
                    while(true)
                    {
                        mensagem = Console.ReadLine();
                        if (mensagem.Equals("SAIR"))
                        {
                            a.FecharArquivo();
                            break;
                        }
                        else
                        {
                            a.GravarMensagem(mensagem);
                        }
                    }
                }
                else if(op == 2)
                {
                    a.LerArquivo();
                }
                else
                {
                    Console.WriteLine("Operação inválida!");
                }
            }
        }
    }
}