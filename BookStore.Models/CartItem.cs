﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    //Customer-Book many to many

    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        public int CustomerID { get; set; }

        public int BookID { get; set; }
        public int Quantity { get; set; }


        public Book? Book { get; set; }

        public Customer? Customer { get; set; }

    }
}
