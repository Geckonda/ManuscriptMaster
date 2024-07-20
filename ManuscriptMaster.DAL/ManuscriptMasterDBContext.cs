using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManuscriptMaster.Domain.Entities;

namespace ManuscriptMaster.DAL
{
	public class ManuscriptMasterDBContext : DbContext
	{
        public ManuscriptMasterDBContext(DbContextOptions<ManuscriptMasterDBContext>options)
            :base(options)
        {
            
        }
        public DbSet<AccessModificatorEntity> AccessModificators => Set<AccessModificatorEntity>();
        public DbSet<BookEntity> Books => Set<BookEntity>();
        public DbSet<BookPictureEntity> BookPictures => Set<BookPictureEntity>();
        public DbSet<BookStatusEntity> BookStatuses => Set<BookStatusEntity>();
        public DbSet<CharacterEntity> Characters => Set<CharacterEntity>();
        public DbSet<CharacterPictureEntity> CharacterPictures => Set<CharacterPictureEntity>();
        public DbSet<EventEntity> Events => Set<EventEntity>();
        public DbSet<GenreEntity> Genres => Set<GenreEntity>();
        public DbSet<RatingEntity> Rating => Set<RatingEntity>();
        public DbSet<RoleEntity> Role => Set<RoleEntity>();
        public DbSet<UserEntity> Users => Set<UserEntity>();
        public DbSet<WorldviewEntity> Worldview => Set<WorldviewEntity>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

		}
	}
}
