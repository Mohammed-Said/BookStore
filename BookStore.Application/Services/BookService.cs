﻿using BookStore.Application.Contracts;
using BookStore.Models;

namespace BookStore.Application.Services
{
    public class BookService : IBookService
    {
        IBookRepository _BookRepository { get; set; }
        public BookService(IBookRepository bookRepository) =>
          _BookRepository = bookRepository;

        public List<Book> GetAllPagination(int num, int pageIndex) =>
          _BookRepository.GetAll().Skip(num * (pageIndex - 1)).Take(num).ToList();


        public List<Book> GetBooksByName(string name, int num, int pageIndex) =>
          _BookRepository.GetAll().Where(b => b.Name.Contains(name)).Skip(num * (pageIndex - 1)).Take(num).ToList();


        public Book GetBookById(int id) => _BookRepository.GetById(id);


        public bool AddBook(Book book)
        {
            bool isAdded = _BookRepository.Create(book);
            if (isAdded)
                _BookRepository.Save();
            return isAdded;
        }


        public bool DeleteBook(int bookId)
        {
            Book book=GetBookById(bookId);
            bool isDeleted = _BookRepository.Delete(book);
            if (isDeleted)
                _BookRepository.Save();
            return isDeleted;
        }
        public bool UpdateBook(Book book)
        {
            Book updBook= GetBookById(book.Id);
            updBook.Name = book.Name;
            updBook.Price = book.Price;
            updBook.Description = book.Description;
            updBook.BookImg = book.BookImg;
            updBook.Stock = book.Stock;
            bool isUpdated = _BookRepository.Update(updBook);
            if (isUpdated)
                _BookRepository.Save();
            return isUpdated;

        }
        public List<Book> GetByCategoryName(string name, int num, int pageIndex) =>
         _BookRepository.GetByCategory(name).ToList().Skip(num * (pageIndex - 1)).Take(num).ToList();


        public int GetCount()
        {
            int count = _BookRepository.GetAll().Count();
            return (int)Math.Ceiling(count / 10.0);
        }
        public int GetSearchCount(string name)
        {
            int count = _BookRepository.GetAll().Where(b => b.Name.Contains(name)).Count();
            return (int)Math.Ceiling(count / 10.0);
        }
        public int GetCountByCategory(string name)
        {
            int count = _BookRepository.GetCountByCategory(name);
            return(int)Math.Ceiling(count / 10.0);
        }
    }
}
