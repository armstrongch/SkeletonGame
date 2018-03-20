using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkeletonGame
{
    static class Program
    {
        static void Main()
        {
            Config config = new Config();
            config.mapSize = 6;
            Game game = new Game(config);
            game.Start();
        }
    }
}
