using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamParlour.Data.Entities
{
    [Table("Toppings")]
    public class Topping
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
