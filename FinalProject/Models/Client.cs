using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }
        public string Name { get; set; }
    }
}