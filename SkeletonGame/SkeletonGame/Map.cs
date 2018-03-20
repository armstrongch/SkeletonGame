using System.Collections.Generic;
using System.Windows.Forms;

namespace SkeletonGame
{
    internal class Map
    {
        const int mapPercentOfScreen = 80;
        int mapSize;
        int xOrigin;
        int yOrigin;

        private List<Hex> hexes = new List<Hex>();
        MapForm mapForm;

        public Map(int mapSize)
        {
            mapForm = new MapForm();
            Application.Run(mapForm);
            if (mapForm.Height > mapForm.Width)
            {
                mapSize = mapForm.Width;
                xOrigin = 0;
                yOrigin = (mapForm.Height - mapForm.Width) / 2;
            }
            else
            {
                mapSize = mapForm.Height;
                yOrigin = 0;
                xOrigin = (mapForm.Width - mapForm.Height) / 2;
            }

            for (int x = 0; x < mapSize*4-1; x++)
            {
                for (int y = 0; y < mapSize*2-1; y++)
                {
                    if (((y%2 == 0) && (x%2 == 1))
                        || ((y % 2 == 1) && (x % 2 == 0))) {
                        //hexes.Add(new Hex(x*hexWidth, y*hexHeight));
                    }
                }
            }
            
        }
    }

    internal class Hex
    {
        private int x;
        private int y;

        public Hex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}