using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Akasztófa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] szavak = { "hajó", "mikrosütő", "monitor", "sportautó", "almáspite" };
            Random rnd = new Random();
            string randomszo = szavak[rnd.Next(0, szavak.Length)];
            
            
        }
    }
}
