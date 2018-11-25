using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class Pago : ModeloBase
	{
		[Key]
		public string PagoClave { get; set; }

		public Usuario PagoUsuario { get; set; }

		[ForeignKey("PagoUsuario")]
		public string PagoUsuarioClave { get; set; }

		public DateTime PagoFecha { get; set; }

		public Factura PagoFactura { get; set; }

		[Required]
		[ForeignKey("PagoFactura")]
		public string PagoFacturaClave { get; set; }

		public Agente PagoAgente { get; set; }

		[ForeignKey("PagoAgente")]
		public string PagoAgenteClave { get; set; }

		public PagoTipo PagoTipo { get; set; }

		public string PagoDescripcion { get; set; }

		public decimal PagoCantidad { get; set; }

		public bool PagoComisionPagada { get; set; }

		public decimal PagoComNew { get; set; }

		public decimal PagoCantComision { get; set; }

		public DateTime PagoFechaComision { get; set; }

		public decimal PagoNeto { get; set; }

		public decimal PagoComision { get; set; }

		public Moneda PagoMoneda { get; set; }

		public decimal PagoTipoDeCambio { get; set; }
	}
}
