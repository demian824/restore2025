using System;
using API.Entities;
using API.Entities.OrderAggregate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
    public required DbSet<Product> Products { get; set; }
    public required DbSet<Basket> Baskets { get; set; }
    public required DbSet<Order> Orders { get;set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityRole>()
               .HasData(
                    new IdentityRole { Id = "984162d1-e8e8-4e77-ac29-11f13b3f93cf", Name = "Member", NormalizedName ="MEMBER" },
                    new IdentityRole { Id = "59320e91-c661-4848-979c-32abde96faa1",  Name = "Admin", NormalizedName = "ADMIN" }
               );
    }
    
}
