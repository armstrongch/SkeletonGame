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

            GameForm gameForm = new GameForm();
            Application.Run(gameForm);

            config.mapWidth = gameForm.Width;
            config.mapHeight = gameForm.Height;

            Game game = new Game(config);
            game.Start();
        }
    }
}
