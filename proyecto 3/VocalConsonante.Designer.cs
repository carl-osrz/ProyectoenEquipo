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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblVocales = new System.Windows.Forms.Label();
			this.lblConsonantes = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Palabra";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Vocales";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Consonantes";
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(105, 99);
			this.txtPalabra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(165, 22);
			this.txtPalabra.TabIndex = 3;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(391, 99);
			this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(133, 43);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(391, 160);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(133, 41);
			this.btnRegresar.TabIndex = 7;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(527, 79);
			this.label4.TabIndex = 8;
			this.label4.Text = "Cantidad de vocales y consonantes de una palabra";
			// 
			// lblVocales
			// 
			this.lblVocales.Location = new System.Drawing.Point(130, 138);
			this.lblVocales.Name = "lblVocales";
			this.lblVocales.Size = new System.Drawing.Size(185, 23);
			this.lblVocales.TabIndex = 9;
			// 
			// lblConsonantes
			// 
			this.lblConsonantes.Location = new System.Drawing.Point(130, 183);
			this.lblConsonantes.Name = "lblConsonantes";
			this.lblConsonantes.Size = new System.Drawing.Size(185, 23);
			this.lblConsonantes.TabIndex = 10;
			// 
			// VocalConsonante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 233);
			this.Controls.Add(this.lblConsonantes);
			this.Controls.Add(this.lblVocales);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnCalcular);
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
		private System.Windows.Forms.Label lblConsonantes;
		private System.Windows.Forms.Label lblVocales;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
