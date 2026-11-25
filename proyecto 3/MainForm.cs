/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 25/11/2026
 * Hora: 07:57 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnIngresarClick(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "Germancito" && txtContraseña.Text == "123456")
			{
				Menu m = new Menu();
				m.Show();
				this.Hide();
			}
		}
	}
}
