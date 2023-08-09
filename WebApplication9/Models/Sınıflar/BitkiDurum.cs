using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication9.Models.Sınıflar
{
    public class BitkiDurum
    {
        [Key]
        public int İD { get; set; }
        public String TehditDurumu { get; set; }
        public string KorumaDurumu { get; set; }
        public string BitkiAdi { get; set; }
    }
}