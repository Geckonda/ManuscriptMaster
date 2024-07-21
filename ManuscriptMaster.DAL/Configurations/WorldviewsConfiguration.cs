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
	public class WorldviewsConfiguration : IEntityTypeConfiguration<WorldviewEntity>
	{
		public void Configure(EntityTypeBuilder<WorldviewEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name)
				.HasColumnType("varchar(50)")
				.IsRequired();

			builder
				.HasMany(x => x.Characters)
				.WithOne(x => x.Worldview)
				.HasForeignKey(x => x.WorldviewId);
		}
	}
}
