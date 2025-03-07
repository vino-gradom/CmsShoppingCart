﻿using CmsShoppingCart.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace CmsShoppingCart.Infrastructure
{
    public class CmsShoppingCartContext : DbContext
    {
        public CmsShoppingCartContext([NotNull] DbContextOptions<CmsShoppingCartContext> options) : base(options) { }

        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CmsShoppingCart.Model.CartItem> CartItem { get; set; }
        public DbSet<CmsShoppingCart.Model.CartViewModel> CartViewModel { get; set; }
    }
}
