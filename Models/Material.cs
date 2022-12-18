﻿using System.ComponentModel.DataAnnotations;

namespace SOE3MaterialVerwaltung.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public int Stock { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal BuyPrice { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal SellPrice { get; set; }


        public virtual Materialgroup Materialgroup { get; set; }
    }
}
