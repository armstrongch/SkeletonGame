using System.Drawing;
using System.Windows.Forms;

namespace SkeletonGame
{
    public partial class GameForm : Form
    {

        public GameForm(Config config)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Graphics g = this.CreateGraphics();

            config.mapWidth = this.Width;
            config.mapHeight = this.Height;

            Game game = new Game(config, g);
            game.Start();
        }
    }
}
