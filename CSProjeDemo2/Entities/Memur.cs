using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities
{
    public class Memur : Personel
    {
        public override decimal SaatlikUcret => 500;

        public int MemurDerecesi { get; set; }

        public override decimal MaasHesapla(int calismaSaati)
        {
            decimal anaOdeme = SaatlikUcret * Math.Min(calismaSaati, 180);
            decimal ekMesai = SaatlikUcret * 1.5m * Math.Max(calismaSaati - 180, 0);
            return anaOdeme + ekMesai;
        }
    }
}
