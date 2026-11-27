/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC33
 * Fecha: 26/11/2026
 * Hora: 07:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_3
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class palabra : Form
	{
		public palabra()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnImprimirClick(object sender, EventArgs e)
		{
			string palabra = txtpalabra.Text;
			string resultado="";
			for (int i = palabra.Length - 1; i >= 0; i--)
			{
				resultado = resultado + palabra[i];
			}
			lblResultado.Text=resultado;
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtpalabra.Text="";
			lblResultado.Text="";
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Menu x = new Menu();
			this.Hide();
			x.Show();
		}
	}
}
