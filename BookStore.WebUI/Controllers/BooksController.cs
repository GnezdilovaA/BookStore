using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Domain.Abstract;
using BookStore.Domain.Entities;

namespace BookStore.WebUI.Controllers
{
    public class BooksController : Controller
    {
        IBookRepository repository;

        public BooksController (IBookRepository repo)
        {
            repository = repo;
        }
      
        public ViewResult Index()
        {
            return View(repository.Books);
        }
        public ViewResult Edit(int bookId)
        {
            Book book = repository.Books
                .FirstOrDefault(g => g.BookId == bookId);
            return View(book);
        }
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                repository.SaveBook(book);
                TempData["message"] = string.Format("Изменения в \"{0}\" были сохранены", book.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(book);
            }
        }
        public ViewResult Create()
        {
            return View("Edit", new Book());
        }
        [HttpPost]
        public ActionResult Delete(int bookId)
        {
            Book deletedBook = repository.DeleteBook(bookId);
            if (deletedBook !=null)
            {
                TempData["massage"] = string.Format("Игра \"{0}\" была удалена", deletedBook.Name);
            }
            return RedirectToAction("Index");
        }

    }
    }
