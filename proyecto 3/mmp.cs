/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 25/11/2026
 * Hora: 08:27 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_3
{
	/// <summary>
	/// Description of mmp.
	/// </summary>
	public partial class mmp : Form
	{
		public mmp()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			int tamaño;
		    tamaño = int.Parse(txtCantidad.Text);
		    int[] numeros = new int[tamaño];
		    string[] datos = txtSerie.Text.Split(',');
		    for (int i = 0; i < tamaño; i++)
		    {
		        numeros[i] = int.Parse(datos[i].Trim());
		    }
		    string resultado = "Lista de números: ";
		    for (int i = 0; i < tamaño; i++)
		    {
		        resultado += numeros[i] + " ";
		    }
		    lblRespuesta.Text = resultado;
		}
	}
}
