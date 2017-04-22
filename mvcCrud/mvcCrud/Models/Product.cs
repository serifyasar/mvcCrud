using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcCrud.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProdcutName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

    }


}