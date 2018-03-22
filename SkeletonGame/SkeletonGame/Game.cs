using System;
using System.Drawing;

namespace SkeletonGame
{
    internal class Game
    {
        private Config config;
        private Map map;

        public Game(Config config)
        {
            this.config = config;
        }

        internal void Start()
        {
            map = new Map(config.mapSize, config.mapHeight, config.mapWidth);
            drawHex(100 / 2, 100 / 2, 60, 40);
        }

        public void drawHex(int x, int y, int width, int height)
        {
            System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            Point[] points = new Point[]
            {
                new Point(x, y+height/4),
                new Point(x, y+height*3/4),
                new Point(x+width/2, y+height*5/4),
                new Point(x+width, y+height*3/4),
                new Point(x+width, y+height/4),
                new Point(x+width/2, y-height/4)
            };
            //g.FillPolygon(b, points);
        }
    }
}