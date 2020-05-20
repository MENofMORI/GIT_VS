using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Data
    {
			static int licznik = 0;

			int IdProdoktu;
			String nazwa;
			String opis;
			float cena;
			int sztuki;
			int kategoria;

		public Data(int idProdoktu, string nazwa, string opis, float cena, int sztuki, int kategoria)
		{
			IdProdoktu = idProdoktu;
			this.nazwa = nazwa;
			this.opis = opis;
			this.cena = cena;
			this.sztuki = sztuki;
			this.kategoria = kategoria;

			licznik++;
		}

		public int IdProdoktu1 { get => IdProdoktu; set => IdProdoktu = value; }
		public string Nazwa { get => nazwa; set => nazwa = value; }
		public string Opis { get => opis; set => opis = value; }
		public float Cena { get => cena; set => cena = value; }
		public int Sztuki { get => sztuki; set => sztuki = value; }
		public int Kategoria { get => kategoria; set => kategoria = value; }

		static int AUTO_INCREMENT()
		{
			return ++licznik;
		}
	}
}
