
namespace MetadataGenerator
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Scene = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.SaveRegion = new System.Windows.Forms.Button();
            this.doublePanel = new System.Windows.Forms.Panel();
            this.parallel_twoButton = new System.Windows.Forms.Button();
            this.parallel_oneButton = new System.Windows.Forms.Button();
            this.length_twoButton = new System.Windows.Forms.NumericUpDown();
            this.length_oneBox = new System.Windows.Forms.NumericUpDown();
            this.measure_twoButton = new System.Windows.Forms.Button();
            this.measure_oneButton = new System.Windows.Forms.Button();
            this.onePanel = new System.Windows.Forms.Panel();
            this.singleParallel2Button = new System.Windows.Forms.Button();
            this.singleParallel1Button = new System.Windows.Forms.Button();
            this.zeroPanel = new System.Windows.Forms.Panel();
            this.lengthBox = new System.Windows.Forms.NumericUpDown();
            this.measureButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cornersButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.regionCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveJson = new System.Windows.Forms.Button();
            this.LoadImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CursorPositionLabel = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scene)).BeginInit();
            this.panel9.SuspendLayout();
            this.doublePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.length_twoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length_oneBox)).BeginInit();
            this.onePanel.SuspendLayout();
            this.zeroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Scene);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel9);
            this.splitContainer1.Panel2.Controls.Add(this.doublePanel);
            this.splitContainer1.Panel2.Controls.Add(this.onePanel);
            this.splitContainer1.Panel2.Controls.Add(this.zeroPanel);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Size = new System.Drawing.Size(872, 638);
            this.splitContainer1.SplitterDistance = 481;
            this.splitContainer1.TabIndex = 0;
            // 
            // Scene
            // 
            this.Scene.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Scene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scene.Location = new System.Drawing.Point(0, 0);
            this.Scene.Name = "Scene";
            this.Scene.Size = new System.Drawing.Size(481, 638);
            this.Scene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Scene.TabIndex = 2;
            this.Scene.TabStop = false;
            this.Scene.Click += new System.EventHandler(this.Scene_Click);
            this.Scene.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseMove);
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(481, 0);
            this.panel6.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.SaveRegion);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 300);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5);
            this.panel9.Size = new System.Drawing.Size(387, 37);
            this.panel9.TabIndex = 8;
            // 
            // SaveRegion
            // 
            this.SaveRegion.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveRegion.Location = new System.Drawing.Point(5, 5);
            this.SaveRegion.Name = "SaveRegion";
            this.SaveRegion.Size = new System.Drawing.Size(377, 23);
            this.SaveRegion.TabIndex = 0;
            this.SaveRegion.Text = "Save Region";
            this.SaveRegion.UseVisualStyleBackColor = true;
            this.SaveRegion.Click += new System.EventHandler(this.SaveRegion_Click);
            // 
            // doublePanel
            // 
            this.doublePanel.Controls.Add(this.parallel_twoButton);
            this.doublePanel.Controls.Add(this.parallel_oneButton);
            this.doublePanel.Controls.Add(this.length_twoButton);
            this.doublePanel.Controls.Add(this.length_oneBox);
            this.doublePanel.Controls.Add(this.measure_twoButton);
            this.doublePanel.Controls.Add(this.measure_oneButton);
            this.doublePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.doublePanel.Enabled = false;
            this.doublePanel.Location = new System.Drawing.Point(0, 229);
            this.doublePanel.Name = "doublePanel";
            this.doublePanel.Padding = new System.Windows.Forms.Padding(5);
            this.doublePanel.Size = new System.Drawing.Size(387, 71);
            this.doublePanel.TabIndex = 7;
            this.doublePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // parallel_twoButton
            // 
            this.parallel_twoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.parallel_twoButton.Location = new System.Drawing.Point(179, 35);
            this.parallel_twoButton.Name = "parallel_twoButton";
            this.parallel_twoButton.Size = new System.Drawing.Size(100, 23);
            this.parallel_twoButton.TabIndex = 8;
            this.parallel_twoButton.Text = "параллель";
            this.parallel_twoButton.UseVisualStyleBackColor = false;
            this.parallel_twoButton.Click += new System.EventHandler(this.parallel_twoButton_Click);
            // 
            // parallel_oneButton
            // 
            this.parallel_oneButton.BackColor = System.Drawing.Color.Green;
            this.parallel_oneButton.Location = new System.Drawing.Point(179, 6);
            this.parallel_oneButton.Name = "parallel_oneButton";
            this.parallel_oneButton.Size = new System.Drawing.Size(100, 23);
            this.parallel_oneButton.TabIndex = 7;
            this.parallel_oneButton.Text = "параллель";
            this.parallel_oneButton.UseVisualStyleBackColor = false;
            this.parallel_oneButton.Click += new System.EventHandler(this.parallel_oneButton_Click);
            // 
            // length_twoButton
            // 
            this.length_twoButton.Location = new System.Drawing.Point(111, 37);
            this.length_twoButton.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.length_twoButton.Name = "length_twoButton";
            this.length_twoButton.Size = new System.Drawing.Size(62, 23);
            this.length_twoButton.TabIndex = 6;
            this.length_twoButton.ValueChanged += new System.EventHandler(this.length_twoButton_ValueChanged);
            // 
            // length_oneBox
            // 
            this.length_oneBox.Location = new System.Drawing.Point(111, 8);
            this.length_oneBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.length_oneBox.Name = "length_oneBox";
            this.length_oneBox.Size = new System.Drawing.Size(62, 23);
            this.length_oneBox.TabIndex = 2;
            this.length_oneBox.ValueChanged += new System.EventHandler(this.length_oneBox_ValueChanged);
            // 
            // measure_twoButton
            // 
            this.measure_twoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.measure_twoButton.Location = new System.Drawing.Point(5, 37);
            this.measure_twoButton.Name = "measure_twoButton";
            this.measure_twoButton.Size = new System.Drawing.Size(100, 23);
            this.measure_twoButton.TabIndex = 5;
            this.measure_twoButton.Text = "измеритель";
            this.measure_twoButton.UseVisualStyleBackColor = false;
            this.measure_twoButton.Click += new System.EventHandler(this.measure_twoButton_Click);
            // 
            // measure_oneButton
            // 
            this.measure_oneButton.BackColor = System.Drawing.Color.SpringGreen;
            this.measure_oneButton.Location = new System.Drawing.Point(5, 8);
            this.measure_oneButton.Name = "measure_oneButton";
            this.measure_oneButton.Size = new System.Drawing.Size(100, 23);
            this.measure_oneButton.TabIndex = 4;
            this.measure_oneButton.Text = "измеритель";
            this.measure_oneButton.UseVisualStyleBackColor = false;
            this.measure_oneButton.Click += new System.EventHandler(this.measure_oneButton_Click);
            // 
            // onePanel
            // 
            this.onePanel.Controls.Add(this.singleParallel2Button);
            this.onePanel.Controls.Add(this.singleParallel1Button);
            this.onePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.onePanel.Enabled = false;
            this.onePanel.Location = new System.Drawing.Point(0, 161);
            this.onePanel.Name = "onePanel";
            this.onePanel.Padding = new System.Windows.Forms.Padding(5);
            this.onePanel.Size = new System.Drawing.Size(387, 68);
            this.onePanel.TabIndex = 6;
            // 
            // singleParallel2Button
            // 
            this.singleParallel2Button.BackColor = System.Drawing.Color.Tomato;
            this.singleParallel2Button.Location = new System.Drawing.Point(5, 37);
            this.singleParallel2Button.Name = "singleParallel2Button";
            this.singleParallel2Button.Size = new System.Drawing.Size(100, 23);
            this.singleParallel2Button.TabIndex = 3;
            this.singleParallel2Button.Text = "параллель";
            this.singleParallel2Button.UseVisualStyleBackColor = false;
            this.singleParallel2Button.Click += new System.EventHandler(this.singleParallel2Button_Click);
            // 
            // singleParallel1Button
            // 
            this.singleParallel1Button.BackColor = System.Drawing.Color.LightCoral;
            this.singleParallel1Button.Location = new System.Drawing.Point(5, 8);
            this.singleParallel1Button.Name = "singleParallel1Button";
            this.singleParallel1Button.Size = new System.Drawing.Size(100, 23);
            this.singleParallel1Button.TabIndex = 2;
            this.singleParallel1Button.Text = "параллель";
            this.singleParallel1Button.UseVisualStyleBackColor = false;
            this.singleParallel1Button.Click += new System.EventHandler(this.singleParallel1Button_Click);
            // 
            // zeroPanel
            // 
            this.zeroPanel.Controls.Add(this.lengthBox);
            this.zeroPanel.Controls.Add(this.measureButton);
            this.zeroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.zeroPanel.Enabled = false;
            this.zeroPanel.Location = new System.Drawing.Point(0, 125);
            this.zeroPanel.Name = "zeroPanel";
            this.zeroPanel.Padding = new System.Windows.Forms.Padding(5);
            this.zeroPanel.Size = new System.Drawing.Size(387, 36);
            this.zeroPanel.TabIndex = 5;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(111, 5);
            this.lengthBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(62, 23);
            this.lengthBox.TabIndex = 1;
            this.lengthBox.ValueChanged += new System.EventHandler(this.lengthBox_ValueChanged);
            // 
            // measureButton
            // 
            this.measureButton.BackColor = System.Drawing.Color.SandyBrown;
            this.measureButton.Location = new System.Drawing.Point(5, 7);
            this.measureButton.Name = "measureButton";
            this.measureButton.Size = new System.Drawing.Size(100, 23);
            this.measureButton.TabIndex = 0;
            this.measureButton.Text = "измеритель";
            this.measureButton.UseVisualStyleBackColor = false;
            this.measureButton.Click += new System.EventHandler(this.measureButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cornersButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 83);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(387, 42);
            this.panel5.TabIndex = 4;
            // 
            // cornersButton
            // 
            this.cornersButton.Location = new System.Drawing.Point(5, 6);
            this.cornersButton.Name = "cornersButton";
            this.cornersButton.Size = new System.Drawing.Size(129, 27);
            this.cornersButton.TabIndex = 0;
            this.cornersButton.Text = "выбрать углы";
            this.cornersButton.UseVisualStyleBackColor = true;
            this.cornersButton.Click += new System.EventHandler(this.cornersButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.typeCombo);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(387, 26);
            this.panel4.TabIndex = 3;
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "undefined",
            "flooring",
            "wall",
            "ceiling"});
            this.typeCombo.Location = new System.Drawing.Point(179, 2);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(92, 23);
            this.typeCombo.TabIndex = 1;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "тип поверхности";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.regionCombo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(387, 26);
            this.panel3.TabIndex = 2;
            // 
            // regionCombo
            // 
            this.regionCombo.FormattingEnabled = true;
            this.regionCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.regionCombo.Location = new System.Drawing.Point(179, 2);
            this.regionCombo.Name = "regionCombo";
            this.regionCombo.Size = new System.Drawing.Size(92, 23);
            this.regionCombo.TabIndex = 1;
            this.regionCombo.SelectedIndexChanged += new System.EventHandler(this.regionCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "количество точек схождения";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.SaveJson);
            this.panel2.Controls.Add(this.LoadImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(387, 56);
            this.panel2.TabIndex = 1;
            // 
            // SaveJson
            // 
            this.SaveJson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveJson.Location = new System.Drawing.Point(5, 5);
            this.SaveJson.Name = "SaveJson";
            this.SaveJson.Size = new System.Drawing.Size(377, 23);
            this.SaveJson.TabIndex = 1;
            this.SaveJson.Text = "Save Json";
            this.SaveJson.UseVisualStyleBackColor = true;
            this.SaveJson.Click += new System.EventHandler(this.SaveJson_Click);
            // 
            // LoadImage
            // 
            this.LoadImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoadImage.Location = new System.Drawing.Point(5, 28);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(377, 23);
            this.LoadImage.TabIndex = 0;
            this.LoadImage.Text = "Load Image";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.CursorPositionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(387, 31);
            this.panel1.TabIndex = 0;
            // 
            // CursorPositionLabel
            // 
            this.CursorPositionLabel.AutoSize = true;
            this.CursorPositionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CursorPositionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CursorPositionLabel.Location = new System.Drawing.Point(5, 5);
            this.CursorPositionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CursorPositionLabel.Name = "CursorPositionLabel";
            this.CursorPositionLabel.Size = new System.Drawing.Size(43, 21);
            this.CursorPositionLabel.TabIndex = 0;
            this.CursorPositionLabel.Text = "0 x 0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 638);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Scene)).EndInit();
            this.panel9.ResumeLayout(false);
            this.doublePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.length_twoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length_oneBox)).EndInit();
            this.onePanel.ResumeLayout(false);
            this.zeroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lengthBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CursorPositionLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SaveJson;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox regionCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button cornersButton;
        private System.Windows.Forms.Panel doublePanel;
        private System.Windows.Forms.Panel onePanel;
        private System.Windows.Forms.Panel zeroPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button measureButton;
        private System.Windows.Forms.Button singleParallel2Button;
        private System.Windows.Forms.Button singleParallel1Button;
        private System.Windows.Forms.NumericUpDown lengthBox;
        private System.Windows.Forms.Button parallel_twoButton;
        private System.Windows.Forms.Button parallel_oneButton;
        private System.Windows.Forms.NumericUpDown length_twoButton;
        private System.Windows.Forms.NumericUpDown length_oneBox;
        private System.Windows.Forms.Button measure_twoButton;
        private System.Windows.Forms.Button measure_oneButton;
        private System.Windows.Forms.Button SaveRegion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox Scene;
    }
}