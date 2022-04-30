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
			int valor = 0;
			switch (cuerda)
			{
				case 0:
					valor = cuerda1;
					break;
				case 1:
					valor = cuerda2;
					break;
				case 2:
					valor = cuerda3;
					break;
				case 3:
					valor = cuerda4;
					break;
			}
			return valor;
		}
		public void SetCuerda(int cuerda, int valor)
		{
			switch (cuerda)
			{
				case 0:
					cuerda1 = valor;
					break;
				case 1:
					cuerda2 = valor;
					break;
				case 2:
					cuerda3 = valor;
					break;
				case 3:
					cuerda4 = valor;
					break;
			}
		}
	}
}
