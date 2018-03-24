using System;
using System.Drawing;
using System.Windows.Forms;

namespace SkeletonGame
{
    public partial class GameForm : Form
    {
        static Game game;
        static Config config;

        const int borderPix = 4;

        public GameForm(Config c)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            config = c;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            game.setupDrawingVariables();
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, Width, Height));
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(game.xOrigin, game.yOrigin, game.mapPix, game.mapPix));
            foreach (Hex h in game.hexes)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(game.xOrigin + h.x * game.hexWidth/2 + borderPix, game.yOrigin + h.y * game.hexHeight / 2 + borderPix, game.hexWidth - borderPix*2, game.hexHeight - borderPix*2));
            }
            
        }

        private void StartGame(object sender, EventArgs e)
        {
            game = new Game(config, Height, Width);
        }
    }
}
