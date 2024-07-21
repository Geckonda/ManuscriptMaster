using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.Domain.Entities
{
	public class BookPictureEntity
	{
		public int Id { get; set; }
		public int BookId { get; set; }
		public BookEntity? Book { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Path { get; set; } = string.Empty;
	}
}
