using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP2_Guilherme_ViniciusSobreira_Csharp
{
    public static class Utils
    {
        public static void ListarComIndice<T>(string titulo, List<T> lista)
        {
            Console.WriteLine($"\n{titulo}");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum item encontrado.");
                return;
            }
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{i} - {lista[i]}");
            }
        }
    }

}
