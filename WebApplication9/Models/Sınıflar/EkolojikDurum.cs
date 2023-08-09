using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication9.Models.Sınıflar
{
    public class EkolojikDurum
    {
        [Key]
        public int İD { get; set; }
        public string Ekolojikİşev { get; set; }
        public string BilimselÇalışma { get;set; }
    }
}