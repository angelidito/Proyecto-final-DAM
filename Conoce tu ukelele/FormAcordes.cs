using Conoce_tu_ukelele.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Conoce_tu_ukelele
{
	public partial class FormAcordes : Form
	{
		public FormAcordes(Mastil mastil)
		{
			InitializeComponent();
			pnl_mastil.Controls.Add(mastil);
			mastil.Show();
		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void FormAcordes_Load(object sender, EventArgs e)
		{

		}
	}
}