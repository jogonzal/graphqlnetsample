using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class ConceptoCompra : ModeloBase
	{
		[Key]
		public string ConceptoCompraClave { get; set; }

		public Etiqueta ConceptoCompraEtiqueta { get; set; }

		//[Required]
		// Hay conceptos sin etiqueta
		[ForeignKey("ConceptoCompraEtiqueta")]
		public string ConceptoCompraEtiquetaClave { get; set; }

		public decimal ConceptoCompraCantidad { get; set; }

		public decimal ConceptoCompraPrecio { get; set; }

		public bool ConceptoCompraSurtido { get; set; }

		public decimal ConceptoCompraRecibido { get; set; }

		public decimal ConceptoCompraSubtotal { get; set; }

		public Compra ConceptoCompraCompra { get; set; }

		[Required]
		[ForeignKey("ConceptoCompraCompra")]
		public string ConceptoCompraCompraClave { get; set; }

		public Moneda ConceptoCompraMoneda { get; set; }

		public decimal ConceptoCompraDiferencia { get; set; }
	}
}
