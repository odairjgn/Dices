using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DicesApp.Servicos
{
    public class ProcessadorDeFormulas
    {
        private const int Delay = 20;

        public static List<int> Sortear(int faces, int quantia)
        {
            return Enumerable.Repeat(0, quantia).Select(n => Sortear(faces)).ToList();
        }

        public static int Sortear(int faces)
        {
            var rnd = new Random();
            Thread.Sleep(Delay);
            return rnd.Next(1, faces+1);
        }
    }
}
