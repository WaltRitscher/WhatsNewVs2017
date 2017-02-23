using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PublisherLib {
	public class Book : Publication {
		#region Properties
		public decimal Price { get; set; }
		public Author Author { get; set; }
		public int CatalogNumber { get; set; }
		#endregion

		const Decimal BOOK_MAX_PRICE = 120;
		public CoverType BookCoverType { get; set; }


		public event EventHandler<EventArgs> BookUpdated;
		public event EventHandler<EventArgs> BookArchived;

		
		internal void UpdatePrice(int BookID, decimal newPrice) {
			var bookAuthor = new Author();
			if (newPrice < 0)
			{
				Price = newPrice;
			}
		 
			// call another method
			Console.WriteLine("Done");
			Price = CapPriceAtMaximum(newPrice);
		}
		private decimal CapPriceAtMaximum(decimal currentPrice) {



			// use the private field
			Price = 100M;

			if (currentPrice > 120M)
			{
				return 120M;
			}
			else
			{
				return currentPrice;
			}


		}
		private decimal CalculateBuyerDiscount(decimal currentPrice, BuyerType buyerType) {

			switch (buyerType)
			{
				case BuyerType.Retail:
					currentPrice = Price;
					break;
				case BuyerType.Wholesale:
					currentPrice = Price * .9M;
					break;
				case BuyerType.Academic:
					currentPrice = Price * .8M;
					break;
				case BuyerType.Goverment:
					currentPrice = Price * .85M;
					break;
				default:
					break;
			}
			return currentPrice;
		}
	}

	public enum BuyerType {
		Retail,
		Wholesale,
		Academic,
		Goverment
	}
	public enum CoverType {
		HardCover,
		Paperback,
		Electronic
	}

}
