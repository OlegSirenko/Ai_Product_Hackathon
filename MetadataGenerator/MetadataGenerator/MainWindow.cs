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

        Graphics lines;

        int imageX = 0;
        int imageY = 0;

        public MainWindow()
        {
            InitializeComponent();

            lines = Scene.CreateGraphics();
        }

        private void DrawLine(CPPclasses.Point start, CPPclasses.Point end, Color color)
        {
            
            Pen pen1 = new Pen(color, 2);
            lines.DrawLine(pen1, 
                (int)(start.x / Scene.Image.Width * Scene.Width), 
                (int)(start.y / Scene.Image.Height * Scene.Height), 
                (int)(end.x / Scene.Image.Width * Scene.Width), 
                (int)(end.y / Scene.Image.Height * Scene.Height));
        }

        private void DrawLines()
        {
            lines.Clear(Color.Transparent);
            lines = Scene.CreateGraphics();
            lines.DrawImage(Scene.Image, 0, 0, Scene.Width, (int)((double)Scene.Image.Height / Scene.Image.Width* Scene.Width));

            for (int i = 0; i< 4; i++)
            {
                DrawLine(Item.corners[i], Item.corners[(i + 1) % 4], Color.Gray);
            }

            Dictionary<List<CPPclasses.Point>, Color> toDraw = new Dictionary<List<CPPclasses.Point>, Color>();
            toDraw[Item.measure] = Color.SandyBrown;
            toDraw[Item.singleParallel1] = Color.LightCoral;
            toDraw[Item.singleParallel2] = Color.Tomato;
            toDraw[Item.measure_one] = Color.SpringGreen;
            toDraw[Item.parallel_one] = Color.Green;
            toDraw[Item.measure_two] = Color.RoyalBlue;
            toDraw[Item.parallel_two] = Color.SteelBlue;

            foreach (var draw in toDraw)
            {
                DrawLine(draw.Key[0], draw.Key[1], draw.Value);
            }
        }

        private void Scene_MouseMove(object sender, MouseEventArgs e)
        {
            imageX = Scene.Image == null ? 0 : (int)((double)Scene.Image.Width / (double)Scene.Width * e.X);
            imageY = Scene.Image == null ? 0 : (int)((double)Scene.Image.Height / (double)Scene.Height * e.Y);
            CursorPositionLabel.Text = imageX + " X " + imageY;
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OpenFileDialog.FileName;
            RegionList.Name = OpenFileDialog.SafeFileName.Substring(0, OpenFileDialog.SafeFileName.IndexOf('.'));
            Scene.Image = Image.FromFile(filename);
            DrawLines();
        }

        private void ClearItem()
        {
            Item = new TableItem();
            regionCombo.Text = "0";
            typeCombo.Text = "0";
            lengthBox.Value = 0;
            length_oneBox.Value = 0;
            length_twoButton.Value = 0;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)regionCombo.SelectedItem == "0")
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
            if ((string)typeCombo.SelectedItem == "undefined")
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

        private void SaveJson_Click(object sender, EventArgs e)
        {
            RegionList.SerializeThis();
            RegionList = new RegionList();
            ClearItem();
            MessageBox.Show("json saved");
        }

        private void SaveRegion_Click(object sender, EventArgs e)
        {
            if (Item.amount == 0)
            {
                RegionList.FlatSurfaces.Add(new FlatSurface(
                    Item.corners,
                    new LineSegment(Item.measure[0], Item.measure[1], Item.length)
                    ));
                MessageBox.Show("0-point surface added");
            }
            if (Item.amount == 1)
            {
                RegionList.SingleVanishingPoints.Add(new SingleVanishingPoint_simplified(
                    Item.corners,
                    new LineSegment(Item.measure[0], Item.measure[1], Item.length),
                    Measures.CalculateIntersection(new Line(Item.singleParallel1[0], Item.singleParallel1[1]),
                                                   new Line(Item.singleParallel2[0], Item.singleParallel2[1]))
                    ));
                MessageBox.Show("1-point surface added");
            }
            if (Item.amount == 2)
            {
                RegionList.DoubleVanishingPoints.Add(new DoubleVanishingPoint(
                    Item.corners,
                    new LineSegment(Item.measure_one[0], Item.measure_one[1], Item.length_one),
                    Measures.CalculateIntersection(new Line(Item.measure_one[0], Item.measure_one[1]),
                                                   new Line(Item.parallel_one[0], Item.parallel_one[1])),
                    new LineSegment(Item.measure_two[0], Item.measure_two[1], Item.length_two),
                    Measures.CalculateIntersection(new Line(Item.measure_two[0], Item.measure_two[1]),
                                                   new Line(Item.parallel_two[0], Item.parallel_two[1]))
                    ));
                MessageBox.Show("2-point surface added");
            }
            ClearItem();
        }

        private void Scene_Click(object sender, EventArgs e)
        {
            currentChanging[currentChangingIndex].x = imageX;
            currentChanging[currentChangingIndex].y = imageY;
            currentChangingIndex += 1;
            currentChangingIndex %= currentChangingMaxIndex;
            DrawLines();
        }
    }
}
