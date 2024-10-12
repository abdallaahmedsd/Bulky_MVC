﻿using Bulky.Models.Identity;

namespace Bulky.Models.Orders
{
	public class TbOrder
	{
		public int Id { get; set; }

		public int UserId { get; set; }
		public ApplicationUser User { get; set; } = null!;

		public DateTime OrderDate { get; set; }
		public DateTime ShippingDate { get; set; }
		public decimal OrderTotal { get; set; }

		public string? OrderStatus { get; set; }
		public string? PaymentStatus { get; set; }
		public string? TrackingNumber { get; set; }
		public string? Carrier { get; set; }

		public string? SessionId { get; set; }
		public string? PaymentIntentId { get; set; }

		public DateTime PaymentDate { get; set; }
		public DateOnly PaymentDueDate { get; set; }

		public string PhoneNumber { get; set; } = null!;
		public string StreetAddress { get; set; } = null!;
		public string City { get; set; } = null!;
		public string State { get; set; } = null!;
		public string PostalCode { get; set; } = null!;
		public string Name { get; set; } = null!;

		public ICollection<TbOrderDetail> OrderDetails { get; set; } = [];
	}
}
