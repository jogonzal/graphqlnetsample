using DataRepositories.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepositories.Entities
{
	public class SuajeEtiqueta : ModeloBase
	{
		[ForeignKey("Etiqueta")]
		public string EtiquetaClave { get; set; }
		public Etiqueta Etiqueta { get; set; }

		[ForeignKey("Suaje")]
		public string SuajeClave { get; set; }
		public Suaje Suaje { get; set; }
	}
}
