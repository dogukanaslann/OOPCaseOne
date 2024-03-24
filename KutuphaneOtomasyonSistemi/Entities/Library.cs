using KutuphaneOtomasyonSistemi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi.Entities
{
    public class Library
    {
        private List<Book> _books;
        private List<Member> _members;
        public Library()
        {
            _books = new List<Book>();
            _members = new List<Member>();
        }

        public void BookBorrew(Member member, int bookId)
        {
            Book book = _books.Find(x => x.BookId == bookId);

            if (book != null && book.Status == Status.available)
            {
                member.BorrewedBooks.Add(book);
                book.Status = Status.pawned;

                Console.WriteLine("Kitap başarıyla ödünç alındı!");
            }
            else
            {
                if (book == null)
                {
                    Console.WriteLine("Kitap bulunamadı!");
                }
                else if (book.Status != Status.available)
                {
                    Console.WriteLine("Kitap ödünç alınamaz durumda!");
                }
            }
        }

        public void BookReturn(Member member, int bookId)
        {
            Book book = _books.Find(x => x.BookId == bookId);

            if (book != null && member.BorrewedBooks.Contains(book))
            {
                member.BorrewedBooks.Remove(book);
                book.Status = Status.available;

                Console.WriteLine("Kitap başarıyla iade edildi!");
            }
            else
            {
                if (book == null)
                {
                    Console.WriteLine("Kitap bulunamadı!");
                }
                else
                {
                    Console.WriteLine("Kitap üye tarafından ödünç alınmamış!");
                }
            }
        }
    }
}
