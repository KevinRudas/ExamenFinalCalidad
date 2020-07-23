using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamenFinal.Maps
{
    public class DBContxt:DbContext
    {
        public IDbSet<Cuenta> Cuentas { get; set; }
        public IDbSet<Gastos> Gastos { get; set; }
        public IDbSet<Ingresos> Ingresos { get; set; }

        public DBContxt()
        {
            Database.SetInitializer<DBContxt>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new GastosMap());
            modelBuilder.Configurations.Add(new IngresosMap());

            modelBuilder.Configurations.Add(new CuentaMap());
            


        }
    }
}