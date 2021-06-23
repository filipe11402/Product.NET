using ProductWepApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWepApp.Models
{
    public class Product: IProducts
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public int amount { get; set; }
        [Required]
        public string productName { get; set; }


    }
}
