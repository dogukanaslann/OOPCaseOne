using KutuphaneOtomasyonSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi.Interface
{
    public interface IMember
    {
        public int MemberId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        List<Book> BorrewedBooks { get; set; }

         void BorrowBook (Book book);

        void ReturnBook (Book book);


    }
}
