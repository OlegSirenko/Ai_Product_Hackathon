using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetadataGenerator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Scene_MouseMove(object sender, MouseEventArgs e)
        {
            CursorPositionLabel.Text = Scene.Image==null?"0 X 0":(int)((double)Scene.Image.Width/(double)Scene.Width*e.X) + " X " + (int)((double)Scene.Image.Height / (double)Scene.Height * e.Y);
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OpenFileDialog.FileName;
            Scene.Image = Image.FromFile(filename);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void measureButton_Click(object sender, EventArgs e)
        {

        }
    }
}
