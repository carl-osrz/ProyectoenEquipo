/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 25/11/2026
 * Hora: 08:27 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto_3
{
	partial class mmp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mmp));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtSerie = new System.Windows.Forms.TextBox();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(629, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero Mayor, Menor y Promedio";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(347, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cantidad de números a ingresar:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(338, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Serie de números (sin espacio):";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(378, 103);
			this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 22);
			this.txtCantidad.TabIndex = 3;
			// 
			// txtSerie
			// 
			this.txtSerie.Location = new System.Drawing.Point(378, 148);
			this.txtSerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSerie.Name = "txtSerie";
			this.txtSerie.Size = new System.Drawing.Size(293, 22);
			this.txtSerie.TabIndex = 4;
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(157, 219);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(520, 107);
			this.lblRespuesta.TabIndex = 5;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(12, 185);
			this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(112, 50);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(13, 267);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(112, 50);
			this.btnRegresar.TabIndex = 7;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// mmp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(720, 366);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.txtSerie);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "mmp";
			this.Text = "mmp";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.TextBox txtSerie;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
