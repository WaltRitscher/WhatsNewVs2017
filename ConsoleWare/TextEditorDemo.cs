using PublisherLib;
using System;

namespace ConsoleWare {

	internal class TextEditorDemo {

		internal void SplitString() {
			// split the string, when press enter.

			string message = "A long example of rambling words. Because I need a long string for this demonstration.";
		}

		public void OutlineAdditions() {
			/* a comment
			   and more
		     another comment
			*/
		}

		internal void EnterKey(Book bestSellingBook, decimal newPrice) {
			// choose what happens when enter key is pressed.
			// when autocompletion list is open

			string result = String.Format("Change the price on the book '{0}' to {1:C}", bestSellingBook.Title, newPrice);

			if (true)
			{
			}
		}
	}
}