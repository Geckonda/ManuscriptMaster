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
	public class UsersConfiguration : IEntityTypeConfiguration<UserEntity>
	{
		public void Configure(EntityTypeBuilder<UserEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Nickname)
				.HasColumnType("varchar(25)")
				.IsRequired();
			builder.Property(x => x.Login)
				.HasColumnType("varchar(50)")
				.IsRequired();
			builder.HasIndex(x => x.Login)
				.IsUnique();
			builder.Property(x => x.Email)
				.HasColumnType("varchar(50)")
				.IsRequired();
			builder.HasIndex(x => x.Email)
				.IsUnique();
			builder.Property(x => x.Password)
				.HasColumnType("varchar(50)")
				.IsRequired();
			builder.Property(x => x.Avatar)
				.HasColumnType("varchar(255)");

			//Связи
			builder
				.HasOne(x => x.Role)
				.WithMany(x => x.Users)
				.HasForeignKey(x => x.RoleId);

			builder
				.HasMany(x => x.Books)
				.WithOne(x => x.Author)
				.HasForeignKey(x => x.UserId);
			builder
				.HasMany(x => x.Characters)
				.WithOne(x => x.User)
				.HasForeignKey(x => x.UserId);
		}
	}
}
