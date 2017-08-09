using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                UI ui = new UI();
                ui.Run();
                Console.ReadKey();
            }
        }
    }
}
