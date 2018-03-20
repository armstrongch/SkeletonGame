using System.Collections.Generic;
using System.Windows.Forms;

namespace SkeletonGame
{
    internal class Map
    {
        int xOrigin;
        int yOrigin;

        private List<Hex> hexes = new List<Hex>();

        public Map(int mapSize, int mapWidth, int mapHeight)
        {
            if (mapHeight > mapWidth)
            {
                mapSize = mapWidth;
                xOrigin = 0;
                yOrigin = (mapHeight - mapWidth) / 2;
            }
            else
            {
                mapSize = mapHeight;
                yOrigin = 0;
                xOrigin = (mapWidth - mapHeight) / 2;
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