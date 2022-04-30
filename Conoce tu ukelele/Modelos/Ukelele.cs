﻿using Conoce_tu_ukelele.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conoce_tu_ukelele.Modelos
{
	public class Ukelele
	{
		private static Afinacion afinacion = new Afinacion();
		private static int[,] mastil = new int[4, 19];
		private static FormMastil? form = null;

		public Ukelele(FormMastil form)
		{
			SetMastil();
			Ukelele.form = form;
		}

		public Ukelele(Afinacion afinacion)
		{
			SetAfinacion(afinacion);
		}

		public static Afinacion Afinacion
		{
			get { return afinacion; }
			set { SetAfinacion(value); }
		}

		private static void SetAfinacion(Afinacion afinacion)
		{
			Ukelele.afinacion = afinacion;
			SetMastil();
			form?.AfinacionCambiada();
		}

		public static int[,] Mastil
		{
			get { return mastil; }
		}

		private static void SetMastil()
		{
			for (int i = 0; i < 4; i++)
				for (int j = 0; j < 19; j++)
					mastil[i, j] = (afinacion.GetCuerda(i) + j) % 12;
		}
	}
}
