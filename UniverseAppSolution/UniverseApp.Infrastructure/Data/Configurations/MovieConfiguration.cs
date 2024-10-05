using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniverseApp.Infrastructure.Data.Models;

namespace UniverseApp.Infrastructure.Data.Configurations
{
	public class MovieConfiguration : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			throw new NotImplementedException();
		}
	}
}
