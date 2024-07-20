using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.Domain.Entities
{
	public class WorldviewEntity
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public ICollection<CharacterEntity>? Characters { get; set; }
	}
}
