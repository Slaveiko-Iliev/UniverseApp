using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static UniverseApp.Infrastructure.Data.Constants.PlanetConst;

namespace UniverseApp.Infrastructure.Data.Models
{
	[Comment("Planet Entity")]
	public class Planet
	{
		[Key]
		[Comment("Planet Identifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLenght)]
		[Comment("Planet Name")]
		public required string Name { get; set; }

		[Comment("Rotation Period Of Planet")]
		public int RotationPeriod { get; set; } // is nullable?

		[Comment("Orbital Period Of Planet")]
		public int OrbitalPeriod { get; set; } // is nullable?

		[Comment("Climate Of Planet")]
		public string Climate { get; set; } // is nullable?, "climate": "temperate, tropical",

		[Comment("Gravity Of Planet")]
		public string Gravity { get; set; } //"gravity": "1 standard",

		[Comment("Terrain Of Planet")]
		public string Terrain { get; set; } //"terrain": "jungle, rainforests",

		[Comment("Surface Water Of Planet")]
		public int SurfaceWater { get; set; } //"surface_water": "8",

		[Comment("Population Of Planet")]
		public int Population { get; set; }

		public ICollection<Character> Characters { get; set; } //"residents": [],

		public int MovieId { get; set; } // https://swapi.dev/api/films/1/
		[ForeignKey("MovieId")]
		public Movie Movie { get; set; } = null!;

		public string Url { get; set; } // "url": "https://swapi.dev/api/planets/3/"
	}
}

