using SuSatisOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuSatisOtomasyonu.Model
{
    public class siparislerModel
    {
        public int siparisID { get; set; }
        public int musteriID { get; set; }
        public string durum { get; set; }
        public int tutar { get; set; }
        public System.DateTime tarih { get; set; }

        public musteriler musteriler = new musteriler();
    }
}
