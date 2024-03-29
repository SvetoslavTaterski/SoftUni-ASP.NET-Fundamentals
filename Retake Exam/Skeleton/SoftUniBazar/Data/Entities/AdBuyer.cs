﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SoftUniBazar.Data.Entities
{
	public class AdBuyer
	{
		[Required] 
		[ForeignKey(nameof(Buyer))] 
		public string BuyerId { get; set; } = null!;

		public IdentityUser Buyer { get; set; } = null!;

		[Required]
		[ForeignKey(nameof(Ad))]
		public int AdId { get; set; }

		public Ad Ad { get; set; } = null!;
	}
}
