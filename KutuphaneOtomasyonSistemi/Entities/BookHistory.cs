using KutuphaneOtomasyonSistemi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi.Entities
{
    public class BookHistory : Book
    {
        public override Status Status { get; set ; }
    }
}
