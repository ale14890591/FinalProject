using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Manager
    {
        [Key]
        public int IdManager { get; set; }
        public string Name { get; set; }
    }
}