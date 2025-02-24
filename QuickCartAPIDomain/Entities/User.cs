using Microsoft.AspNetCore.Identity;
using System.Net;

namespace QuickCartAPIDomain.Entities
{
	public class User : IdentityUser<Guid>
	{
		public string FullName { get; set; }
		public ICollection<Order> Orders { get; set; } = new List<Order>();
		public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
		public ICollection<Address> Addresses { get; set; } = new List<Address>();
	}
}
