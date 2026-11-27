/*
 * Creado por SharpDevelop.
 * Usuario: river
 * Fecha: 25/11/2026
 * Hora: 08:02 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_3
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void OrdenamientoDeNúmeroToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ordenamiento orden = new Ordenamiento();
			this.Hide();
			orden.Show();
		}
		
		void MayorMenorYpromedioToolStripMenuItemClick(object sender, EventArgs e)
		{
			mmp m = new mmp();
			this.Hide();
			m.Show();
		}
		
		void PalabraToolStripMenuItemClick(object sender, EventArgs e)
		{
			palabra f = new palabra();
			this.Hide();
			f.Show();
		}
		
		void VocalesconsonantesToolStripMenuItemClick(object sender, EventArgs e)
		{
			VocalConsonante v = new VocalConsonante();
			this.Hide();
			v.Show();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
