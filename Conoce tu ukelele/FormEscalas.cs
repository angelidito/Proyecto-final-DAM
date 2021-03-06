using Conoce_tu_ukelele.Modelos;

namespace Conoce_tu_ukelele.Forms
{
	public partial class FormEscalas : Form
	{

		private List<RadioButton> escalasRadioButtons = new();
		private readonly List<int> notas = new();
		private static readonly int[] Mayor = { 0, 2, 4, 5, 7, 9, 11 };
		private static readonly int[] Pentatonicamayor = { 0, 2, 4, 5, 9 };
		private static readonly int[] MayordeBlues = { 0, 2, 3, 4, 7, 9 };
		private static readonly int[] Armonicamayor = { 0, 2, 4, 5, 7, 8, 11 };
		private static readonly int[] Doblearmonicamayor = { 0, 1, 4, 5, 7, 8, 11 };
		private static readonly int[] Menor = { 0, 2, 3, 5, 7, 8, 10 };
		private static readonly int[] Pentatonicamenor = { 0, 3, 5, 7, 10 };
		private static readonly int[] MenordeBlues = { 0, 3, 5, 6, 7, 10 };
		private static readonly int[] Menorarmonica = { 0, 2, 3, 5, 7, 8, 11 };
		private static readonly int[] MenordeJazz = { 0, 2, 3, 5, 7, 9, 11 };
		private static readonly int[] Mixolidia = { 0, 2, 4, 5, 7, 9, 10 };
		private static readonly int[] Klexmer = { 0, 1, 4, 5, 7, 8, 10 };
		private static readonly int[] Japonesa = { 0, 1, 5, 7, 8 };
		private static readonly int[] Cromatica = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
		private static readonly Dictionary<string, int[]> escalas = new()
		{
			{ "Mayor", Mayor },
			{ "Pentatónica mayor", Pentatonicamayor },
			{ "Mayor de Blues", MayordeBlues },
			{ "Armonica mayor", Armonicamayor },
			{ "Doble armonica mayor", Doblearmonicamayor },
			{ "Menor", Menor },
			{ "Pentatónica menor", Pentatonicamenor },
			{ "Menor de Blues", MenordeBlues },
			{ "Menor armonica", Menorarmonica },
			{ "Menor de Jazz", MenordeJazz },
			{ "Mixolidia", Mixolidia },
			{ "Klexmer", Klexmer },
			{ "Japonesa", Japonesa },
			{ "Cromática", Cromatica }
		};
		private readonly List<string> colores = new()
		{
			"bb0000",
			"bb6600",
			"bbcc00",
			"ccbb00",//ccdd
			"00bf00",
			"00bb99",
			//"00bbbb",//00dddd
			"0080cc",
			"0033bb",
			"8800bb",
			"ee00cc",//ee00
			"bb0099",
			"bb0055",
		};
		private readonly FormMastil mastil;
		public FormEscalas()
		{
			InitializeComponent();
			escalasRadioButtons.Add(radioButton1);
			escalasRadioButtons.Add(radioButton2);
			escalasRadioButtons.Add(radioButton3);
			escalasRadioButtons.Add(radioButton4);
			escalasRadioButtons.Add(radioButton5);
			escalasRadioButtons.Add(radioButton6);
			escalasRadioButtons.Add(radioButton7);
			escalasRadioButtons.Add(radioButton8);
			escalasRadioButtons.Add(radioButton9);
			escalasRadioButtons.Add(radioButton10);
			escalasRadioButtons.Add(radioButton11);
			escalasRadioButtons.Add(radioButton12);
			escalasRadioButtons.Add(radioButton13);
			escalasRadioButtons.Add(radioButton14);

			mastil = new(colores)
			{
				TopLevel = false
			};

			pnl_mastil.Controls.Add(mastil);
			mastil.Show();
		}

		private void FormEscalas_Load(object sender, EventArgs e)
		{

			notas.Clear();

			string raiz = GetRaiz();
			string escala = GetEscala();

			MostrarDatos(raiz, escala);
		}

		private void MostrarDatos(string raiz, string nombreEscala)
		{
			txtNotas.Clear();
			txtInfo.Clear();

			txtInfo.Text = "Mostrando la escala " + nombreEscala + " de " + raiz + ".";
			//escalas[escala];
			try
			{
				int[] escala = escalas[nombreEscala];

				txtNotas.Text += " " + NotaParser.GetNota(raiz, notas[0]);

				for (int i = 1; i < escala.Length; i++)
				{
					notas.Add((escala[i] + notas[0]) % 12);
					txtNotas.Text += " " + NotaParser.GetNota(raiz, notas[i]);
				}
				txtNotas.Text += " " + NotaParser.GetNota(raiz, notas[0]);

				if (String.Compare(nombreEscala, "Cromática") == 0)
					txtNotas.Text = "Todas";

				if (raiz.Contains('♯'))
					mastil.Sostenido = true;
				else if (raiz.Contains('♭'))
					mastil.Sostenido = false;

				mastil.MostrarNotas(notas, colores);

			}
			catch (KeyNotFoundException)
			{
				txtInfo.Text = "Escala desconocida: " + nombreEscala;
			}
			catch (Exception e)
			{
				txtInfo.Text = e.Message + " " + e.StackTrace;
			}
		}

		private string GetRaiz()
		{
			string raiz;

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
			else if (rd_gs.Checked)
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
		private string GetEscala()
		{
			string escala = "";

			for (int i = 0; i < escalasRadioButtons.Count && String.Compare(escala, "") == 0; i++)
			{
				if (escalasRadioButtons[i].Checked)
					escala = escalasRadioButtons[i].Text;
			}
			return escala;
		}

		private void CheckedChanged(object sender, EventArgs e)
		{
			notas.Clear();

			string raiz = GetRaiz();
			string escala = GetEscala();

			MostrarDatos(raiz, escala);
		}
	}
}
