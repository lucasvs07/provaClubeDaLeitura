using System;

namespace provaClubeDaLeitura.ConsoleApp
{
    public class Emprestimo
    {
        static Emprestimo[] listaCompletaDeEmprestimos = new Emprestimo[10];
        public string amigoQuePegou;
        public string revistaemprestada;
        public DateTime datadoemprestimo;
        public string datadadevolucao;
        public int contadorDeEmprestimosAtivos = 0;

        public void MenuEmprestimo()
        {
            while (true)

            {
                Console.WriteLine("Pressione 1 para o menu principal e 2 para cadastrar um novo empréstimo.");
                string opcaoFinal = Console.ReadLine();

                if (opcaoFinal == "1")
                {
                    MenuInicial ChamarMenu = new MenuInicial();
                    ChamarMenu.ApresentarMenuInicial();
                    break;
                }
                else if (opcaoFinal == "2")
                {

                    Emprestimo ChamaCadastro = new Emprestimo();
                    ChamaCadastro.CadastrarEmprestimo(ref listaCompletaDeEmprestimos);
                    break;
                }

                else if (opcaoFinal != "1" && opcaoFinal != "2")
                {
                    Console.WriteLine("Opção inválida. tente novamente.");
                    continue;
                }

            }
        }

        public void CadastrarEmprestimo(ref Emprestimo[] listaCompletaDeEmprestimos)
        {
            Console.Clear();

            Emprestimo novoEmprestimo = new Emprestimo();

            Console.WriteLine("Qual a revista emprestada?");
            novoEmprestimo.revistaemprestada = Console.ReadLine();

            Console.WriteLine("Qual o nome do amigo que pegou?");
            novoEmprestimo.amigoQuePegou = Console.ReadLine();

            Console.WriteLine("Qual a data do empréstimo?");
            novoEmprestimo.datadoemprestimo = DateTime.TryParse(Console.ReadLine());

            

            Console.WriteLine("Qual a data da devolução?");
            novoEmprestimo.datadadevolucao = Console.ReadLine();

            

            Console.WriteLine();
            Console.WriteLine();
            if()

            listaCompletaDeEmprestimos[contadorDeEmprestimosAtivos] = novoEmprestimo;

            contadorDeEmprestimosAtivos++;
            return true;
        }
    }
}
