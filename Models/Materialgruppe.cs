﻿using System.ComponentModel.DataAnnotations;

namespace SOE3MaterialVerwaltung.Models
{
    public class Materialgruppe
    {

        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }

        public virtual ICollection<Material> Materials { get; set;}
    }
}
