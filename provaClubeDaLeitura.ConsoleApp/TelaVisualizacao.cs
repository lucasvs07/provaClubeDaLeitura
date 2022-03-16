using System;

namespace provaClubeDaLeitura.ConsoleApp
{
    internal class TelaVisualizacao
    {
       public void VisualizarRegistros(ref Revista[] listaDeRevistas)
        {
            Revista chamaLista = new Revista();
            
            int i = 0;
            for (i = 0; i < listaDeRevistas.Length; i++)
            {
                if (listaDeRevistas[i] != null)
                {
                    Console.WriteLine(listaDeRevistas[i]);
                }
            }
            
        }
    }
}
