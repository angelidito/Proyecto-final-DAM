using Conoce_tu_ukelele.Forms;


namespace Conoce_tu_ukelele
{
	public partial class FormAcordes : Form
	{
		private ArrayList<int> notas = new ArrayList<int>();
		public FormAcordes()
		{
			InitializeComponent();
			FormMastil mastil = new FormMastil();
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

			pnlColor.Enabled = true;
			pnlAdd.Enabled = true;
			pnlSus.Enabled = false;

			if (rd_sus.Checked)
			{
				pnlSus.Enabled = true;
				categoria = "sus";
				if (!rd_sus4.Checked && !rd_sus2.Checked)
					rd_sus4.Checked = true;
			}
			else
			{
				rd_nasus.Checked = true;

				if (rd_maj.Checked)
					categoria = "maj";
				else if (rd_min.Checked)
					categoria = "min";
				else if (rd_dim.Checked)
					categoria = "dim";
				else if (rd_aug.Checked)
					categoria = "aug";
				else if (rd_5.Checked)
				{
					pnlColor.Enabled = false;
					pnlAdd.Enabled = false;
					categoria = "5";
					rd_naColor.Checked = true;
					rd_naAdd.Checked = true;
					cantidadNotas-=1 ;

				}
				else
					categoria = "???";
			}

			return categoria;
		}

		private String GetColor()
		{
			pnlAdd.Enabled = true;
			if (rd_69.Checked || rd_9.Checked || rd_maj9.Checked)
			{
				pnlAdd.Enabled = false;
				rd_naAdd.Checked = true;
				cantidadNotas +=2;
			}

			String color;

			if (rd_6.Checked)
				color = "6";
			else if (rd_7.Checked)
				color = "7";
			else if (rd_maj7.Checked)
				color = "maj7";
			else if (rd_69.Checked)
				color = "69";
			else if (rd_9.Checked)
				color = "9";
			else if (rd_maj9.Checked)
				color = "maj9";
			else
				color = "";

			return color;
		}

		private String GetSusN()
		{
			String n;

			if (rd_sus2.Checked)
				n = "2";
			else if (rd_sus4.Checked)
				n = "4";
			else
				n = "";

			return n;
		}

		private String GetAdd()
		{
			String add;

			if (rd_add9.Checked)
				add = "2";
			else
				add = "";

			return add;
		}

		private void CheckedChanged(object sender, EventArgs e)
		{
			cantidadNotas = 3;
			String acorde;
			String raiz = GetRaiz();
			String categoria = GetCategoria();
			String susN = GetSusN();
			String color = GetColor();
			String add = GetAdd();

			if (String.Compare(categoria, "maj") == 0)
				categoria = "";
			else if (String.Compare(categoria, "sus") != 0 && String.Compare(categoria, "5") != 0)
			{
				if (String.Compare(color, "maj7") == 0)
					categoria = "Maj7";
				if (String.Compare(color, "maj7") == 0)
					categoria = "Maj9";
			}
			acorde = raiz + categoria + susN + color + add;
		}
	}
}