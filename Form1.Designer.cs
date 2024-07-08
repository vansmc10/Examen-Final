namespace ExamenFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.   
        /// </summary> System.ComponentModel.IContainer components = null;
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvSorted = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvUnsorted = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOrdena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoTexto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnOrdena);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNuevoTexto);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(903, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enunciado1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvSorted);
            this.panel2.Location = new System.Drawing.Point(535, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 331);
            this.panel2.TabIndex = 22;
            // 
            // lvSorted
            // 
            this.lvSorted.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvSorted.HideSelection = false;
            this.lvSorted.Location = new System.Drawing.Point(25, 10);
            this.lvSorted.Name = "lvSorted";
            this.lvSorted.Size = new System.Drawing.Size(326, 307);
            this.lvSorted.TabIndex = 11;
            this.lvSorted.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvUnsorted);
            this.panel1.Location = new System.Drawing.Point(4, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 331);
            this.panel1.TabIndex = 21;
            // 
            // lvUnsorted
            // 
            this.lvUnsorted.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvUnsorted.HideSelection = false;
            this.lvUnsorted.Location = new System.Drawing.Point(15, 10);
            this.lvUnsorted.Name = "lvUnsorted";
            this.lvUnsorted.Size = new System.Drawing.Size(326, 307);
            this.lvUnsorted.TabIndex = 11;
            this.lvUnsorted.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 200;
            // 
            // btnOrdena
            // 
            this.btnOrdena.Location = new System.Drawing.Point(398, 228);
            this.btnOrdena.Name = "btnOrdena";
            this.btnOrdena.Size = new System.Drawing.Size(93, 38);
            this.btnOrdena.TabIndex = 20;
            this.btnOrdena.Text = "Ordenar";
            this.btnOrdena.UseVisualStyleBackColor = true;
            this.btnOrdena.Click += new System.EventHandler(this.btnOrdena_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ingresar Texto";
            // 
            // txtNuevoTexto
            // 
            this.txtNuevoTexto.Location = new System.Drawing.Point(4, 84);
            this.txtNuevoTexto.Name = "txtNuevoTexto";
            this.txtNuevoTexto.Size = new System.Drawing.Size(269, 22);
            this.txtNuevoTexto.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(279, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 41);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Examen FInal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvUnsorted;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnOrdena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoTexto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvSorted;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

