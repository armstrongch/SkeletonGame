using System.Drawing;
using System.Windows.Forms;

namespace SkeletonGame
{
    public partial class GameForm : Form
    {

        public GameForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
    }
}
