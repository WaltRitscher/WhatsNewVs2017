using PublisherLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWare {
	class StyleDemo {
		internal void PreferVar() {
			// prefer explicit type declare for built-in types
			var flowerName = "Daffodil";
			Console.WriteLine(flowerName);

			// prefer var when variable type is apparent
			var book = new Book();

			var source = new BookDataSource();
			Book bestSeller = source.GetBestSellingBook();
		}

		public void camelCaseMethodNames() {

			if (true)
				Console.WriteLine("true");


		}
	}
}
