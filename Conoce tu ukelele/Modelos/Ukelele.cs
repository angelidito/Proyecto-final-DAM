using Conoce_tu_ukelele.Forms;

namespace Conoce_tu_ukelele.Modelos
{
	public class Ukelele
	{
		private static Afinacion afinacion = new Afinacion();
		private static int[,] mastil = new int[4, 19];
		private static List<FormMastil> formsMastils = new();


		public static void Initialize(FormMastil form)
		{
			SetMastil();
			formsMastils.Add(form);
		}

		//public Ukelele(Afinacion afinacion)
		//{
		//	SetAfinacion(afinacion);
		//}

		public static Afinacion Afinacion
		{
			get { return afinacion; }
			set { SetAfinacion(value); }
		}

		private static void SetAfinacion(Afinacion afinacion)
		{
			Ukelele.afinacion = afinacion;
			SetMastil();

			foreach (FormMastil form in formsMastils)
			{
				form.AfinacionCambiada();
			}
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
