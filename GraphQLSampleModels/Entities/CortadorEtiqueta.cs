using DataRepositories.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepositories.Entities
{
	public class CortadorEtiqueta : ModeloBase
	{
		[ForeignKey("Etiqueta")]
		public string EtiquetaClave { get; set; }
		public Etiqueta Etiqueta { get; set; }

		[ForeignKey("Cortador")]
		public string CortadorClave { get; set; }
		public Cortador Cortador { get; set; }
	}
}
