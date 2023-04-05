using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilipsDinner
{
    public class App
    {
        public void Run()
        {
            var game = new Game();
            while (true)
            {
                game.Run();
                Console.WriteLine("Tryck b för att gå ut.");


            }
        }
    }
}
