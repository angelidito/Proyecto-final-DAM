using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conoce_tu_ukelele.Modelos;
using FontAwesome.Sharp;

namespace Conoce_tu_ukelele.Forms
{
	public partial class Inicio : Form
	{
		private static IconMenuItem MenuActivo = null;
		private static Form FormularioActivo = null;

		public Inicio()
		{
			InitializeComponent();

			//int k = 1;
			//for (int i = 0; i < 4; i++)
			//{
			//	for (int j = 0; j < 19; j++)
			//	{
			//		System.Diagnostics.Debug.WriteLine("etiquetas[" + i + ", " + j + "] = label" + k++ + ";");
			//	}
			//}
		}

		//public static int[,] GetThisMastil()
		//{

		//}


		private void Inicio_Load(object sender, EventArgs e)
		{

		}

		private void AbrirFormulario(IconMenuItem menu, Form formulario)
		{
			if (MenuActivo != null)
			{
				MenuActivo.BackColor = Color.White;
			}
			menu.BackColor = Color.Silver;
			MenuActivo = menu;

			if (FormularioActivo != null)
			{
				FormularioActivo.Close();
			}

			FormularioActivo = formulario;
			formulario.TopLevel = false;
			formulario.FormBorderStyle = FormBorderStyle.None;
			formulario.Dock = DockStyle.Fill;
			formulario.BackColor = Color.SteelBlue;
			contenedor.Controls.Add(formulario);
			formulario.Show();
		}

		//private void menuusarios_Click(object sender, EventArgs e)
		//{
		//    AbrirFormulario(MenuAcordes, new frmProductos());
		//}



		private void salirbtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MenuAcordes_Click(object sender, EventArgs e)
		{
			AbrirFormulario(MenuItemAcordes, new FormAcordes());
		}

		private void MenuItemEscalas_Click(object sender, EventArgs e)
		{
			//AbrirFormulario(MenuItemEscalas, new frmProductos());

		}

		private void MenuItemAfinacion_Click(object sender, EventArgs e)
		{
			//AbrirFormulario(MenuItemAfinacion, new frmProductos());

		}
	}
}
