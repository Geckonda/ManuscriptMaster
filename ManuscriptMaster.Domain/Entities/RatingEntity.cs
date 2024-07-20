using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.Domain.Entities
{
	public class RatingEntity
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public ICollection<BookEntity>? Books { get; set; }
	}
}
