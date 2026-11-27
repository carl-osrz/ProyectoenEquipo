/*
 * Created by SharpDevelop.
 * User: CC2_PC32
 * Date: 26/11/2026
 * Time: 07:19 a. m.
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
			this.txtNumeros = new System.Windows.Forms.TextBox();
			this.txtArreglo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblNumeros
			// 
			this.lblNumeros.Location = new System.Drawing.Point(27, 29);
			this.lblNumeros.Name = "lblNumeros";
			this.lblNumeros.Size = new System.Drawing.Size(166, 23);
			this.lblNumeros.TabIndex = 0;
			this.lblNumeros.Text = "¿Cuantos numeros va a ingresar?";
			// 
			// lblArreglo
			// 
			this.lblArreglo.Location = new System.Drawing.Point(27, 88);
			this.lblArreglo.Name = "lblArreglo";
			this.lblArreglo.Size = new System.Drawing.Size(146, 23);
			this.lblArreglo.TabIndex = 1;
			this.lblArreglo.Text = "Ingrese los numeros:";
			// 
			// txtNumeros
			// 
			this.txtNumeros.Location = new System.Drawing.Point(222, 29);
			this.txtNumeros.Name = "txtNumeros";
			this.txtNumeros.Size = new System.Drawing.Size(100, 20);
			this.txtNumeros.TabIndex = 2;
			// 
			// txtArreglo
			// 
			this.txtArreglo.Location = new System.Drawing.Point(222, 95);
			this.txtArreglo.Name = "txtArreglo";
			this.txtArreglo.Size = new System.Drawing.Size(100, 20);
			this.txtArreglo.TabIndex = 3;
			// 
			// Ordenamiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 330);
			this.Controls.Add(this.txtArreglo);
			this.Controls.Add(this.txtNumeros);
			this.Controls.Add(this.lblArreglo);
			this.Controls.Add(this.lblNumeros);
			this.Name = "Ordenamiento";
			this.Text = "Ordenamiento";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtArreglo;
		private System.Windows.Forms.TextBox txtNumeros;
		private System.Windows.Forms.Label lblArreglo;
		private System.Windows.Forms.Label lblNumeros;
	}
}
