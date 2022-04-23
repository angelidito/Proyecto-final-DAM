using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conoce_tu_ukelele.Modelos
{
	public class Afinacion
	{
		private int cuerda1 = 7;
		private int cuerda2 = 0;
		private int cuerda3 = 4;
		private int cuerda4 = 9;

		public Afinacion()
		{
		}
		public Afinacion(int cuerda1, int cuerda2, int cuerda3, int cuerda4)
		{
			this.cuerda1 = cuerda1;
			this.cuerda2 = cuerda2;
			this.cuerda3 = cuerda3;
			this.cuerda4 = cuerda4;
		}
		public void SetAfinacion(int cuerda1, int cuerda2, int cuerda3, int cuerda4)
		{
			this.cuerda1 = cuerda1;
			this.cuerda2 = cuerda2;
			this.cuerda3 = cuerda3;
			this.cuerda4 = cuerda4;
		}

		public int[] GetAfinacion()
		{
			int[] afinacion = { cuerda1, cuerda2, cuerda3, cuerda4 };
			return afinacion;
		}
		public int GetCuerda(int cuerda)
		{
			int value = 0;
			switch (cuerda)
			{
				case 0:
					value = cuerda1;
					break;
				case 1:
					value = cuerda2;
					break;
				case 2:
					value = cuerda3;
					break;
				case 3:
					value = cuerda4;
					break;
			}
			return value;
		}
	}
}
