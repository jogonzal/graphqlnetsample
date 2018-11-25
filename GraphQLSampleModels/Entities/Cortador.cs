using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class Cortador : ModeloBase
	{
		[Key]
		public string CortadorClave { get; set; }

		public string CortadorDescripcion { get; set; }

		public decimal CortadorMedidaPulg { get; set; }

		public short CortadorEngrane { get; set; }

		public byte CortadorRodillo { get; set; }

		public byte CortadorTipo { get; set; }

		public bool CortadorEstado { get; set; }

		public ICollection<Etiqueta> SuajeEtiquetas { get; set; }
	}
}
