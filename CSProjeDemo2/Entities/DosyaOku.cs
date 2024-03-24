using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities
{
    public class DosyaOku
    {
        public static List<Personel> PersonelListesiOku(string dosyaYolu)
        {
            string json = File.ReadAllText(dosyaYolu);
            List<Personel> personeller = JsonConvert.DeserializeObject<List<Personel>>(json);
            return personeller;
        }
    }
}
