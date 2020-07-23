using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ExamenFinal.Maps
{
    public class IngresosMap : EntityTypeConfiguration<Ingresos>
    {
        public IngresosMap()
        {
            ToTable("Ingresos");
            HasKey(o => o.IdIngresos);

            HasRequired(p => p.Cuenta)
              .WithMany(a => a.Ingresos)
              .HasForeignKey(o => o.idCuentaI);
        }
    }
}