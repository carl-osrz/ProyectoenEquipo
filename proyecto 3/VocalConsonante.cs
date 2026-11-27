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
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			string palabra;
		    int vocales = 0;
		    int consonantes = 0;
		    palabra = txtPalabra.Text.ToLower();
		    for (int i = 0; i < palabra.Length; i++)
		    {
		        char letra = palabra[i];
		        if (letra >= 'a' && letra <= 'z')
		        {
		            if (letra == 'a' || letra == 'e' ||
		                letra == 'i' || letra == 'o' ||
		                letra == 'u')
		            {
		                vocales++;
		            }
		            else
		            {
		                consonantes++;
		            }
		        }
		    }
		    lblVocales.Text = "Número de vocales: " + vocales;
		    lblConsonantes.Text = "Número de consonantes: " + consonantes;
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Menu x = new Menu();
			this.Hide();
			x.Show();
		}
	}
}
