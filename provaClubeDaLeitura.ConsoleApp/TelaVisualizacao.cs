using System;

namespace provaClubeDaLeitura.ConsoleApp
{
    public class TelaVisualizacao
    {
       public void VisualizarRegistros(ref Revista[] listaDeRevistas)
        {
            Revista chamaLista = new Revista();
            
            int i = 0;
            foreach (Revista item in listaDeRevistas)
            {
                Console.WriteLine(item.nomeDaRevista);
                Console.WriteLine(item.numeroDaEdicao);
                Console.WriteLine(item.tipoDeColecao);
                Console.WriteLine(item.anoDaRevista);
                Console.WriteLine(item.caixa);
                Console.ReadKey();
            }
        }
    }
}
 