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
	public class CharacteresConfiguration : IEntityTypeConfiguration<CharacterEntity>
	{
		public void Configure(EntityTypeBuilder<CharacterEntity> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(c => c.Name)
				.HasColumnType("varchar(100)")
				.IsRequired();
			builder.Property(x => x.Description)
				.HasColumnType("text");
			builder.Property(x => x.Gender)
				.HasColumnType("varchar(100)");
			builder.Property(x => x.Height)
				.HasColumnType("int");
			builder.Property(x => x.Weight)
				.HasColumnType("int");
			builder.Property(x => x.Personality)
				.HasColumnType("text");
			builder.Property(x => x.Appearance)
				.HasColumnType("text");
			builder.Property(x => x.Conflict)
				.HasColumnType("text");
			builder.Property(x => x.Goals)
				.HasColumnType("text");
			builder.Property(x => x.Motivation)
				.HasColumnType("text");
			builder.Property(x => x.History)
				.HasColumnType("text");
			builder.Property(x => x.MainPicture)
				.HasColumnType("varchar(255)");
			builder.Property(x => x.CustomAttributes)
				.HasColumnType("jsonb");

			//Связи
			builder
				.HasOne(x => x.User)
				.WithMany(x => x.Characters)
				.HasForeignKey(x => x.UserId);
			builder
				.HasOne(x => x.Book)
				.WithMany(x => x.Characters)
				.HasForeignKey(x => x.BookId);
			builder
				.HasOne(x => x.Worldview)
				.WithMany(x => x.Characters)
				.HasForeignKey(x => x.WorldviewId);
			builder
				.HasMany(x => x.CharacterGallery)
				.WithOne(x => x.Character)
				.HasForeignKey(x => x.CharacterId);
		}
	}
}
