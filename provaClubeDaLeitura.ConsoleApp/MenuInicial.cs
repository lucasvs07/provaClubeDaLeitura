using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaClubeDaLeitura.ConsoleApp
{
    internal class MenuInicial
    {
        public void ApresentarMenuInicial(ref Revista[] listaDeRevistas, ref Emprestimo[] listaCompletaDeEmprestimos)
        {
            Console.Write("Olá!!\n" +
                "O que você deseja fazer? Digite a opção correspondente.\n" +
                "1 para cadastrar uma nova revista.\n" +
                "2 para cadastrar um novo empréstimo.\n" +
                "3 para cadastrar um novo amigo.\n" +
                "4 para cadastrar uma nova caixa de revistas.\n" +
                "5 para visualizar os empréstimos abertos.\n" +
                "7 para visualizar todos os empréstimos do mês.\n");

            string opcaoMenuPrincipal = Console.ReadLine();

            if (opcaoMenuPrincipal == "1")
            {
                Revista chamaMenuRevista = new Revista();
                chamaMenuRevista.MenuRevista(ref listaDeRevistas, ref listaCompletaDeEmprestimos);
            }

            else if (opcaoMenuPrincipal == "2")
            {
                Emprestimo  chamaMenuEmprestimo = new Emprestimo();
                chamaMenuEmprestimo.MenuEmprestimo(ref listaDeRevistas, ref listaCompletaDeEmprestimos);
            }

            else if (opcaoMenuPrincipal == "7")
            {
                TelaVisualizacao chamaTelaVisualizacao = new TelaVisualizacao();
                chamaTelaVisualizacao.VisualizarRegistros(ref listaDeRevistas);
            }
        }
    }
}
