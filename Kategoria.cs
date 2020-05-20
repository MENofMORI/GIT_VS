using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Kategoria
    {
		int idKategori;
		String nazwa;

		List<int> potkategia;

		public int IdKategori { get => idKategori; set => idKategori = value; }
		public string Nazwa { get => nazwa; set => nazwa = value; }

		public Kategoria(int idKategori, String nazwa)
		{
			this.idKategori = idKategori;
			this.nazwa = nazwa;
			this.potkategia = new List<int>();
		}

		public void addPotkategia(int potkategia)
		{
			this.potkategia.Add(potkategia);
		}
	}
}
