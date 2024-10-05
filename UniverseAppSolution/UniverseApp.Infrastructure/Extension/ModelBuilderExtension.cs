using Microsoft.EntityFrameworkCore;
using UniverseApp.Infrastructure.Data.Configurations;

namespace UniverseApp.Infrastructure.Extension
{
	public static class ModelBuilderExtension
	{
		public static void Seed(this ModelBuilder builder)
		{
			builder.ApplyConfiguration(new MovieConfiguration());
		}
	}
}
