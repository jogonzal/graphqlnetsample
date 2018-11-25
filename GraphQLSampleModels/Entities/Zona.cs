using System.ComponentModel.DataAnnotations;
using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class Zona : ModeloBase
	{
		[Key]
		public string ZonaClave { get; set; }

		public string ZonaNombre { get; set; }

		public string ZonaDescripcion { get; set; }
	}
}
