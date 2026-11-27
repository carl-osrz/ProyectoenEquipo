/*
 * Created by SharpDevelop.
 * User: Andy
 * Date: 26/11/2026
 * Time: 09:56 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto_3
{
	partial class Ordenamiento
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
			this.lblNumeros = new System.Windows.Forms.Label();
			this.lblArreglo = new System.Windows.Forms.Label();
			this.lblMenor = new System.Windows.Forms.Label();
			this.lblMayor = new System.Windows.Forms.Label();
			this.txtNumeros = new System.Windows.Forms.TextBox();
			this.txtArreglo = new System.Windows.Forms.TextBox();
			this.btnOrdenamiento = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNumeros
			// 
			this.lblNumeros.Location = new System.Drawing.Point(36, 58);
			this.lblNumeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNumeros.Name = "lblNumeros";
			this.lblNumeros.Size = new System.Drawing.Size(240, 28);
			this.lblNumeros.TabIndex = 0;
			this.lblNumeros.Text = "¿Cuantos numeros va a ingresar?";
			// 
			// lblArreglo
			// 
			this.lblArreglo.Location = new System.Drawing.Point(36, 101);
			this.lblArreglo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblArreglo.Name = "lblArreglo";
			this.lblArreglo.Size = new System.Drawing.Size(217, 28);
			this.lblArreglo.TabIndex = 1;
			this.lblArreglo.Text = "Arreglo de numeros:";
			// 
			// lblMenor
			// 
			this.lblMenor.Location = new System.Drawing.Point(26, 161);
			this.lblMenor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMenor.Name = "lblMenor";
			this.lblMenor.Size = new System.Drawing.Size(397, 108);
			this.lblMenor.TabIndex = 2;
			// 
			// lblMayor
			// 
			this.lblMayor.Location = new System.Drawing.Point(312, 207);
			this.lblMayor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMayor.Name = "lblMayor";
			this.lblMayor.Size = new System.Drawing.Size(133, 28);
			this.lblMayor.TabIndex = 3;
			// 
			// txtNumeros
			// 
			this.txtNumeros.Location = new System.Drawing.Point(284, 55);
			this.txtNumeros.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumeros.Name = "txtNumeros";
			this.txtNumeros.Size = new System.Drawing.Size(132, 22);
			this.txtNumeros.TabIndex = 4;
			// 
			// txtArreglo
			// 
			this.txtArreglo.Location = new System.Drawing.Point(284, 107);
			this.txtArreglo.Margin = new System.Windows.Forms.Padding(4);
			this.txtArreglo.Name = "txtArreglo";
			this.txtArreglo.Size = new System.Drawing.Size(132, 22);
			this.txtArreglo.TabIndex = 5;
			// 
			// btnOrdenamiento
			// 
			this.btnOrdenamiento.Location = new System.Drawing.Point(36, 283);
			this.btnOrdenamiento.Margin = new System.Windows.Forms.Padding(4);
			this.btnOrdenamiento.Name = "btnOrdenamiento";
			this.btnOrdenamiento.Size = new System.Drawing.Size(133, 49);
			this.btnOrdenamiento.TabIndex = 6;
			this.btnOrdenamiento.Text = "Ordenar";
			this.btnOrdenamiento.UseVisualStyleBackColor = true;
			this.btnOrdenamiento.Click += new System.EventHandler(this.BtnOrdenamientoClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(290, 283);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(133, 49);
			this.btnRegresar.TabIndex = 7;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// Ordenamiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 385);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnOrdenamiento);
			this.Controls.Add(this.txtArreglo);
			this.Controls.Add(this.txtNumeros);
			this.Controls.Add(this.lblMayor);
			this.Controls.Add(this.lblMenor);
			this.Controls.Add(this.lblArreglo);
			this.Controls.Add(this.lblNumeros);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Ordenamiento";
			this.Text = "Ordenamiento";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnOrdenamiento;
		private System.Windows.Forms.TextBox txtArreglo;
		private System.Windows.Forms.TextBox txtNumeros;
		private System.Windows.Forms.Label lblMayor;
		private System.Windows.Forms.Label lblMenor;
		private System.Windows.Forms.Label lblArreglo;
		private System.Windows.Forms.Label lblNumeros;
	}
}
