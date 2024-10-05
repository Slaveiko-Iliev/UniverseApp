﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniverseApp.Infrastructure.Data.Models
{
	[Comment("Character Entity")]
	public class Character
	{
		[Key]
		public int Id { get; set; }

		[Comment("Homeworld")]
		public int PlanetId { get; set; }
		[ForeignKey("PlanetId")]
		public Planet Planet { get; set; } = null!;

		public ICollection<CharacterMovie> CharactersMovies { get; set; } = new HashSet<CharacterMovie>(); //"films": [],
	}
}

//"name": "Luke Skywalker",
//	"height": "172",
//	"mass": "77",
//	"hair_color": "blond",
//	"skin_color": "fair",
//	"eye_color": "blue",
//	"birth_year": "19BBY",
//	"gender": "male",
//	"homeworld": "https://swapi.dev/api/planets/1/",
//	"films": [],
//	"species": [],
//	"vehicles": [
//		"https://swapi.dev/api/vehicles/14/",
//		"https://swapi.dev/api/vehicles/30/"
//	],
//	"starships": [
//		"https://swapi.dev/api/starships/12/",
//		"https://swapi.dev/api/starships/22/"
//	],
//	"created": "2014-12-09T13:50:51.644000Z",
//	"edited": "2014-12-20T21:17:56.891000Z",
//	"url": "https://swapi.dev/api/people/1/"