/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC33
 * Fecha: 26/11/2026
 * Hora: 07:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto_3
{
	partial class palabra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(palabra));
			this.lblPalabra = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtpalabra = new System.Windows.Forms.TextBox();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPalabra
			// 
			this.lblPalabra.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPalabra.Location = new System.Drawing.Point(16, 130);
			this.lblPalabra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPalabra.Name = "lblPalabra";
			this.lblPalabra.Size = new System.Drawing.Size(133, 28);
			this.lblPalabra.TabIndex = 0;
			this.lblPalabra.Text = "Palabra:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 26);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(212, 37);
			this.label2.TabIndex = 1;
			this.label2.Text = "PALABRA AL REVEZ";
			// 
			// txtpalabra
			// 
			this.txtpalabra.Location = new System.Drawing.Point(184, 134);
			this.txtpalabra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtpalabra.Name = "txtpalabra";
			this.txtpalabra.Size = new System.Drawing.Size(269, 22);
			this.txtpalabra.TabIndex = 2;
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Location = new System.Drawing.Point(16, 377);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(101, 49);
			this.btnImprimir.TabIndex = 3;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.BtnImprimirClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(166, 377);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(101, 49);
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(349, 377);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(104, 49);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(16, 204);
			this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(437, 146);
			this.lblResultado.TabIndex = 6;
			// 
			// palabra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(489, 514);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.txtpalabra);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblPalabra);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "palabra";
			this.Text = "Palabra";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.TextBox txtpalabra;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblPalabra;
	}
}
