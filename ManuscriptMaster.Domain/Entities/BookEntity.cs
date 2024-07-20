using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManuscriptMaster.Domain.Entities
{
	public class BookEntity
	{
		public int Id { get; set; }

		public int UserId { get; set; }
		public UserEntity? Author { get; set; }

		public int ModificatorId { get; set; }
		/// <summary>
		/// Модификатр доступа (публично, приватно)
		/// </summary>
		public AccessModificatorEntity? AccessModificator { get; set; }
		public string? Title { get; set; }

		public int RatingId { get; set; }
		public RatingEntity? Rating { get; set; }

		public int GenreId { get; set; }
		public GenreEntity? Genre { get; set; }

		public int StatusId { get; set; }
		public BookStatusEntity? Status { get; set; }
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Обложка книги. Аватар книги.
		/// </summary>
		public string BookCover { get; set; } = string.Empty;
		/// <summary>
		/// Картинки, описывающие книгу.
		/// </summary>
		public ICollection<BookPictureEntity>? Pictures { get; set; }

		public ICollection<CharacterEntity>? Characters { get; set; }


		//public List<Episode>? Episodes { get; set; } = new();
		//public List<Event>? Events { get; set; } = new();
		//public List<Group>? Groups { get; set; } = new();


		//[DeleteBehavior(DeleteBehavior.NoAction)]
		//public List<Book_Idea> Books_Ideas { get; set; } = new();

		//[DeleteBehavior(DeleteBehavior.NoAction)]
		//public List<Book_Character> Books_Characters { get; set; } = new();
	}
}
