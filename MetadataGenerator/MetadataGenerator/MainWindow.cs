using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CPPclasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MetadataGenerator
{
    public partial class MainWindow : Form
    {
        RegionList RegionList = new RegionList();
        TableItem Item = new TableItem();
        List<CPPclasses.Point> currentChanging;
        int currentChangingIndex;
        int currentChangingMaxIndex;

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
            RegionList.Name = OpenFileDialog.SafeFileName.Substring(0, OpenFileDialog.SafeFileName.IndexOf('.'));
            Scene.Image = Image.FromFile(filename);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)regionCombo.SelectedItem == "0")
            {
                Item.amount = 0;
                zeroPanel.Enabled = true;
                onePanel.Enabled = false;
                doublePanel.Enabled = false;
            }
            if ((string)regionCombo.SelectedItem == "1")
            {
                Item.amount = 1;
                zeroPanel.Enabled = true;
                onePanel.Enabled = true;
                doublePanel.Enabled = false;
            }
            if ((string)regionCombo.SelectedItem == "2")
            {
                Item.amount = 2;
                zeroPanel.Enabled = false;
                onePanel.Enabled = false;
                doublePanel.Enabled = true;
            }
        }

        private void cornersButton_Click(object sender, EventArgs e)
        {
            currentChanging = Item.corners;
            currentChangingIndex = 0;
            currentChangingMaxIndex = 4;
        }
        private void measureButton_Click(object sender, EventArgs e)
        {
            currentChanging = Item.measure;
            currentChangingIndex = 0;
            currentChangingMaxIndex = 2;
        }

        private void singleParallel1Button_Click(object sender, EventArgs e)
        {
            currentChanging = Item.singleParallel1;
            currentChangingIndex = 0;
            currentChangingMaxIndex = 2;
        }

        private void singleParallel2Button_Click(object sender, EventArgs e)
        {
            currentChanging = Item.singleParallel2;
            currentChangingIndex = 0;
            currentChangingMaxIndex = 2;
        }

        private void measure_oneButton_Click(object sender, EventArgs e)
        {
            currentChanging = Item.measure_one;
            currentChangingIndex = 0;
            currentChangingMaxIndex = 2;
        }

        private void measure_twoButton_Click(object sender, EventArgs e)
        {
            currentChanging = Item.measure_two;
            currentChangingIndex = 0;
            currentChangingMaxIndex = 2;
        }

        private void parallel_oneButton_Click(object sender, EventArgs e)
        {
            currentChanging = Item.parallel_one;
            currentChangingIndex = 0;
            currentChangingMaxIndex = 2;
        }

        private void parallel_twoButton_Click(object sender, EventArgs e)
        {
            currentChanging = Item.parallel_two;
            currentChangingIndex = 0;
            currentChangingMaxIndex = 2;
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)typeCombo.SelectedItem == "undefined")
            {
                Item.surface = surface_type.undefined;
            }
            if ((string)typeCombo.SelectedItem == "flooring")
            {
                Item.surface = surface_type.flooring;
            }
            if ((string)typeCombo.SelectedItem == "wall")
            {
                Item.surface = surface_type.wall;
            }
            if ((string)typeCombo.SelectedItem == "ceiling")
            {
                Item.surface = surface_type.undefined;
            }
        }

        private void lengthBox_ValueChanged(object sender, EventArgs e)
        {
            Item.length = (double)lengthBox.Value;
        }

        private void length_oneBox_ValueChanged(object sender, EventArgs e)
        {
            Item.length_one = (double)length_oneBox.Value;
        }

        private void length_twoButton_ValueChanged(object sender, EventArgs e)
        {
            Item.length_two = (double)length_twoButton.Value;
        }
    }
}
