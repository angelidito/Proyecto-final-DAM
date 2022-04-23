using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conoce_tu_ukelele.Modelos
{
	public static class NotaParser
	{
		private static bool UsarSostenidos(string clave)
		{
			System.Diagnostics.Debug.WriteLine("TODO: UsarSostenidos(): bool");
			return true;
		}

		public static string GetNote(string clave, int value)
		{
			bool sostenidos = UsarSostenidos(clave);
			string nota;
			switch (value)
			{
				case 0:
					nota = "C";
					break;
				case 1:
					nota = sostenidos? "C♯": "D♭";
					break;
				case 2:
					nota = "D";
					break;
				case 3:
					nota = sostenidos? "D♯": "E♭";
					break;
				case 4:
					nota = "E";
					break;
				case 5:
					nota = "F";
					break;
				case 6:
					nota = sostenidos? "F♯": "G♭";
					break;
				case 7:
					nota = "G";
					break;
				case 8:
					nota = sostenidos? "B♯": "A♭";
					break;
				case 9:
					nota = "A";
					break;
				case 10:
					nota = sostenidos? "A♯": "B♭";
					break;
				case 11:
					nota = "B";
					break;
				default:
					nota = "???";
					break;
			}

			return nota;
		}
	}
}
