namespace QuickCartAPIDomain.Entities
{
	public class Product
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int Stock { get; set; }
		public string ImageUrl { get; set; }

		// Relations
		public Guid CategoryId { get; set; }
		public Category Category { get; set; }

		public Guid SellerId { get; set; }
		public User Seller { get; set; }

	}
}
