using System;
using System.Collections.Generic;
using System.Drawing;
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

            GameForm gameForm = new GameForm(config);
            Application.Run(gameForm);
        }
    }
}
