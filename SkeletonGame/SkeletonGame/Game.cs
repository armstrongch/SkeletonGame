using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SkeletonGame
{
    public class Game
    {
        //High-level
        private Config config; //config file
        public List<Hex> hexes; //self-explanatory

        //Form Info
        int formHeight;
        int formWidth;

        //Drawing
        public int xOrigin; //x coordinate of map origin
        public int yOrigin; //y coordinate of map origin
        public int mapPix; //Height/Width of map in pixels
        public int hexWidth; //in pixels
        public int hexHeight; //in pixels
        const int percentOfForm = 80; //80% of the form is taken up by the map

        public Game(Config config, int formHeight, int formWidth)
        {
            this.config = config;
            this.formHeight = formHeight;
            this.formWidth = formWidth;

            setupHexes();
        }

        public void setupDrawingVariables()
        {
            //Find the largest square that will fit in the form
            if (formHeight > formWidth)
            {
                mapPix = formWidth;
                xOrigin = 0;
                yOrigin = (formHeight - formWidth) / 2;
            }
            else
            {
                mapPix = formHeight;
                yOrigin = 0;
                xOrigin = (formWidth - formHeight) / 2;
            }
            //Account for UI, (shrink map according to appropriate form percentage)
            xOrigin += mapPix * (100 - percentOfForm) / 200;
            yOrigin += mapPix * (100 - percentOfForm) / 200;
            mapPix = mapPix * percentOfForm / 100;
            hexWidth = mapPix / (config.mapSize * 2 - 1);
            hexHeight = mapPix / (config.mapSize * 2 - 1);
        }

        private void setupHexes()
        {
            hexes = new List<Hex>();
            int hexesInRow = config.mapSize;
            int Rows = 0;
            int xCenter = config.mapSize * 2;
            do
            {
                for (int x = 0; x < hexesInRow; x++)
                {
                    hexes.Add(new Hex(xCenter - hexesInRow - 1 + x*2, Rows*2));
                }
                Rows++;
                if (Rows < config.mapSize)
                {
                    hexesInRow++;
                }
                else
                {
                    hexesInRow--;
                }
            } while (hexesInRow > config.mapSize - 1);


            
            /*int xCenter = config.mapSize * 2;
            int yCenter = config.mapSize * 2 - 1;
            for (int x = 0; x < config.mapSize * 4 - 1; x++)
            {
                for (int y = 0; y < config.mapSize * 4 - 3; y++)
                {
                    if ((y%2 == 0) &&
                        (((x%2 == 0) && (y%4 == 0)) || ((x%2 == 1) && (y%4 == 2))))
                    {
                        int xPos = x + 1;
                        int yPos = y + 1;
                        int xDistFromCenter = Math.Abs(xPos - xCenter);
                        int yDistFromCenter = Math.Abs(yPos - yCenter);
                        double DistFromCenter = Math.Sqrt(Math.Pow(xDistFromCenter, 2) + Math.Pow(yDistFromCenter, 2));
                        if (DistFromCenter <= config.mapSize*2)
                        {
                            hexes.Add(new Hex(x, y));
                        } 
                    }
                }
            }*/
        }
    }

    public class Hex
    {
        public int x;
        public int y;

        public Hex(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }
    }
}