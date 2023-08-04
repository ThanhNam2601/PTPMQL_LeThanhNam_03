using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeThanhNam_03.Models;

namespace LeThanhNam_03.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhongBan> PhongBan { get; set; } = default!;

        public DbSet<LeThanhNam_03.Models.NhanVien> NhanVien { get; set; } = default!;
    }
}
