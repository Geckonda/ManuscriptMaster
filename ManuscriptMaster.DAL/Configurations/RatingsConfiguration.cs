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
	public class RatingsConfiguration : IEntityTypeConfiguration<RatingEntity>
	{
		public void Configure(EntityTypeBuilder<RatingEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name)
				.HasColumnType("varchar(50)")
				.IsRequired();

			builder
				.HasMany(x => x.Books)
				.WithOne(x => x.Rating)
				.HasForeignKey(x => x.RatingId);
		}
	}
}
