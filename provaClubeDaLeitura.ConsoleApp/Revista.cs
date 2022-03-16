using System;


namespace provaClubeDaLeitura.ConsoleApp
{
    

    public class Revista
    {
       static Revista[] listaDeRevistas = new Revista[10];

        int contadorDeRevistas = 0;

        public string tipoDeColecao;
        public int numeroDaEdicao;
        public string anoDaRevista;
        public int caixa;
        public string revistaAtual;
        public string nomeDaRevista;

        public void MenuRevista()
        {

            while (true)

            {
                Console.WriteLine("Pressione 1 para o menu principal e 2 para cadastrar uma nova revista.");
                string opcaoFinal = Console.ReadLine();

                if (opcaoFinal == "1")
                {
                    MenuInicial ChamarMenu = new MenuInicial();
                    ChamarMenu.ApresentarMenuInicial();
                    break;
                }
                else if (opcaoFinal == "2")
                {

                    Revista ChamaCadastro = new Revista();
                    ChamaCadastro.CadastrarRevista(ref listaDeRevistas);
                    break;
                }

                else if (opcaoFinal != "1" && opcaoFinal != "2")
                {
                    Console.WriteLine("Opção inválida. tente novamente.");
                    continue;
                }

            }
        }

        public bool CadastrarRevista(ref Revista[] listaDeRevistas)
        {

            Console.Clear();

            Revista novaRevista = new Revista();

            Console.WriteLine("Qual o nome da revista?");
            novaRevista.nomeDaRevista = Console.ReadLine();

            Console.WriteLine("Qual o número da edição?");
            novaRevista.numeroDaEdicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o ano da revista?");
            novaRevista.anoDaRevista = Console.ReadLine();

            Console.WriteLine("Qual o tipo da coleção?");
            novaRevista.tipoDeColecao = Console.ReadLine();

            Console.WriteLine("Qual a caixa que está guardada a revista?");
            novaRevista.caixa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();


            listaDeRevistas[contadorDeRevistas] = novaRevista;

            contadorDeRevistas++;
            return true;
        }
            
                
     
    }
}
