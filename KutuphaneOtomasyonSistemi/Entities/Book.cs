using KutuphaneOtomasyonSistemi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi.Entities
{
    public abstract class Book
    {
        public int BookId { get; set; }

        public string ISBN { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime PublishedYear { get; set; }

        public abstract Status Status { get; set; }

    }
}
