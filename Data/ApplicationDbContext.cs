using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BanHang.Models;

namespace BanHang.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BanHang.Models.Product> Product { get; set; }
        public DbSet<BanHang.Models.Bill> Bill { get; set; }
        public DbSet<BanHang.Models.User> User { get; set; }
        public DbSet<BanHang.Models.Evaluate> Evaluate { get; set; }
        public DbSet<BanHang.Models.Permission> Permission { get; set; }
        public DbSet<BanHang.Models.Billdetail> Billdetail { get; set; }
    }
}
