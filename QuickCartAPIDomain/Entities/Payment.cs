namespace QuickCartAPIDomain.Entities
{
	public class Payment
	{
		public Guid Id { get; set; }

		public Guid OrderId { get; set; }
		public Order Order { get; set; }

		public string PaymentMethod { get; set; } // Credit Card, PayPal, etc.
		public bool IsSuccessful { get; set; }
		public DateTime PaymentDate { get; set; }

	}
}
