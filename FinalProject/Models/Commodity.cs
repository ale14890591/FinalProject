using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Commodity
    {
        [Key]
        public int IdCommodity { get; set; }
        public string Name { get; set; }
    }
}