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

        private int _idCounter = 0;
        public int Id { get; set; }
        public int amount { get; set; }
        public string productName { get; set; }

        


    }
}
