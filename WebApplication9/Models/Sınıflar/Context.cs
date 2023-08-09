using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication9.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<Endemik_Bitkiler> Endemik_Bitkilers { get; set; }
        public DbSet<BitkiDurum> bitkiDurums { get; set; }
        public DbSet<EkolojikDurum> EkolojikDurums { get; set; }

    }
}