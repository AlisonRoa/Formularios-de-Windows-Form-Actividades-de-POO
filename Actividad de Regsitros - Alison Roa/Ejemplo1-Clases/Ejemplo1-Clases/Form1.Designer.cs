namespace Ejemplo1_Clases
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCentrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTrabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centroToolStripMenuItem,
            this.profesorToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.listaDeCentrosToolStripMenuItem});
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.centroToolStripMenuItem.Text = "Centro";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "➕ Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // listaDeCentrosToolStripMenuItem
            // 
            this.listaDeCentrosToolStripMenuItem.Name = "listaDeCentrosToolStripMenuItem";
            this.listaDeCentrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeCentrosToolStripMenuItem.Text = "✔️ Lista de Centros";
            this.listaDeCentrosToolStripMenuItem.Click += new System.EventHandler(this.listaDeCentrosToolStripMenuItem_Click);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.listaDeProfesorToolStripMenuItem});
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.profesorToolStripMenuItem.Text = "Profesor";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem1.Text = "➕ Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // listaDeProfesorToolStripMenuItem
            // 
            this.listaDeProfesorToolStripMenuItem.Name = "listaDeProfesorToolStripMenuItem";
            this.listaDeProfesorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeProfesorToolStripMenuItem.Text = "✔️ Lista de Profesor";
            this.listaDeProfesorToolStripMenuItem.Click += new System.EventHandler(this.listaDeProfesorToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.listaDeEstudiantesToolStripMenuItem});
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(192, 22);
            this.agregarToolStripMenuItem2.Text = "➕ Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // listaDeEstudiantesToolStripMenuItem
            // 
            this.listaDeEstudiantesToolStripMenuItem.Name = "listaDeEstudiantesToolStripMenuItem";
            this.listaDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listaDeEstudiantesToolStripMenuItem.Text = "✔️ Lista de Estudiantes";
            this.listaDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.listaDeEstudiantesToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem3,
            this.listaDeTrabajadoresToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // agregarToolStripMenuItem3
            // 
            this.agregarToolStripMenuItem3.Name = "agregarToolStripMenuItem3";
            this.agregarToolStripMenuItem3.Size = new System.Drawing.Size(198, 22);
            this.agregarToolStripMenuItem3.Text = "➕ Agregar";
            this.agregarToolStripMenuItem3.Click += new System.EventHandler(this.agregarToolStripMenuItem3_Click);
            // 
            // listaDeTrabajadoresToolStripMenuItem
            // 
            this.listaDeTrabajadoresToolStripMenuItem.Name = "listaDeTrabajadoresToolStripMenuItem";
            this.listaDeTrabajadoresToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listaDeTrabajadoresToolStripMenuItem.Text = "✔️ Lista de Trabajadores";
            this.listaDeTrabajadoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeTrabajadoresToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCentrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listaDeTrabajadoresToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

