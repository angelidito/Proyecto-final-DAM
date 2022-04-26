﻿using Conoce_tu_ukelele.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conoce_tu_ukelele.Forms
{
	public partial class FormMastil : Form
	{
		
		private static Label[,] etiquetas = new Label[4, 19];
		private static Ukelele ukelele = new Ukelele();
		private static bool sostenidos = true;

		public void CambiarAfinacion(Afinacion afinacion)
		{
			ukelele.Afinacion = afinacion;
			SetNotas();
		}

		public FormMastil()
		{
			InitializeComponent();
			IncializarArrayEtiquetas();

			ukelele = new Ukelele();

			btn_sostenidos.Text = "♯"; // ♭
			sostenidos = true;

			SetNotas();
		}

		public FormMastil(Afinacion afinacion)
		{
			InitializeComponent();
			IncializarArrayEtiquetas();

			ukelele = new Ukelele(afinacion);

			btn_sostenidos.Text = "♯"; // ♭
			sostenidos = true;

			SetNotas();
		}

		private void SetNotas()
		{
			string clave = sostenidos ? "♯" : "♭";

			for (int i = 0; i < 4; i++)
				for (int j = 0; j < 19; j++)
					etiquetas[i, j].Text = NotaParser.GetNote(clave, ukelele.Mastil[i, j]);
		}

		public bool Sostenido
		{
			get { return sostenidos; }
		}

		private void IncializarArrayEtiquetas()
		{
			etiquetas[0, 0] = label1;
			etiquetas[0, 1] = label2;
			etiquetas[0, 2] = label3;
			etiquetas[0, 3] = label4;
			etiquetas[0, 4] = label5;
			etiquetas[0, 5] = label6;
			etiquetas[0, 6] = label7;
			etiquetas[0, 7] = label8;
			etiquetas[0, 8] = label9;
			etiquetas[0, 9] = label10;
			etiquetas[0, 10] = label11;
			etiquetas[0, 11] = label12;
			etiquetas[0, 12] = label13;
			etiquetas[0, 13] = label14;
			etiquetas[0, 14] = label15;
			etiquetas[0, 15] = label16;
			etiquetas[0, 16] = label17;
			etiquetas[0, 17] = label18;
			etiquetas[0, 18] = label19;
			etiquetas[1, 0] = label20;
			etiquetas[1, 1] = label21;
			etiquetas[1, 2] = label22;
			etiquetas[1, 3] = label23;
			etiquetas[1, 4] = label24;
			etiquetas[1, 5] = label25;
			etiquetas[1, 6] = label26;
			etiquetas[1, 7] = label27;
			etiquetas[1, 8] = label28;
			etiquetas[1, 9] = label29;
			etiquetas[1, 10] = label30;
			etiquetas[1, 11] = label31;
			etiquetas[1, 12] = label32;
			etiquetas[1, 13] = label33;
			etiquetas[1, 14] = label34;
			etiquetas[1, 15] = label35;
			etiquetas[1, 16] = label36;
			etiquetas[1, 17] = label37;
			etiquetas[1, 18] = label38;
			etiquetas[2, 0] = label39;
			etiquetas[2, 1] = label40;
			etiquetas[2, 2] = label41;
			etiquetas[2, 3] = label42;
			etiquetas[2, 4] = label43;
			etiquetas[2, 5] = label44;
			etiquetas[2, 6] = label45;
			etiquetas[2, 7] = label46;
			etiquetas[2, 8] = label47;
			etiquetas[2, 9] = label48;
			etiquetas[2, 10] = label49;
			etiquetas[2, 11] = label50;
			etiquetas[2, 12] = label51;
			etiquetas[2, 13] = label52;
			etiquetas[2, 14] = label53;
			etiquetas[2, 15] = label54;
			etiquetas[2, 16] = label55;
			etiquetas[2, 17] = label56;
			etiquetas[2, 18] = label57;
			etiquetas[3, 0] = label58;
			etiquetas[3, 1] = label59;
			etiquetas[3, 2] = label60;
			etiquetas[3, 3] = label61;
			etiquetas[3, 4] = label62;
			etiquetas[3, 5] = label63;
			etiquetas[3, 6] = label64;
			etiquetas[3, 7] = label65;
			etiquetas[3, 8] = label66;
			etiquetas[3, 9] = label67;
			etiquetas[3, 10] = label68;
			etiquetas[3, 11] = label69;
			etiquetas[3, 12] = label70;
			etiquetas[3, 13] = label71;
			etiquetas[3, 14] = label72;
			etiquetas[3, 15] = label73;
			etiquetas[3, 16] = label74;
			etiquetas[3, 17] = label75;
			etiquetas[3, 18] = label76;
		}

		private void Mastil_Load(object sender, EventArgs e)
		{

		}

		private void btn_sostenidos_Click(object sender, EventArgs e)
		{
			btn_sostenidos.Text = sostenidos ? "♭" : "♯";
			sostenidos = !sostenidos;
			SetNotas();
		}

		
	}
}