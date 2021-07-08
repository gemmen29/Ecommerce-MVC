﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Category")]
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
