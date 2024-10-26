﻿using Microsoft.EntityFrameworkCore;

namespace verdeconecta.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Cliente> Clientes { get; set; }
    }
}
