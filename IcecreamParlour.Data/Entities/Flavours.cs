using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IceCreamParlour.Data.Entities
{
    [Table("Flavour")]
    public class Flavour
    {
        [Key]
        public int FlId { get; set; }

        [Required]
        [StringLength(50)]
        public string FlName { get; set; }
        [Required]
        public decimal FlPrice { get; set; }
    }
}
