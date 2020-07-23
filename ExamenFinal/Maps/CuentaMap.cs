using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ExamenFinal.Maps
{
    public class CuentaMap : EntityTypeConfiguration<Cuenta>
    {
        public CuentaMap()
        {
            ToTable("Cuenta");
            HasKey(o => o.idCuenta);


        }
    }
}