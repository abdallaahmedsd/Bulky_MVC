﻿using Bulky.Models.Common;
using Bulky.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
	public class TbCompany
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public AddressInfo AddressInfo { get; set; } = null!;
        public string? PhoneNumber { get; set; }

		public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
