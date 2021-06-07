using System.Collections.Generic;

namespace Peedroca.AluraLinq.Extensions
{
    static class ListExtensions
    {
        public static void AddRange(this List<int> lista, params int[] itens)
        {
            foreach (var item in itens)
            {
                lista.Add(item);
            }
        }
    }
}