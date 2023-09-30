using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public partial class CellMasterOnlineBd : DbContext
    {
        public CellMasterOnlineBd(DbContextOptions<CellMasterOnlineBd> options)
            : base(options)
        {
        }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Persona>().HasKey(ci => ci.Id_Persona);
}

    }
}