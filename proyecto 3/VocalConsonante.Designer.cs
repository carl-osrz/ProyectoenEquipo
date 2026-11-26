/*
 * Creado por SharpDevelop.
 * Usuario: guzma
 * Fecha: 26/11/2026
 * Hora: 07:42 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto_3
{
	partial class VocalConsonante
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPalabra = new System.Windows.Forms.TextBox();
			this.txtVocales = new System.Windows.Forms.TextBox();
			this.txtConsonantes = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Palabra";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Vocales";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 274);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Consonantes";
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(119, 84);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(185, 26);
			this.txtPalabra.TabIndex = 3;
			// 
			// txtVocales
			// 
			this.txtVocales.Location = new System.Drawing.Point(120, 172);
			this.txtVocales.Name = "txtVocales";
			this.txtVocales.Size = new System.Drawing.Size(100, 26);
			this.txtVocales.TabIndex = 4;
			// 
			// txtConsonantes
			// 
			this.txtConsonantes.Location = new System.Drawing.Point(120, 274);
			this.txtConsonantes.Name = "txtConsonantes";
			this.txtConsonantes.Size = new System.Drawing.Size(100, 26);
			this.txtConsonantes.TabIndex = 5;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(416, 83);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(112, 27);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// VocalConsonante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 527);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtConsonantes);
			this.Controls.Add(this.txtVocales);
			this.Controls.Add(this.txtPalabra);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "VocalConsonante";
			this.Text = "VocalConsonante";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtConsonantes;
		private System.Windows.Forms.TextBox txtVocales;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
