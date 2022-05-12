using Conoce_tu_ukelele.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conoce_tu_ukelele.Forms
{
	public partial class DialogAfinacion : Form
	{
		private static readonly string pattern = "^[ABCDEFG][#b♯♭]?$";
		private static readonly Regex regex = new(pattern);
		private readonly Afinacion afinacion;

		public DialogAfinacion()
		{
			InitializeComponent();
			afinacion = Ukelele.Afinacion;
			txt1.Text = NotaParser.GetNota("", afinacion.GetCuerda(0));
			txt2.Text = NotaParser.GetNota("", afinacion.GetCuerda(1));
			txt3.Text = NotaParser.GetNota("", afinacion.GetCuerda(2));
			txt4.Text = NotaParser.GetNota("", afinacion.GetCuerda(3));
		}


		private void Txt_TextChanged(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			TratarTexto(t);
		}

		private void TratarTexto(TextBox t)
		{
			if (!regex.Match(t.Text).Success)
			{
				if (t == txt1)
					t.Text = NotaParser.GetNota("", afinacion.GetCuerda(0));
				else if (t == txt2)
					t.Text = NotaParser.GetNota("", afinacion.GetCuerda(1));
				else if (t == txt3)
					t.Text = NotaParser.GetNota("", afinacion.GetCuerda(2));
				else if (t == txt4)
					t.Text = NotaParser.GetNota("", afinacion.GetCuerda(3));
				return;
			}

			else
			{
				if (t == txt1)
					afinacion.SetCuerda(0, NotaParser.GetValorNota(t.Text));
				else if (t == txt2)
					afinacion.SetCuerda(1, NotaParser.GetValorNota(t.Text));
				else if (t == txt3)
					afinacion.SetCuerda(2, NotaParser.GetValorNota(t.Text));
				else if (t == txt4)
					afinacion.SetCuerda(3, NotaParser.GetValorNota(t.Text));
			}
			test.Text = NotaParser.GetNota("", afinacion.GetCuerda(0)) + "" +
					NotaParser.GetNota("", afinacion.GetCuerda(1)) + "" +
					NotaParser.GetNota("", afinacion.GetCuerda(2)) + "" +
					NotaParser.GetNota("", afinacion.GetCuerda(3));
		}

		private void Aceptar_Click(object sender, EventArgs e)
		{
			Ukelele.Afinacion = afinacion;
			Close();
		}
		private void Cancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Txt_TextChanged(object sender, MouseEventArgs e)
		{
			TextBox t = (TextBox)sender;
			TratarTexto(t);
		}
	}
}
