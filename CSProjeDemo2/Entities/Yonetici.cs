using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities
{
    public class Yonetici : Personel
    {
        public override decimal SaatlikUcret => 500;

        public decimal Bonus { get; set; }

        public override decimal MaasHesapla(int calismaSaati)
        {
            decimal toplamMaas = Math.Max(SaatlikUcret * calismaSaati, 500 * calismaSaati);
            return toplamMaas + Bonus;
        }
    }
}
