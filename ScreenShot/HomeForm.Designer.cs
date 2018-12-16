namespace ScreenShot
{
    partial class HomeForm
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
            this.printScreenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printScreenButton
            // 
            this.printScreenButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.printScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printScreenButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printScreenButton.ForeColor = System.Drawing.SystemColors.Control;
            this.printScreenButton.Location = new System.Drawing.Point(131, 64);
            this.printScreenButton.Name = "printScreenButton";
            this.printScreenButton.Size = new System.Drawing.Size(98, 40);
            this.printScreenButton.TabIndex = 0;
            this.printScreenButton.Text = "Screen Shot button";
            this.printScreenButton.UseVisualStyleBackColor = false;
            this.printScreenButton.Click += new System.EventHandler(this.printScreenButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(374, 182);
            this.Controls.Add(this.printScreenButton);
            this.Name = "HomeForm";
            this.Text = "ScreetShot";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printScreenButton;
    }
}

