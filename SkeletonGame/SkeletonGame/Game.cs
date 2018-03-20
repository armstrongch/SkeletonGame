using System;

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
            map = new Map(config.mapSize);
        }
    }
}