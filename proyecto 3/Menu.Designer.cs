/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 25/11/2026
 * Hora: 08:02 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto_3
{
	partial class Menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ordenamientoDeNúmeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mayorMenorYpromedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.palabraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vocalesconsonantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.programasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(516, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
			this.archivoToolStripMenuItem.Text = "&Archivo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
			this.salirToolStripMenuItem.Text = "&Salir";
			// 
			// programasToolStripMenuItem
			// 
			this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ordenamientoDeNúmeroToolStripMenuItem,
									this.mayorMenorYpromedioToolStripMenuItem,
									this.palabraToolStripMenuItem,
									this.vocalesconsonantesToolStripMenuItem});
			this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
			this.programasToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
			this.programasToolStripMenuItem.Text = "Pr&ogramas";
			// 
			// ordenamientoDeNúmeroToolStripMenuItem
			// 
			this.ordenamientoDeNúmeroToolStripMenuItem.Name = "ordenamientoDeNúmeroToolStripMenuItem";
			this.ordenamientoDeNúmeroToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
			this.ordenamientoDeNúmeroToolStripMenuItem.Text = "&Ordenamiento de número";
			// 
			// mayorMenorYpromedioToolStripMenuItem
			// 
			this.mayorMenorYpromedioToolStripMenuItem.Name = "mayorMenorYpromedioToolStripMenuItem";
			this.mayorMenorYpromedioToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
			this.mayorMenorYpromedioToolStripMenuItem.Text = "Mayor, menor y &promedio";
			// 
			// palabraToolStripMenuItem
			// 
			this.palabraToolStripMenuItem.Name = "palabraToolStripMenuItem";
			this.palabraToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
			this.palabraToolStripMenuItem.Text = "&Palabra";
			// 
			// vocalesconsonantesToolStripMenuItem
			// 
			this.vocalesconsonantesToolStripMenuItem.Name = "vocalesconsonantesToolStripMenuItem";
			this.vocalesconsonantesToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
			this.vocalesconsonantesToolStripMenuItem.Text = "Vocales, &consonantes";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(32, 55);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(452, 202);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 284);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Menu";
			this.Text = "Menu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem vocalesconsonantesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem palabraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mayorMenorYpromedioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ordenamientoDeNúmeroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
