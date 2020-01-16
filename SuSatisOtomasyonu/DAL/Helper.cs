using SuSatisOtomasyonu.Entity;
using SuSatisOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuSatisOtomasyonu.DAL
{
    public static class Helper
    {
        public static bool AddMusteri(musteriler m)
        {
            using (SuSatisEntities s = new SuSatisEntities())
            {
                s.musteriler.Add(m);
                if (s.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool AddSiparis(siparisler sip)
        {
            using (SuSatisEntities s = new SuSatisEntities())
            {
                s.siparisler.Add(sip);
                if (s.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        public static bool UpdateMusteri(int musID, string ad, string soyad, string telefon, string adres)
        {
            using (SuSatisEntities s = new SuSatisEntities())
            {
                var pp = s.musteriler.Where(x => x.musteriID == musID).FirstOrDefault();
                pp.adi = ad;
                pp.soyadi = soyad;
                pp.telefon = telefon;
                pp.adres = adres;
                s.Entry(pp).State = System.Data.Entity.EntityState.Modified;
                if (s.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool UpdateSiparis(int sipID, string durum)
        {
            using (SuSatisEntities s = new SuSatisEntities())
            {
                var pp2 = s.siparisler.Where(x => x.siparisID == sipID).FirstOrDefault();
                pp2.durum = durum;
                s.Entry(pp2).State = System.Data.Entity.EntityState.Modified;
                if (s.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool DeleteMusteri(int musID)
        {
            using (SuSatisEntities s = new SuSatisEntities())
            {
                var pp2 = s.musteriler.Where(x => x.musteriID == musID).FirstOrDefault();
                s.musteriler.Remove(pp2);
                if (s.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool DeleteSiparis(int sipID)
        {
            using (SuSatisEntities s = new SuSatisEntities())
            {
                var pp2 = s.siparisler.Where(x => x.siparisID == sipID).FirstOrDefault();
                s.siparisler.Remove(pp2);
                if (s.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }




        public static List<musteriler> MusteriGetList()
        {
            List<musteriler> mls = new List<musteriler>();
            using (SuSatisEntities s = new SuSatisEntities())
            {
                var ff = s.musteriler;
                foreach (var item in ff)
                {
                    musteriler m = new musteriler();
                    m.musteriID = item.musteriID;
                    m.adi = item.adi;
                    m.soyadi = item.soyadi;
                    m.telefon = item.telefon;
                    m.adres = item.adres;
                    mls.Add(m);
                }
                return mls;
            }
        }

        public static List<siparislerModel> SiparisGetList()
        {
            List<siparislerModel> sml = new List<siparislerModel>();
            using (SuSatisEntities en = new SuSatisEntities())
            {
                var fff = en.siparisler;

                foreach (var item in fff)
                {
                    siparislerModel sm = new siparislerModel();
                    sm.siparisID = item.siparisID;
                    sm.musteriler.adi = item.musteriler.adi;
                    sm.musteriler.soyadi = item.musteriler.soyadi;
                    sm.durum = item.durum;
                    sm.musteriler.adres = item.musteriler.adres;
                    sm.tutar = item.tutar;
                    sml.Add(sm);
                }
                return sml;
            }
        }

        public static musteriler GetByID(int musteriID)
        {
            using (SuSatisEntities s=new SuSatisEntities())
            {
                var ff = s.musteriler.Find(musteriID);
                s.SaveChanges();
                return ff;
            }
        }
    }
}
