using System;

namespace provaClubeDaLeitura.ConsoleApp
{
    
    internal class Program
    {
        static Amigo[] listaDeAmigos = new Amigo[100];
        static Revista[] listaDeRevistas = new Revista[100];
        static Emprestimo[] listaCompletaDeEmprestimos = new Emprestimo[10];
        static int contadorDeRevistas = 0;

        static void Main(string[] args)
        {
            Console.Title = "Clube da leitura do Gustavo.";

            MenuInicial ChamarMenu = new MenuInicial();
            ChamarMenu.ApresentarMenuInicial(ref listaDeRevistas, ref listaCompletaDeEmprestimos);



            /*Caixa novaCaixa = new Caixa();
            novaCaixa.cor = "Vermelho";
            novaCaixa.numero = 12345;
            novaCaixa.etiqueta = "SpiderBox";


            Revista revista1 = new Revista();
            revista1.nomeDaRevista = "Homem-Aranha 1094";
            revista1.tipoDeColecao = "Homem-Aranha";
            revista1.numeroDaEdicao = 1234;
            revista1.anoDaRevista = "1987";
            revista1.caixa = novaCaixa.numero;

            Amigo lucas = new Amigo();
            lucas.nome = "Lucas";
            lucas.nomedoresponsavel = "Susane";
            lucas.telefone = 123456789;
            lucas.endereco = "Caetano";


            Emprestimo novoemprestimo = new Emprestimo();
            novoemprestimo.amigoQuePegou = lucas.nome;
            novoemprestimo.revistaemprestada = revista1.nomeDaRevista;
            novoemprestimo.datadoemprestimo = 190876;
            //novoemprestimo.datadadevolucao = 190878;*/

        }
    }
}
