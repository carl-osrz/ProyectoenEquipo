/*
 * Creado por SharpDevelop.
 * Usuario: guzma
 * Fecha: 26/11/2026
 * Hora: 07:42 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_3
{
	/// <summary>
	/// Description of VocalConsonante.
	/// </summary>
	public partial class VocalConsonante : Form
	{
		public VocalConsonante()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void BtnCalcularClick(object sender, EventArgs e)
		{
		    string palabra = txtPalabra.Text.ToLower();
		    int vocales = 0;
		    int consonantes = 0;
		
		    for (int i = 0; i < palabra.Length; i++)
		    {
		        if (palabra[i] == 'a' || palabra[i] == 'e' ||
		            palabra[i] == 'i' || palabra[i] == 'o' ||
		            palabra[i] == 'u')
		        {
		            vocales++;
		        }
		        else if (palabra[i] >= 'a' && palabra[i] <= 'z')
		        {
		            consonantes++;
		        }
		    }
		
		    txtVocales.Text = vocales.ToString();
		    txtConsonantes.Text = consonantes.ToString();
		}
	}
}
