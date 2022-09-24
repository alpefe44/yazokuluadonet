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
    public class OgrenciDAL
    {
        public static int OgrenciEkle(EntOgrenci p)
        {
            SqlCommand ekle = new SqlCommand("insert into TBL_OGRENCI (ograd,ogrsoyad,ogrnumara,OGRMAIL,OGRSIFRE) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.baglanti);
            if(ekle.Connection.State != ConnectionState.Open)
            {
                ekle.Connection.Open();
            }
            ekle.Parameters.AddWithValue("@p1",p.ograd);
            ekle.Parameters.AddWithValue("@p2", p.ogrsoyad);
            ekle.Parameters.AddWithValue("@p3",p.ogrnumara);
            ekle.Parameters.AddWithValue("@p4", p.ogrmail);
            ekle.Parameters.AddWithValue("@p5", p.ogrsifre);

            return ekle.ExecuteNonQuery();

        }

        public static List<EntityLayer.EntOgrenci> OgrenciListele()
        {
            List<EntityLayer.EntOgrenci> ogrenci = new List<EntOgrenci>();

            SqlCommand listele = new SqlCommand("select * from TBL_OGRENCI", Baglanti.baglanti);

            if(listele.Connection.State != ConnectionState.Open)
            {
                listele.Connection.Open();  
            }
            SqlDataReader oku = listele.ExecuteReader();

            while (oku.Read())
            {
                EntOgrenci entOgrenci = new EntOgrenci();
                entOgrenci.ogrid = Convert.ToInt32(oku["OGRID"].ToString());
                entOgrenci.ograd = oku["OGRAD"].ToString();
                entOgrenci.ogrsoyad = oku["OGRSOYAD"].ToString();
                entOgrenci.ogrnumara = oku["OGRNUMARA"].ToString();
                entOgrenci.ogrmail = oku["OGRMAIL"].ToString();
                entOgrenci.ogrsifre = oku["OGRSIFRE"].ToString();
                entOgrenci.ogrbakiye = Convert.ToDouble(oku["OGRBAKIYE"].ToString());

                ogrenci.Add(entOgrenci);
            }
            oku.Close();
            return ogrenci;
            
        }


        public static bool OgrenciSil(int x)
        {
            SqlCommand sil = new SqlCommand("delete from TBL_OGRENCI where OGRID = @p1", Baglanti.baglanti);

			if (sil.Connection.State != ConnectionState.Open)
			{
				sil.Connection.Open();
			}

            sil.Parameters.AddWithValue("@p1", x);

            return sil.ExecuteNonQuery() > 0;

		}

		public static List<EntityLayer.EntOgrenci> OgrenciDetay(int x)
		{
			List<EntityLayer.EntOgrenci> ogrenci = new List<EntOgrenci>();

			SqlCommand listele = new SqlCommand("select * from TBL_OGRENCI where OGRID = @P1", Baglanti.baglanti);

			if (listele.Connection.State != ConnectionState.Open)
			{
				listele.Connection.Open();
			}
            listele.Parameters.AddWithValue("@P1", x);
			SqlDataReader oku = listele.ExecuteReader();

			while (oku.Read())
			{
				EntOgrenci entOgrenci = new EntOgrenci();
				entOgrenci.ograd = oku["OGRAD"].ToString();
				entOgrenci.ogrsoyad = oku["OGRSOYAD"].ToString();
				entOgrenci.ogrnumara = oku["OGRNUMARA"].ToString();
				entOgrenci.ogrmail = oku["OGRMAIL"].ToString();
				entOgrenci.ogrsifre = oku["OGRSIFRE"].ToString();
				entOgrenci.ogrbakiye = Convert.ToDouble(oku["OGRBAKIYE"].ToString());

				ogrenci.Add(entOgrenci);
			}
			oku.Close();
			return ogrenci;

		}

        public static bool OgrenciGuncelle(EntOgrenci ent)
        {
            SqlCommand komut = new SqlCommand("update TBL_OGRENCI set OGRAD = @p1,OGRSOYAD = @p2 , OGRNUMARA = @p3 , OGRMAIL = @p4 , OGRSIFRE = @p5 where OGRID = @p6", Baglanti.baglanti);

            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1", ent.ograd);
            komut.Parameters.AddWithValue("@p2", ent.ogrsoyad);
            komut.Parameters.AddWithValue("@p3", ent.ogrnumara);
            komut.Parameters.AddWithValue("@p4", ent.ogrmail);
            komut.Parameters.AddWithValue("@p5", ent.ogrsifre);
            komut.Parameters.AddWithValue("@p6", ent.ogrid);

            return komut.ExecuteNonQuery() > 0;
            


        }
    }
}
