using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.Domain.Entities
{
	public class CharacterEntity
	{
		public int Id { get; set; }
		public int UserId {  get; set; }
		public UserEntity? User { get; set; }
		public int BookId { get; set; }
		public BookEntity? Book { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Gender { get; set; } = string.Empty;
		public int Height { get; set; }
		public int Weight { get; set; }
		public string Personality { get; set; } = string.Empty;

		public string Appearance { get; set; } = string.Empty;
		public string Conflict { get; set; } = string.Empty;

		public string Goals { get; set; } = string.Empty;

		public string Motivation { get; set; } = string.Empty;
		public string History { get; set; } = string.Empty;

		public int WorldviewId { get; set; }
		public WorldviewEntity? Worldview { get; set; }

		public string MainPicture { get; set; } = string.Empty;
		public ICollection<CharacterPictureEntity>? CharacterGallery { get; set; }

		public Dictionary<string, object> CustomAttributes { get; set; } = new Dictionary<string, object>();
	}
}
