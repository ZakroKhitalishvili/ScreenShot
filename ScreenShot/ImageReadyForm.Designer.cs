namespace ScreenShot
{
    partial class ImageReadyForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.paintRadioButton = new System.Windows.Forms.RadioButton();
            this.ellipseRadioButton = new System.Windows.Forms.RadioButton();
            this.rectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.markerRadioButton = new System.Windows.Forms.RadioButton();
            this.brushSizeInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backHistoryButton = new System.Windows.Forms.Button();
            this.forwardHistoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeInput)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDrawing);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.EndDrawing);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawing);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EndDrawing);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel1.Size = new System.Drawing.Size(631, 317);
            this.panel1.TabIndex = 2;
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Red;
            this.colorButton.Location = new System.Drawing.Point(3, 3);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 4;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // paintRadioButton
            // 
            this.paintRadioButton.AutoSize = true;
            this.paintRadioButton.Location = new System.Drawing.Point(84, 6);
            this.paintRadioButton.Name = "paintRadioButton";
            this.paintRadioButton.Size = new System.Drawing.Size(49, 17);
            this.paintRadioButton.TabIndex = 5;
            this.paintRadioButton.TabStop = true;
            this.paintRadioButton.Text = "Paint";
            this.paintRadioButton.UseVisualStyleBackColor = true;
            // 
            // ellipseRadioButton
            // 
            this.ellipseRadioButton.AutoSize = true;
            this.ellipseRadioButton.Location = new System.Drawing.Point(154, 6);
            this.ellipseRadioButton.Name = "ellipseRadioButton";
            this.ellipseRadioButton.Size = new System.Drawing.Size(83, 17);
            this.ellipseRadioButton.TabIndex = 6;
            this.ellipseRadioButton.TabStop = true;
            this.ellipseRadioButton.Text = "Draw Ellipse";
            this.ellipseRadioButton.UseVisualStyleBackColor = true;
            // 
            // rectangleRadioButton
            // 
            this.rectangleRadioButton.AutoSize = true;
            this.rectangleRadioButton.Location = new System.Drawing.Point(243, 6);
            this.rectangleRadioButton.Name = "rectangleRadioButton";
            this.rectangleRadioButton.Size = new System.Drawing.Size(102, 17);
            this.rectangleRadioButton.TabIndex = 7;
            this.rectangleRadioButton.TabStop = true;
            this.rectangleRadioButton.Text = "Draw Rectangle";
            this.rectangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.forwardHistoryButton);
            this.panel2.Controls.Add(this.backHistoryButton);
            this.panel2.Controls.Add(this.markerRadioButton);
            this.panel2.Controls.Add(this.brushSizeInput);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.colorButton);
            this.panel2.Controls.Add(this.rectangleRadioButton);
            this.panel2.Controls.Add(this.paintRadioButton);
            this.panel2.Controls.Add(this.ellipseRadioButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 326);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 300);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 69);
            this.panel2.TabIndex = 8;
            // 
            // markerRadioButton
            // 
            this.markerRadioButton.AutoSize = true;
            this.markerRadioButton.Location = new System.Drawing.Point(351, 6);
            this.markerRadioButton.Name = "markerRadioButton";
            this.markerRadioButton.Size = new System.Drawing.Size(58, 17);
            this.markerRadioButton.TabIndex = 11;
            this.markerRadioButton.TabStop = true;
            this.markerRadioButton.Text = "Marker";
            this.markerRadioButton.UseVisualStyleBackColor = true;
            // 
            // brushSizeInput
            // 
            this.brushSizeInput.Location = new System.Drawing.Point(545, 6);
            this.brushSizeInput.Name = "brushSizeInput";
            this.brushSizeInput.Size = new System.Drawing.Size(55, 20);
            this.brushSizeInput.TabIndex = 10;
            this.brushSizeInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pen Size:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 32);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 398);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // backHistoryButton
            // 
            this.backHistoryButton.Location = new System.Drawing.Point(433, 32);
            this.backHistoryButton.Name = "backHistoryButton";
            this.backHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.backHistoryButton.TabIndex = 12;
            this.backHistoryButton.Text = "Back";
            this.backHistoryButton.UseVisualStyleBackColor = true;
            this.backHistoryButton.Click += new System.EventHandler(this.backHistoryButton_Click);
            // 
            // forwardHistoryButton
            // 
            this.forwardHistoryButton.Location = new System.Drawing.Point(515, 32);
            this.forwardHistoryButton.Name = "forwardHistoryButton";
            this.forwardHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.forwardHistoryButton.TabIndex = 13;
            this.forwardHistoryButton.Text = "Forward";
            this.forwardHistoryButton.UseVisualStyleBackColor = true;
            this.forwardHistoryButton.Click += new System.EventHandler(this.forwardHistoryButton_Click);
            // 
            // ImageReadyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 398);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImageReadyForm";
            this.Text = "ImageReadyForm";
            this.Load += new System.EventHandler(this.ImageReadyForm_Load);
            this.ResizeEnd += new System.EventHandler(this.ImageReadyForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeInput)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.RadioButton paintRadioButton;
        private System.Windows.Forms.RadioButton ellipseRadioButton;
        private System.Windows.Forms.RadioButton rectangleRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown brushSizeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton markerRadioButton;
        private System.Windows.Forms.Button forwardHistoryButton;
        private System.Windows.Forms.Button backHistoryButton;
    }
}