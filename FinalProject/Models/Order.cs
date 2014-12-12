using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public int IdManager { get; set; }
        public int IdCommodity { get; set; }
        public int Sum { get; set; }

        public virtual Client Client { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual Commodity Commodity { get; set; }
    }
}