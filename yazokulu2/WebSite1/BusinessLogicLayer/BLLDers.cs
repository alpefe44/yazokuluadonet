using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
	public class BLLDers
	{
		public static List<EntDers> DersListele()
		{
			return DALDers.DersListele();
		}

		public static int TalepEkle(EntBasvuru basvur)
		{
			if(basvur.ogrid != null && basvur.dersid != null)
			{
				return DALDers.TalepEkle(basvur);
			}
			return -1;

		}
	}
}
