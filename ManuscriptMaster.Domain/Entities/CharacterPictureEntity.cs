using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.Domain.Entities
{
	public class CharacterPictureEntity
	{
		public int Id { get; set; }
		public int CharacterId { get; set; }
		public CharacterEntity? Character { get; set; }
		public string Name { get; set; } = string.Empty;
	}
}
