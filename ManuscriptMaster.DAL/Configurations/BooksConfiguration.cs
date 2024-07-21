using ManuscriptMaster.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.DAL.Configurations
{
	public class BooksConfiguration : IEntityTypeConfiguration<BookEntity>
	{
		public void Configure(EntityTypeBuilder<BookEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Title)
				.HasColumnType("varchar(100)")
				.IsRequired();
			builder.Property(x => x.Description)
				.HasColumnType("text");
			builder.Property(x => x.BookCover)
				.HasColumnType("varchar(255)");

			//Связи
			builder
				.HasOne(x => x.Author)
				.WithMany(x => x.Books)
				.HasForeignKey(x => x.UserId);
			builder
				.HasOne(x => x.AccessModificator)
				.WithMany(x => x.Books)
				.HasForeignKey(x => x.ModificatorId);
			builder
				.HasOne(x => x.Rating)
				.WithMany(x => x.Books)
				.HasForeignKey(x => x.RatingId);
			builder
				.HasOne(x => x.Genre)
				.WithMany(x => x.Books)
				.HasForeignKey(x => x.GenreId);
			builder
				.HasOne(x => x.Status)
				.WithMany(x => x.Books)
				.HasForeignKey(x => x.StatusId);

			builder
				.HasMany(x => x.Characters)
				.WithOne(x => x.Book)
				.HasForeignKey(x => x.BookId);
			builder
				.HasMany(x => x.Pictures)
				.WithOne(x => x.Book)
				.HasForeignKey(x => x.BookId);
		}
	}
}
