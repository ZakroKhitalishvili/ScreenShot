﻿namespace ScreenShot
{
    partial class FullScreenForm
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
            this.SuspendLayout();
            // 
            // FullScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(335, 258);
            this.ControlBox = false;
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "FullScreenForm";
            this.Text = "FullScreenForm";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FullScreenForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Callback);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Callback);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Callback);
            this.ResumeLayout(false);

        }

        #endregion
    }
}