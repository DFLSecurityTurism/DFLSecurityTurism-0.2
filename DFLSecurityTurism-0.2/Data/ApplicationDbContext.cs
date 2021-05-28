using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DFLSecurityTurism_0._2.Models;

namespace DFLSecurityTurism_0._2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DFLSecurityTurism_0._2.Models.Inquérito> Inquérito { get; set; }
        public DbSet<DFLSecurityTurism_0._2.Models.Restaurante> Restaurante { get; set; }
        public DbSet<DFLSecurityTurism_0._2.Models.Hotel> Hotel { get; set; }
        public DbSet<DFLSecurityTurism_0._2.Models.AvaliacaoHotel> AvaliacaoHotel { get; set; }
        public DbSet<DFLSecurityTurism_0._2.Models.AvaliacaoRestaurante> AvaliacaoRestaurante { get; set; }
    }
}
