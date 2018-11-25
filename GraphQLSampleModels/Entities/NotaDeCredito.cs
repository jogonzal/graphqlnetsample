using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class NotaDeCredito : ModeloBase
	{
		[Key]
		public string NotaDeCreditoClave { get; set; }

		public Usuario NotaDeCreditoUsuario { get; set; }

		[ForeignKey("NotaDeCreditoUsuario")]
		public string NotaDeCreditoUsuarioClave { get; set; }

		public DateTime NotaDeCreditoFecha { get; set; }

		public Factura NotaDeCreditoFactura { get; set; }

		[Required]
		[ForeignKey("NotaDeCreditoFactura")]
		public string NotaDeCreditoFacturaClave { get; set; }

		public Agente NotaDeCreditoAgente { get; set; }

		[ForeignKey("NotaDeCreditoAgente")]
		public string NotaDeCreditoAgenteClave { get; set; }

		public string NotaDeCreditoDescripcion { get; set; }

		public decimal NotaDeCreditoSubtotal { get; set; }

		public decimal NotaDeCreditoIVA { get; set; }

		public decimal NotaDeCreditoTotal { get; set; }

		public NotasEstado NotaDeCreditoEstado { get; set; }

		public string NotaDeCreditoSerie { get; set; }

		public string NotaDeCreditoAprobacion { get; set; }

		public decimal NotaDeCreditoTipoDeCambio { get; set; }

		public Moneda NotaDeCreditoMoneda { get; set; }

		public DateTime NotaDeCreditoFechaTimbrado { get; set; }

		public string NotaDeCreditoSelloSAT { get; set; }

		public string NotaDeCreditoSelloCFDI { get; set; }

		public string NotaDeCreditoFolioFiscal { get; set; }

		public bool NotaDeCreditoCFDI { get; set; }

		public bool NotaDeCreditoTimbrada { get; set; }

		public string NotaDeCreditoCFDIVersion { get; set; }

		public string NotaDeCreditoCFDIFormaDePago { get; set; }

		public string NotaDeCreditoCFDIMetodoDePago { get; set; }

		public string NotaDeCreditoUsoCFDI { get; set; }
	}
}
