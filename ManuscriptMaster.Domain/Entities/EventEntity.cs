using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.Domain.Entities
{
	public class EventEntity
	{
		public int Id { get; set; }

		public int BookId { get; set; }
		public BookEntity? Book { get; set; }
		public string? Title { get; set; }

		public string? Description { get; set; }
		public DateTime Beginning { get; set; }
		public DateTime Ending { get; set; }
		public bool ChekhovsGun { get; set; }
		public bool IsHidden { get; set; }
		public string? Icon { get; set; }
		public string? Colour { get; set; }

	}
}
