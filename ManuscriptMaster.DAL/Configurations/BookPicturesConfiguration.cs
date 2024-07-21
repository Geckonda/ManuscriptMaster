using ManuscriptMaster.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.DAL.Configurations
{
	public class BookPicturesConfiguration : IEntityTypeConfiguration<BookPictureEntity>
	{
		public void Configure(EntityTypeBuilder<BookPictureEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name)
				.HasColumnType("varchar(50)")
				.IsRequired();
			builder.Property(x => x.Path)
				.HasColumnType("varchar(255)");

			builder
				.HasOne(x => x.Book)
				.WithMany(x => x.Pictures)
				.HasForeignKey(x => x.BookId);
		}
	}
}
