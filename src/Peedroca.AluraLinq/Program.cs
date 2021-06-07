using System;
using System.Collections.Generic;
using Peedroca.AluraLinq.Extensions;

namespace Peedroca.AluraLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);

            lista.AddRange(1, 3, 4);

            Console.WriteLine(string.Join(",", lista));
        }
    }
}
