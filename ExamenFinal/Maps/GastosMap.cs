using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ExamenFinal.Maps
{
    public class GastosMap : EntityTypeConfiguration<Gastos>
    {
        public GastosMap()
        {
            ToTable("Gastos");
            HasKey(o => o.IdGasto);

            HasRequired(p => p.Cuenta)
              .WithMany(a => a.Gastos)
              .HasForeignKey(o => o.idCuenta);

        }
    }
}