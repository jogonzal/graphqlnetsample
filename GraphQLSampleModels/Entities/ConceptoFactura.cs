using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class ConceptoFactura : ModeloBase
	{
		[Key]
		public string ConceptoFacturaClave { get; set; }

		public decimal ConceptoFacturaCantidad { get; set; }

		public Etiqueta ConceptoFacturaEtiqueta { get; set; }

		//[Required]
		// Hay conceptos sin etiqueta
		[ForeignKey("ConceptoFacturaEtiqueta")]
		public string ConceptoFacturaEtiquetaClave { get; set; }

		public decimal ConceptoFacturaPrecio { get; set; }

		public bool ConceptoFacturaRevisada { get; set; }

		public Factura ConceptoFacturaFactura { get; set; }

		[Required]
		[ForeignKey("ConceptoFacturaFactura")]
		public string ConceptoFacturaFacturaClave { get; set; }

		public bool ConceptoFacturaSeleccionar { get; set; }

		public Moneda ConceptoFacturaMoneda { get; set; }

		public decimal ConceptoFacturaSubtotal { get; set; }
	}
}
