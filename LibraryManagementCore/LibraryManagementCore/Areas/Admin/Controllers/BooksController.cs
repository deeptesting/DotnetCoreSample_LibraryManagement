using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryBusinessComponents;
using LibraryManagementCore.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using LibraryBusinessEntities;

namespace LibraryManagementCore.Areas.Admin.Controllers
{


   // [Area("Admin")]
    public class BooksController : BaseAdminController
    {
        private IBookBusinessComponent _bookBusinessComponent;

        public BooksController(IBookBusinessComponent bookBusinessComponent)
        {
            _bookBusinessComponent = bookBusinessComponent;
        } 

        public async Task<IActionResult> Index()
        {
            BookViewModel bookmodel = new BookViewModel() {   BookName = "", Quantity = 2 };

            var ListBooks = await _bookBusinessComponent.GetBooks();
            ViewBag.ListBooks = ListBooks;

            return View(bookmodel);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEdit([Bind("BookId,BookName,Author,Quantity")] BookViewModel bookmodel)
        {
            string BookId = string.Empty;
            
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(bookmodel.BookId))
                {
                    //Update
                    BookId = bookmodel.BookId;
                    bool r = await _bookBusinessComponent.UpdateBook(bookmodel.BookId,bookmodel.BookName, bookmodel.Author, bookmodel.Quantity);
                    if (r)
                    {
                        return Json(GetSuccessErrorMsg(1, "Successfully updated", new { bookId = BookId }));
                    }
                    else
                    {
                        return Json(GetSuccessErrorMsg(-1, "Update is not successfull", new { bookId = BookId }));
                    }
                }
                else
                {
                    BookId = await _bookBusinessComponent.InsertBook(bookmodel.BookName, bookmodel.Author, bookmodel.Quantity);
                    return Json(GetSuccessErrorMsg(1, "Successfully inserted", new { bookId = BookId }));
                }
            }
            else
            {
                return Json(GetSuccessErrorMsg(-1, "Model not valid", new { bookId = "" }));
            }
            //return View("Index",bookmodel);
        }



        [HttpPost]
        public async Task<IActionResult> ReloadLibraryAssets()
        {
            var ListBooks = await _bookBusinessComponent.GetBooks();
            return PartialView("_ListBooksPartial", ListBooks);
        }

        [HttpPost]
        public async Task<IActionResult> LoadEditBookFormDetails(string BookId)
        {
            LibraryAssets BookDetails = await _bookBusinessComponent.GetBookDetails(BookId);
            BookViewModel bookmodel = new BookViewModel() {
                BookId = BookDetails.BookId,
                BookName = BookDetails.BookDetails.BookName,
                Author = BookDetails.BookDetails.Author,
                Quantity = BookDetails.Quantity
            };
            return PartialView("_AddEditBookPartial", bookmodel);
        }

    }
}