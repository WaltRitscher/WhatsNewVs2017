using PublisherLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWare
{
    class RefactorDemo {

		internal void Refactor1() {
			// Simplify object initialization with an initializer
			var b = new Book();
			b.Title = "HLSL Pixel Shaders for WPF and Silverlight Developers";
			b.PublicationDate = DateTime.Now;
			b.CatalogNumber = 44534;
			b.Price = 45.00M;
			b.BookCoverType = CoverType.HardCover;

		}

		internal void Refactor2() {
			// move out variable declarations inline
			var dateString = "2018/11/17";
			DateTime outDate;

			if (DateTime.TryParse(dateString, out outDate))
			{
				Console.WriteLine(outDate);
			}
			else
			{
				Console.WriteLine("Value is not a valid date.");
			}
		}

		internal void Refactor3(Book bestSellingBook, decimal newPrice) {
			//Convert String.Format to string interpolation

			var result = String.Format("Change the price on the book '{0}' to {1:C}", bestSellingBook.Title, newPrice);

		}



		internal void Refactor4(Book bestSellingBook, decimal newPrice) {
			// Simplify null checks and throw expressions using null-coalescing operato


			if (bestSellingBook == null)
			{
				throw new ArgumentNullException(nameof(bestSellingBook));
			}
			else
			{

			}



			var bookTitle = bestSellingBook.Title;

			bookTitle = bestSellingBook.Title ?? throw new ArgumentNullException(nameof(bestSellingBook));
		}

		// Sync filename and type name.
		// Move type to matching file
	}
}
