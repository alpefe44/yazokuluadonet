using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccesLayer
{
	public class DALDers
	{
		public static List<EntDers> DersListele()
		{
			List<EntDers> ders = new List<EntDers>();

			SqlCommand listele = new SqlCommand("select * from TBL_DERS", Baglanti.baglanti);

			if (listele.Connection.State != ConnectionState.Open)
			{
				listele.Connection.Open();
			}
			SqlDataReader oku = listele.ExecuteReader();

			while (oku.Read())
			{
				EntDers der = new EntDers();
				der.dersid = Convert.ToInt32(oku["DERSID"].ToString());
				der.dersad = oku["DERSAD"].ToString();
				der.min = int.Parse(oku["DERSMINKONT"].ToString());
				der.max = int.Parse(oku["DERSMAKSKONT"].ToString());

				ders.Add(der);
			}
			oku.Close();
			return ders;

		}

		public static int TalepEkle(EntBasvuru entBasvuru)
		{
			SqlCommand komut = new SqlCommand("insert into TBL_BASVURUFORM (OGRENCIID,DERSID) values(@p1,@p2)", Baglanti.baglanti);

			if (komut.Connection.State != ConnectionState.Open)
			{
				komut.Connection.Open();
			}
			komut.Parameters.AddWithValue("@p1", entBasvuru.ogrid);
			komut.Parameters.AddWithValue("@p2", entBasvuru.dersid);
			return komut.ExecuteNonQuery();
		}
	}
}
