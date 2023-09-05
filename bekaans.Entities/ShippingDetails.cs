using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekaans.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage ="You need to write your name")]
        public string Name { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(50)]
        public string Addres1 { get; set; }
        [MinLength(10)]
        [MaxLength(50)]
        public string Addres2 { get; set; }
        [MinLength(10)]
        [MaxLength(50)]
        public string Addres3 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        public string isGift { get; set; }
    }
}
