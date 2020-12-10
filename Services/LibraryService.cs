using System;
using System.Collections.Generic;
using apilibrary.db;
using apilibrary.Models;

namespace apilibrary.Services
{
    public class LibraryService
    {
        public IEnumerable<Book> GetAll()
        {
            return FakeDB.Books;
        }

        public Book GetOne(int index)
        {
            return FakeDB.Books[index];
        }

        public Book Create(Book newBook)
        {
            FakeDB.Books.Add(newBook);
            return newBook;
        }

        public string Delete(int index)
        {
            FakeDB.Books.RemoveAt(index);
            return "Book Removed!";
        }

        public Book Edit(int index, Book editedBook)
        {
            FakeDB.Books[index] = editedBook;
            return editedBook;
        }
    }
}