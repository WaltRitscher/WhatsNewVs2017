using PublisherLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksellerWeb.Controllers {
	public class BookController : Controller {
		// GET: Book
		public ActionResult Index() {
			var dataSource = new PublisherLib.BookDataSource();
			Book book = dataSource.GetRandomBook();

			return View(book);
		}
	}
}