using System.Drawing;
using System.Windows.Forms;

namespace SkeletonGame
{
    public partial class MapForm : Form
    {
        Graphics graphics;
        public MapForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
    }
}
