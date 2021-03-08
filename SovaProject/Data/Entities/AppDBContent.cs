using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.Entities
{
    public class AppDBContent : IdentityDbContext<DbUser, DbRole, long, IdentityUserClaim<long>,
                                            DbUserRole, IdentityUserLogin<long>,
                                            IdentityRoleClaim<long>, IdentityUserToken<long>>
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Taruf> Taruf {get; set;}
        public DbSet<Category> Category { get; set; }
        public DbSet<UserCartItem> UserCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // использование Fluent API
            base.OnModelCreating(builder);

            builder.Entity<DbUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });
        }
    }
}
