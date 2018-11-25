using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class ConceptoPedido : ModeloBase
	{
		[Key]
		public string ConceptoPedidoClave { get; set; }

		public Etiqueta ConceptoPedidoEtiqueta { get; set; }

		//[Required]
		// Hay conceptos sin etiquetas
		[ForeignKey("ConceptoPedidoEtiqueta")]
		public string ConceptoPedidoEtiquetaClave { get; set; }

		public decimal ConceptoPedidoCantidad { get; set; }

		public decimal ConceptoPedidoPrecio { get; set; }

		public bool ConceptoPedidoSurtido { get; set; }

		public decimal ConceptoPedidoCantSurtida { get; set; }

		public decimal ConceptoPedidoSubtotal { get; set; }

		public Pedido ConceptoPedidoPedido { get; set; }

		[Required]
		[ForeignKey("ConceptoPedidoPedido")]
		public string ConceptoPedidoPedidoClave { get; set; }

		public Moneda ConceptoPedidoMoneda { get; set; }

		public bool ConceptoPedidoSeleccionar { get; set; }

		public decimal ConceptoPedidoDiferencia { get; set; }

		public decimal ConceptoPedidoComision { get; set; }
	}
}
