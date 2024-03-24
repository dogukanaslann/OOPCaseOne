using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities
{
    public abstract class Personel
    {
        public int PersonelId { get; set; }

        public string PersonelAd { get; set; }

        public string PersonelSoyad { get; set; }

        public string Unvan { get; set; }

        public abstract decimal SaatlikUcret { get; }

        public abstract decimal MaasHesapla(int calismaSaati);
    }
}
