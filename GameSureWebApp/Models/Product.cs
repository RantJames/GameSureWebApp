﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameSureWebApp.Models
{
    public class Product
    {
        [Key]
        public int ProdId { get; set; }
        public string Ptype { get; set; }
        public int Price { get; set; }
        public string PDescription { get; set; }

    }
}