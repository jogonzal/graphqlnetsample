using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class Factura : ModeloBase
	{
		[Key]
		public string FacturaClave { get; set; }

		public FacturaEstado FacturaEstado { get; set; }

		public DateTime FacturaFecha { get; set; }

		public Pedido FacturaPedido { get; set; }

		[ForeignKey("FacturaPedido")]
		public string FacturaPedidoClave { get; set; }

		public Cliente FacturaCliente { get; set; }

		[Required]
		[ForeignKey("FacturaCliente")]
		public string FacturaClienteClave { get; set; }

		public Agente FacturaAgente { get; set; }

		[ForeignKey("FacturaAgente")]
		public string FacturaAgenteClave { get; set; }

		public decimal FacturaComision { get; set; }

		public decimal FacturaPlazo { get; set; }

		public string FacturaTransporte { get; set; }

		public string FacturaGuia { get; set; }

		public string FacturaLeyenda { get; set; }

		public decimal FacturaDescuento { get; set; }

		public string FacturaPedCliente { get; set; }

		public Consignatario FacturaConsignatario { get; set; }

		[ForeignKey("FacturaConsignatario")]
		public string FacturaConsignatarioClave { get; set; }

		public decimal FacturaIVA { get; set; }

		public decimal FacturaSubtotal { get; set; }

		public decimal FacturaSubtotalDescuento { get; set; }

		public decimal FacturaFlete { get; set; }

		public decimal FacturaCantIva { get; set; }

		public decimal FacturaTotal { get; set; }

		public decimal FacturaCantidadTotal { get; set; }

		public Usuario FacturaUsuario { get; set; }

		[ForeignKey("FacturaUsuario")]
		public string FacturaUsuarioClave { get; set; }

		public decimal FacturaAbonos { get; set; }

		public decimal FacturaTotnCre { get; set; }

		public decimal FacturaTipoCambio { get; set; }

		public string FacturaSerie { get; set; }

		public DateTime FacturaFechaHora { get; set; }

		public DateTime FacturaFechaVencimiento { get; set; }

		public decimal FacturaSaldo { get; set; }

		public Moneda FacturaMoneda { get; set; }

		public string FacturaMetodoDePago { get; set; }

		public string FacturaClientesNumCtaDePagoNuevo { get; set; }

		public  string FacturaInformacionImprimir { get; set; }

		public bool FacturaGenerada { get; set; }

		public bool FacturaEnviada { get; set; }

		public bool FacturaCalcularComision { get; set; }

		public bool FacturaCFDI { get; set; }

		public string FacturaFolioFiscal { get; set; }

		public DateTime FacturaFechaTimbrado { get; set; }

		public string FacturaSelloSAT { get; set; }

		public string FacturaSelloCFDI { get; set; }

		public string FacturaCFDIVersion { get; set; }

		public string FacturaCFDIFormaDePago { get; set; }

		public string FacturaCFDIMetodoDePago { get; set; }

		public string FacturaUsoCFDI { get; set; }
	}
}
