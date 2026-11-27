/*
 * Created by SharpDevelop.
 * User: Andy
 * Date: 26/11/2026
 * Time: 09:56 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_3
{
    public partial class Ordenamiento : Form
    {
        public Ordenamiento()
        {
            InitializeComponent();
        }

        void BtnOrdenamientoClick(object sender, EventArgs e)
        {
            int cantidad;
            if (!int.TryParse(txtNumeros.Text, out cantidad)
                || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            string[] valores = txtArreglo.Text.Split(',');

            if (valores.Length != cantidad)
            {
                MessageBox.Show("Debe ingresar exactamente "
                                + cantidad + " números.");
                return;
            }

            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                if (!int.TryParse(valores[i].Trim(), out numeros[i]))
                {
                    MessageBox.Show("Ingrese únicamente números enteros.");
                    return;
                }
            }

            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int auxiliar = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = auxiliar;
                    }
                }
            }

            lblMenor.Text = "Menor a mayor: "
                                 + string.Join(", ", numeros);

            Array.Reverse(numeros);

            lblMayor.Text = "Mayor a menor: "
                                 + string.Join(", ", numeros);
        }
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Menu x = new Menu();
			this.Hide();
			x.Show();
		}
    }
}