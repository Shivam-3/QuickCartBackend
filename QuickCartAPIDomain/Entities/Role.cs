using Microsoft.AspNetCore.Identity;

namespace QuickCartAPIDomain.Entities
{
	public class Role : IdentityRole<Guid>
	{
		public string Description { get; set; }
	}
}
