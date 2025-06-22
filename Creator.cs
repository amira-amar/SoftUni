﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Boardgames.Data.Models
{
	public class Creator
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(7)]
		public string FirstName { get; set; } = null!;

		[Required]
		[MaxLength(7)]
		public string LastName { get; set; } = null!;

		public ICollection<Boardgame> Boardgames { get; set; } = new List<Boardgame>();


	}
}

