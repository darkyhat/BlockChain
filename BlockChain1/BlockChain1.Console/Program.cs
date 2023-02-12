using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var chain = new BlockChain();
            var server = new WebServer(chain);
            System.Console.Read();
        }
    }
}
