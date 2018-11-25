using System.ComponentModel.DataAnnotations;
using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class Formato : ModeloBase
	{
		[Key]
		public string FormatoClave { get; set; }

		public string FormatoDescripcion { get; set; }
	}
}
