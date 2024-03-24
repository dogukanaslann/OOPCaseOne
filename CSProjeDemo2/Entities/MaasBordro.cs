using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities
{
    public class MaasBordro
    {
        public static void MaaslariHesaplaVeKaydet(List<Personel> personeller)
        {
            foreach (var personel in personeller)
            {
                decimal maas = personel.MaasHesapla(180); // Varsayılan olarak 180 saat üzerinden hesapla
                string tarih = DateTime.Now.ToString("MMMM yyyy");

                string dosyaAdi = $"{personel.PersonelAd}_{DateTime.Now:yyyyMMddHHmmss}.json";
                string dosyaYolu = Path.Combine("MaasBordrolari", dosyaAdi);

                var maasBilgisi = new
                {
                    PersonelIsmi = personel.PersonelAd + " " + personel.PersonelSoyad,
                    CalismaSaati = 180, // Varsayılan olarak 180 saat üzerinden kaydet
                    AnaOdeme = maas,
                    Mesai = 0, // Ek mesai varsayılan olarak 0
                    ToplamOdeme = maas
                };

                string json = JsonConvert.SerializeObject(maasBilgisi, Formatting.Indented);
                File.WriteAllText(dosyaYolu, json);
            }
        }
    }
}
