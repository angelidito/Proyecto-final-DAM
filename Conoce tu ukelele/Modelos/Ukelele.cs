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

		public Ukelele()
		{
			SetMastil();
		}

		public Ukelele(Afinacion afinacion)
		{
			SetAfinacion(afinacion);
		}

		public Afinacion Afinacion
		{
			get { return afinacion; }
			set { SetAfinacion(value); }
		}

		private void SetAfinacion(Afinacion afinacion)
		{
			Ukelele.afinacion = afinacion;
			SetMastil();
		}

		public int[,] Mastil
		{
			get { return mastil; }
		}

		private void SetMastil()
		{
			for (int i = 0; i < 4; i++)
				for (int j = 0; j < 19; j++)
					mastil[i, j] = (afinacion.GetCuerda(i) + j) % 12;
		}
	}
}
