﻿using Conoce_tu_ukelele.Forms;
using Conoce_tu_ukelele.Modelos;
using System.Collections;

namespace Conoce_tu_ukelele
{
	public partial class FormAcordes : Form
	{
		private List<int> notas = new List<int>();
		private FormMastil mastil;
		private String acorde = "";

		public FormAcordes()
		{
			InitializeComponent();

			mastil = new FormMastil
			{
				TopLevel = false
			};

			pnl_mastil.Controls.Add(mastil);
			mastil.Show();
		}

		private void FormAcordes_Load(object sender, EventArgs e)
		{
			CheckedChanged(null,null);
		}


		private String GetRaiz()
		{
			String raiz;

			if (rd_a.Checked)
			{
				raiz = "A";
				notas.Add(9);
			}
			else if (rd_b.Checked)
			{
				raiz = "B";
				notas.Add(11);
			}
			else if (rd_c.Checked)
			{
				raiz = "C";
				notas.Add(0);
			}
			else if (rd_d.Checked)
			{
				raiz = "D";
				notas.Add(2);
			}
			else if (rd_e.Checked)
			{
				raiz = "E";
				notas.Add(4);
			}
			else if (rd_f.Checked)
			{
				raiz = "F";
				notas.Add(5);
			}
			else if (rd_g.Checked)
			{
				raiz = "G";
				notas.Add(7);
			}
			else if (rd_as.Checked)
			{
				raiz = "A♯";
				notas.Add(10);
			}
			else if (rd_cs.Checked)
			{
				raiz = "C♯";
				notas.Add(1);
			}
			else if (rd_ds.Checked)
			{
				raiz = "D♯";
				notas.Add(3);
			}
			else if (rd_fs.Checked)
			{
				raiz = "F♯";
				notas.Add(6);
			}
			else if (rd_gb.Checked)
			{
				raiz = "G♯";
				notas.Add(8);
			}
			else if (rd_ab.Checked)
			{
				raiz = "A♭";
				notas.Add(8);
			}
			else if (rd_bb.Checked)
			{
				raiz = "B♭";
				notas.Add(10);
			}
			else if (rd_db.Checked)
			{
				raiz = "D♭";
				notas.Add(1);
			}
			else if (rd_eb.Checked)
			{
				raiz = "E♭";
				notas.Add(3);
			}
			else if (rd_gb.Checked)
			{
				raiz = "G♭";
				notas.Add(6);
			}
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
				{
					categoria = "maj";
					notas.Add(4);
					notas.Add(7);
				}
				else if (rd_min.Checked)
				{
					categoria = "min";
					notas.Add(3);
					notas.Add(7);
				}
				else if (rd_dim.Checked)
				{
					categoria = "dim";
					notas.Add(3);
					notas.Add(6);
				}
				else if (rd_aug.Checked)
				{
					categoria = "aug";
					notas.Add(4);
					notas.Add(8);
				}
				else if (rd_5.Checked)
				{
					pnlColor.Enabled = false;
					pnlAdd.Enabled = false;
					categoria = "5";
					rd_naColor.Checked = true;
					rd_naAdd.Checked = true;
					notas.Add(7);
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
			}

			String color;

			if (rd_6.Checked)
			{
				color = "6";
				notas.Add(9);
			}
			else if (rd_7.Checked)
			{
				color = "7";
				notas.Add(10);
			}
			else if (rd_maj7.Checked)
			{
				color = "maj7";
				notas.Add(11);
			}
			else if (rd_69.Checked)
			{
				color = "6/9";
				notas.Add(9);
				notas.Add(2);
			}
			else if (rd_9.Checked)
			{
				color = "9";
				notas.Add(10);
				notas.Add(2);
			}
			else if (rd_maj9.Checked)
			{
				color = "maj9";
				notas.Add(11);
				notas.Add(2);
			}
			else
				color = "";

			return color;
		}

		private String GetSusN()
		{
			String n;

			if (rd_sus2.Checked)
			{
				n = "sus2";
				notas.Add(2);
				notas.Add(7);
			}
			else if (rd_sus4.Checked)
			{
				n = "sus4";
				notas.Add(5);
				notas.Add(7);
			}
			else
				n = "";

			return n;
		}

		private String GetAdd()
		{
			String add;

			if (rd_add9.Checked)
			{
				add = "add9";
				notas.Add(2);
			}
			else
				add = "";

			return add;
		}
		private string GetAcorde()
		{
			notas.Clear();

			String acorde;
			String raiz = GetRaiz();
			String categoria = GetCategoria();
			String susN = GetSusN();
			String color = GetColor();
			String add = GetAdd();

			if (String.Compare(categoria, "maj") == 0 || String.Compare(categoria, "sus") == 0)
				categoria = "";
			else if (String.Compare(categoria, "5") != 0)
			{
				if (String.Compare(color, "maj7") == 0)
					color = "Maj7";
				if (String.Compare(color, "maj9") == 0)
					color = "Maj9";
			}

			acorde = raiz + categoria + color + susN + add;

			return acorde;
		}

		//  ♯ ♭
		private void CheckedChanged(object sender, EventArgs e)
		{
			// FormAcordes
			acorde = GetAcorde();

			lblAcorde.Text = acorde;

			MostrarDatos();

			// FormMastil
			if (acorde.Contains('♯'))
				mastil.Sostenido = true;
			else if (acorde.Contains('♭'))
				mastil.Sostenido = false;

			mastil.MostrarNotas(notas);

		}


		private void MostrarDatos()
		{
			txtNotas.Clear();

			txtNotas.Text += " " + NotaParser.GetNote(acorde, notas[0]);

			for (int i = 1; i < notas.Count; i++)
			{
				notas[i] = (notas[i] + notas[0])% 12;
				txtNotas.Text += " " + NotaParser.GetNote(acorde, notas[i]);
			}

			if (notas.Count > 4)
			{
				int exceso = notas.Count - 4;
				String textoAux = exceso == 1 ? "nota no se podrá tocar" : "notas no se podrán tocar";
				txtInfo.Text = String.Format(
					"El acorde selecionado tiene {0} notas, por lo que {1} {2}. Se recomienda que sean {3} o {4},",
					notas.Count,
					exceso,
					textoAux,
					notas[1],
					notas[2]
					);
			}
			else
				txtInfo.Clear();

		}
	}
}