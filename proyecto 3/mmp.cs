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
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Menu x = new Menu();
			this.Hide();
			x.Show();
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			int tamaño;
		    tamaño = int.Parse(txtCantidad.Text);
		    int[] numeros = new int[tamaño];
		    string[] datos = txtSerie.Text.Split(',');
		    int mayor, menor, suma = 0;
		    double promedio;
		    for (int i = 0; i < tamaño; i++)
		    {
		        numeros[i] = int.Parse(datos[i].Trim());
		        suma += numeros[i];
		    }
		    mayor = numeros[0];
		    menor = numeros[0];
		    for (int i = 0; i < tamaño; i++)
		    {
		        if (numeros[i] > mayor)
		        {
		            mayor = numeros[i];
		        }
		        if (numeros[i] < menor)
		        {
		            menor = numeros[i];
		        }
		    }
		    promedio = (double)suma / tamaño;
		    lblRespuesta.Text = "Número mayor: " + mayor + "\nNúmero menor: " + menor + "\nPromedio: " + promedio;
		}
	}
}
