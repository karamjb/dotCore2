using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
    }
}
