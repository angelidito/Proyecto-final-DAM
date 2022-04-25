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
		public FormAcordes()
		{
			InitializeComponent();
			Mastil mastil = new Mastil();
			mastil.TopLevel = false;
			pnl_mastil.Controls.Add(mastil);
			mastil.Show();
		}

		private void FormAcordes_Load(object sender, EventArgs e)
		{

		}

		//  ♯ ♭
		private String GetRaiz()
		{
			String raiz;

			if (rd_a.Checked)
				raiz = "A";
			else if (rd_b.Checked)
				raiz = "B";
			else if (rd_c.Checked)
				raiz = "C";
			else if (rd_d.Checked)
				raiz = "D";
			else if (rd_e.Checked)
				raiz = "E";
			else if (rd_f.Checked)
				raiz = "F";
			else if (rd_g.Checked)
				raiz = "G";
			else if (rd_as.Checked)
				raiz = "A♯";
			else if (rd_cs.Checked)
				raiz = "C♯";
			else if (rd_ds.Checked)
				raiz = "D♯";
			else if (rd_fs.Checked)
				raiz = "F♯";
			else if (rd_gb.Checked)
				raiz = "G♯";
			else if (rd_ab.Checked)
				raiz = "A♭";
			else if (rd_bb.Checked)
				raiz = "B♭";
			else if (rd_db.Checked)
				raiz = "D♭";
			else if (rd_eb.Checked)
				raiz = "E♭";
			else if (rd_gb.Checked)
				raiz = "G♭";
			else
				raiz = "???";

			return raiz;
		}

		private String GetCategoria()
		{
			String categoria;




			categoria = "???";

			return categoria;
		}

		private void CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}