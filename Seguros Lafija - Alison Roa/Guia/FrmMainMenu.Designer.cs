
namespace Guia
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Label_name = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.polizaToolStripMenuItem,
            this.autoToolStripMenuItem,
            this.accidenteToolStripMenuItem,
            this.miCuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // polizaToolStripMenuItem
            // 
            this.polizaToolStripMenuItem.Name = "polizaToolStripMenuItem";
            this.polizaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.polizaToolStripMenuItem.Text = "Poliza";
            this.polizaToolStripMenuItem.Click += new System.EventHandler(this.polizaToolStripMenuItem_Click);
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.autoToolStripMenuItem.Text = "Auto";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // accidenteToolStripMenuItem
            // 
            this.accidenteToolStripMenuItem.Name = "accidenteToolStripMenuItem";
            this.accidenteToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.accidenteToolStripMenuItem.Text = "Accidente";
            this.accidenteToolStripMenuItem.Click += new System.EventHandler(this.accidenteToolStripMenuItem_Click);
            // 
            // miCuentaToolStripMenuItem
            // 
            this.miCuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.miCuentaToolStripMenuItem.Name = "miCuentaToolStripMenuItem";
            this.miCuentaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.miCuentaToolStripMenuItem.Text = "Mi cuenta";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.configuracionToolStripMenuItem.Text = "⚙️ Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.salirToolStripMenuItem.Text = "🔙 Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(120, 190);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(80, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.BackColor = System.Drawing.Color.Transparent;
            this.Label_name.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_name.ForeColor = System.Drawing.Color.DarkGray;
            this.Label_name.Location = new System.Drawing.Point(200, 180);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(481, 89);
            this.Label_name.TabIndex = 2;
            this.Label_name.Text = "| Seguros Lafija";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Label_name);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguros Lafija - Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Label_name;
    }
}