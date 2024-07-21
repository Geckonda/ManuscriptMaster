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
	public class CharacterPicturesConfiguration : IEntityTypeConfiguration<CharacterPictureEntity>
	{
		public void Configure(EntityTypeBuilder<CharacterPictureEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name)
				.HasColumnType("varchar(50)")
				.IsRequired();
			builder.Property(x => x.Path)
				.HasColumnType("varchar(255)");

			builder
				.HasOne(x => x.Character)
				.WithMany(x => x.CharacterGallery)
				.HasForeignKey(x => x.CharacterId);
		}
	}
}
