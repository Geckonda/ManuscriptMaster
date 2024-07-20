using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.Domain.Entities
{
	public class UserEntity
	{
		public int Id { get; set; }
		public int RoleId { get; set; }
		public RoleEntity? Role { get; set; } 

		public string Nickname { get; set; } = string.Empty;	

		public string Login { get; set; } = string.Empty;

		public string Email { get; set; } = string.Empty;

		public string Password { get; set; } = string.Empty;
		public string Avatar { get; set; } = string.Empty;

		public ICollection<BookEntity>? Books { get; set; }
		public ICollection<CharacterEntity>? Characters{ get; set; }
	}
}
