using System.ComponentModel.DataAnnotations;

namespace DataRepositories.Entities
{
	public class Pantone
	{
		[Key]
		public string PantoneClave { get; set; }

		public string PantoneDescripcion { get; set; }
	}
}
