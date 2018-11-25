using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class Pedido : ModeloBase
	{
		[Key]
		public string PedidoClave { get; set; }

		public Usuario PedidoUsuario { get; set; }

		[ForeignKey("PedidoUsuario")]
		public string PedidoUsuarioClave { get; set; }

		public Cliente PedidoCliente { get; set; }

		[Required]
		[ForeignKey("PedidoCliente")]
		public string PedidoClienteClave { get; set; }

		public Agente PedidoAgente { get; set; }

		[ForeignKey("PedidoAgente")]
		public string PedidoAgenteClave { get; set; }

		public decimal PedidoComision { get; set; }

		public int PedidoPlazo { get; set; }

		public string PedidoTransporte { get; set; }

		public decimal PedidoDescuentoPorcentaje { get; set; }

		public string PedidoPedCliente { get; set; }

		public Consignatario PedidoConsignatario { get; set; }

		[ForeignKey("PedidoConsignatario")]
		public string PedidoConsignatarioClave { get; set; }

		public DateTime PedidoFechaCancelacion { get; set; }

		public decimal PedidoIVA { get; set; }

		public decimal PedidoSubtotal { get; set; }

		public decimal PedidoDescuento { get; set; }

		public decimal PedidoFlete { get; set; }

		public decimal PedidoCantIVA { get; set; }

		public decimal PedidoTotal { get; set; }

		public DateTime PedidoFecha { get; set; }

		public DateTime PedidoFechaOrdenCompra { get; set; }

		public decimal PedidoCantMill { get; set; }

		public PedidoEstado PedidoEstado { get; set; }

		public decimal PedidoTipoDeCambio { get; set; }

		public Moneda PedidoMoneda { get; set; }

		public bool PedidoCalcularComision { get; set; }
	}
}
