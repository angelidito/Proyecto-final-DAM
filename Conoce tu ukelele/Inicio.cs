using FontAwesome.Sharp;

namespace Conoce_tu_ukelele.Forms
{
	public partial class Inicio : Form
	{
		public static FormAcordes formAcordes = new FormAcordes();
		public static FormEscalas formEscalas = new FormEscalas();
		private static IconMenuItem MenuActivo = null;
		private static Form FormularioActivo = null;

		public Inicio()
		{
			InitializeComponent();
			AbrirFormulario(MenuItemAcordes, formAcordes);
			//int k = 1;
			//for (int i = 0; i < 4; i++)
			//{
			//	for (int j = 0; j < 19; j++)
			//	{
			//		System.Diagnostics.Debug.WriteLine("etiquetas[" + i + ", " + j + "] = label" + k++ + ";");
			//	}
			//}
		}
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
				//FormularioActivo.Close();
				FormularioActivo.Hide();
			}


			FormularioActivo = formulario;
			formulario.TopLevel = false;
			formulario.FormBorderStyle = FormBorderStyle.None;
			formulario.Dock = DockStyle.Fill;
			formulario.BackColor = Color.SteelBlue;
			contenedor.Controls.Add(formulario);
			formulario.Show();
		}

		private void salirbtn_Click(object sender, EventArgs e)
		{
			formAcordes.Close();
			formEscalas.Close();
			this.Close();
		}

		private void MenuAcordes_Click(object sender, EventArgs e)
		{
			AbrirFormulario(MenuItemAcordes, formAcordes);
		}

		private void MenuEscalas_Click(object sender, EventArgs e)
		{
			AbrirFormulario(MenuItemEscalas, formEscalas);
		}

		private void MenuItemAfinacion_Click(object sender, EventArgs e)
		{
			DialogAfinacion dialog = new();
			dialog.ShowDialog();
		}


	}
}
