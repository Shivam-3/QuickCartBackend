using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuickCartAPIDomain.Entities
{
	public class Order
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public User User { get; set; }

		public DateTime OrderDate { get; set; }
		public string Status { get; set; } // Pending, Shipped, Delivered

		public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
		public Guid AddressId { get; set; }
		public Address Address { get; set; }

	}
}
