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
	internal class RolesConfiguration : IEntityTypeConfiguration<RoleEntity>
	{
		public void Configure(EntityTypeBuilder<RoleEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name)
				.HasColumnType("varchar(50)")
				.IsRequired();

			builder
				.HasMany(x => x.Users)
				.WithOne(x => x.Role)
				.HasForeignKey(x => x.RoleId);
		}
	}
}
