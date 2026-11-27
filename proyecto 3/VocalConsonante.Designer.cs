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
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Palabra";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Vocales";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 219);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 30);
			this.label3.TabIndex = 2;
			this.label3.Text = "Consonantes";
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(163, 81);
			this.txtPalabra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(165, 22);
			this.txtPalabra.TabIndex = 3;
			// 
			// txtVocales
			// 
			this.txtVocales.Location = new System.Drawing.Point(163, 146);
			this.txtVocales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtVocales.Name = "txtVocales";
			this.txtVocales.Size = new System.Drawing.Size(89, 22);
			this.txtVocales.TabIndex = 4;
			// 
			// txtConsonantes
			// 
			this.txtConsonantes.Location = new System.Drawing.Point(163, 220);
			this.txtConsonantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtConsonantes.Name = "txtConsonantes";
			this.txtConsonantes.Size = new System.Drawing.Size(89, 22);
			this.txtConsonantes.TabIndex = 5;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(374, 193);
			this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(115, 49);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(-3, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(541, 41);
			this.label4.TabIndex = 7;
			this.label4.Text = "Vocales y consonantes de una palabra";
			// 
			// VocalConsonante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 278);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtConsonantes);
			this.Controls.Add(this.txtVocales);
			this.Controls.Add(this.txtPalabra);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "VocalConsonante";
			this.Text = "VocalConsonante";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtConsonantes;
		private System.Windows.Forms.TextBox txtVocales;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
