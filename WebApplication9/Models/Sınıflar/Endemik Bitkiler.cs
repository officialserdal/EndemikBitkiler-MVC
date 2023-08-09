using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebApplication9.Models.Sınıflar
{
    public class Endemik_Bitkiler
    {
        [Key]
        public int İD { get; set; }
        public string açıklama { get; set; }
        public string fotourl { get; set; }
        public string baslik { get; set; }


    }
}