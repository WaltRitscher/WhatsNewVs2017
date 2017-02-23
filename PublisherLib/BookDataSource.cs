using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PublisherLib {
	public class BookDataSource {

    public Book GetRandomBook() {
      return new Book();
    }

    public Book GetBestSellingBook() {
      return null;
    }
  }
}
