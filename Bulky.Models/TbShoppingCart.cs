﻿using Bulky.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models
{
	public class TbShoppingCart
	{
        public int Id { get; set; }

        public int BookId { get; set; }
        public TbBook Book { get; set; } = null!;

        public int Quantity { get; set; }

        public int UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        [NotMapped]
        public decimal Price { get; set; }
    }
}
