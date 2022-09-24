using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkle(EntOgrenci p)
        {
            if(p.ograd != null && p.ogrsoyad !=null && p.ogrnumara != null && p.ogrsifre != null && p.ogrmail != null)
            {
                return OgrenciDAL.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntOgrenci> OgrenciListele()
        {
            return OgrenciDAL.OgrenciListele();
        }

        public static bool OgrenciSilBLL(int x)
        {
            if(x != null)
            {
                return OgrenciDAL.OgrenciSil(x);
            }
            return false;
        }

        public static List<EntOgrenci> OgrenciDetay(int x)
        {
                return OgrenciDAL.OgrenciDetay(x);
        }

        public static bool OgrenciGuncelle(EntOgrenci ogr)
        {
            if(ogr.ograd != null && ogr.ogrsoyad != null && ogr.ogrnumara != null && ogr.ogrmail != null && ogr.ogrsifre != null)
            {
                return OgrenciDAL.OgrenciGuncelle(ogr);
            }
            return false;
        }
    }
}
