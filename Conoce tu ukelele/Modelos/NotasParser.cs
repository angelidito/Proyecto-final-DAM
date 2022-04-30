namespace Conoce_tu_ukelele.Modelos
{
	public static class NotaParser
	{
		private static bool UsarSostenidos(string clave)
		{
			if (clave.Contains('♯'))
				return true;
			else if (clave.Contains('♭'))
				return false;
			else
				return true;
		}

		public static string GetNota(string clave, int value)
		{
			bool sostenidos = UsarSostenidos(clave);
			string nota;
			switch (value % 12)
			{
				case 0:
					nota = "C";
					break;
				case 1:
					nota = sostenidos ? "C♯" : "D♭";
					break;
				case 2:
					nota = "D";
					break;
				case 3:
					nota = sostenidos ? "D♯" : "E♭";
					break;
				case 4:
					nota = "E";
					break;
				case 5:
					nota = "F";
					break;
				case 6:
					nota = sostenidos ? "F♯" : "G♭";
					break;
				case 7:
					nota = "G";
					break;
				case 8:
					nota = sostenidos ? "G♯" : "A♭";
					break;
				case 9:
					nota = "A";
					break;
				case 10:
					nota = sostenidos ? "A♯" : "B♭";
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



		public static int GetValorNota(string raiz)
		{
			if (String.Compare(raiz, "C") == 0) return 0;
			else if (String.Compare(raiz, "D") == 0) return 2;
			else if (String.Compare(raiz, "E") == 0) return 4;
			else if (String.Compare(raiz, "F") == 0) return 5;
			else if (String.Compare(raiz, "G") == 0) return 7;
			else if (String.Compare(raiz, "A") == 0) return 9;
			else if (String.Compare(raiz, "B") == 0) return 11;
			else if (String.Compare(raiz, "C♯") == 0) return 1;
			else if (String.Compare(raiz, "D♭") == 0) return 1;
			else if (String.Compare(raiz, "D♯") == 0) return 3;
			else if (String.Compare(raiz, "E♭") == 0) return 3;
			else if (String.Compare(raiz, "F♯") == 0) return 6;
			else if (String.Compare(raiz, "G♭") == 0) return 6;
			else if (String.Compare(raiz, "G♯") == 0) return 8;
			else if (String.Compare(raiz, "A♭") == 0) return 8;
			else if (String.Compare(raiz, "A♯") == 0) return 10;
			else if (String.Compare(raiz, "B♭") == 0) return 10;
			else if (String.Compare(raiz, "C#") == 0) return 1;
			else if (String.Compare(raiz, "Db") == 0) return 1;
			else if (String.Compare(raiz, "D#") == 0) return 3;
			else if (String.Compare(raiz, "Eb") == 0) return 3;
			else if (String.Compare(raiz, "F#") == 0) return 6;
			else if (String.Compare(raiz, "Gb") == 0) return 6;
			else if (String.Compare(raiz, "G#") == 0) return 8;
			else if (String.Compare(raiz, "Ab") == 0) return 8;
			else if (String.Compare(raiz, "A#") == 0) return 10;
			else if (String.Compare(raiz, "Bb") == 0) return 10;
			else return -1;
		}
	}
}
