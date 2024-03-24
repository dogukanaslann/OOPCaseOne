using KutuphaneOtomasyonSistemi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi.Entities
{
    public class Member : IMember
    {
        public int MemberId { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public List<Book> BorrewedBooks { get; set; } = new();

        public void BorrowBook(Book book)
        {
            
        }

        public void ReturnBook(Book book)
        {
           
        }
    }
}
