﻿namespace ExamenFinal
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.examenFInalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enunciado1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enunciado2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examenFInalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // examenFInalToolStripMenuItem
            // 
            this.examenFInalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enunciado1ToolStripMenuItem,
            this.enunciado2ToolStripMenuItem});
            this.examenFInalToolStripMenuItem.Name = "examenFInalToolStripMenuItem";
            this.examenFInalToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.examenFInalToolStripMenuItem.Text = "Examen FInal";
            // 
            // enunciado1ToolStripMenuItem
            // 
            this.enunciado1ToolStripMenuItem.Name = "enunciado1ToolStripMenuItem";
            this.enunciado1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.enunciado1ToolStripMenuItem.Text = "Enunciado 1";
            this.enunciado1ToolStripMenuItem.Click += new System.EventHandler(this.enunciado1ToolStripMenuItem_Click);
            // 
            // enunciado2ToolStripMenuItem
            // 
            this.enunciado2ToolStripMenuItem.Name = "enunciado2ToolStripMenuItem";
            this.enunciado2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.enunciado2ToolStripMenuItem.Text = "Enunciado 2";
            this.enunciado2ToolStripMenuItem.Click += new System.EventHandler(this.enunciado2ToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem examenFInalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enunciado1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enunciado2ToolStripMenuItem;
    }
}