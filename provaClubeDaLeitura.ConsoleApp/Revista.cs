using System;


namespace provaClubeDaLeitura.ConsoleApp
{

    public class Revista
    {

        public int contadorDeRevistas = 0;

        public string tipoDeColecao;
        public int numeroDaEdicao;
        public string anoDaRevista;
        public int caixa;
        public string revistaAtual;
        public string nomeDaRevista;

        public void MenuRevista(ref Revista[] listaDeRevistas, ref Emprestimo[] listaCompletaDeEmprestimos)
        {

            while (true)
            {
                Console.Clear();
                Console.Write("Pressione 1 para o menu principal \n" +
                              "2 para cadastrar uma nova revista.\n");
                string opcaoFinal = Console.ReadLine();

                if (opcaoFinal == "1")
                {
                    MenuInicial ChamarMenu = new MenuInicial();
                    ChamarMenu.ApresentarMenuInicial(ref listaDeRevistas, ref listaCompletaDeEmprestimos);
                    break;
                }
                else if (opcaoFinal == "2")
                {
                    Revista ChamaCadastro = new Revista();
                    ChamaCadastro.CadastrarRevista(ref listaDeRevistas, ref listaCompletaDeEmprestimos);
                    break;
                }

                else if (opcaoFinal != "1" && opcaoFinal != "2")
                {
                    Console.WriteLine("Opção inválida. tente novamente.");
                    continue;
                }

            }
        }

        public void CadastrarRevista(ref Revista[] listaDeRevistas, ref Emprestimo[] listaCompletaDeEmprestimos)
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

                if (listaDeRevistas[contadorDeRevistas] == null)
                {
                    listaDeRevistas[contadorDeRevistas] = novaRevista;
                    
                    Console.Write("Revista cadastrada com sucesso.\n" +
                                  "Pressione enter para continuar.\n");
                    Console.ReadKey();
                    contadorDeRevistas++;
                    MenuRevista(ref listaDeRevistas, ref listaCompletaDeEmprestimos);
                    
                }

                else if (listaDeRevistas[contadorDeRevistas] != null)
                {
                    Console.Write("Não foi possível cadastrar, cadastro cheio.\n" +
                                  "Pressione enter para continuar.\n");
                    Console.ReadKey();
                    MenuRevista(ref listaDeRevistas, ref listaCompletaDeEmprestimos);
                    
                }


            


        }
        //contadorDeRevistas++;




    }
}
