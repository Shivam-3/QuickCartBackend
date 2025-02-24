using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuickCartAPIDomain.Entities;

namespace QuickCartAPIInfrastructure.DbContext
{
	public class AppDbContext : IdentityDbContext<User, Role, Guid>
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<Review> Reviews { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<Order>()
				.HasOne(o => o.User)
				.WithMany(u => u.Orders)
				.HasForeignKey(o => o.UserId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.Entity<OrderItem>()
				.HasOne(oi => oi.Order)
				.WithMany(o => o.OrderItems)
				.HasForeignKey(oi => oi.OrderId);

			builder.Entity<OrderItem>()
				.HasOne(oi => oi.Product)
				.WithMany()
				.HasForeignKey(oi => oi.ProductId)
				.OnDelete(DeleteBehavior.NoAction);


			builder.Entity<CartItem>()
				.HasOne(ci => ci.User)
				.WithMany(u => u.CartItems)
				.HasForeignKey(ci => ci.UserId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.Entity<CartItem>()
				.HasOne(ci => ci.Product)
				.WithMany()
				.HasForeignKey(ci => ci.ProductId);

			builder.Entity<Review>()
				.HasOne(r => r.User)
				.WithMany()
				.HasForeignKey(r => r.UserId);

			builder.Entity<Review>()
				.HasOne(r => r.Product)
				.WithMany()
				.HasForeignKey(r => r.ProductId)
				.OnDelete(DeleteBehavior.NoAction);
		}

	}
}
