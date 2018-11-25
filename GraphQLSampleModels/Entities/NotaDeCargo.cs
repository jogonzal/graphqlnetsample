using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class NotaDeCargo : ModeloBase
	{
		[Key]
		public string NotaDeCargoClave { get; set; }

		public Usuario NotaDeCargoUsuario { get; set; }

		[ForeignKey("NotaDeCargoUsuario")]
		public string NotaDeCargoUsuarioClave { get; set; }

		public DateTime NotaDeCargoFecha { get; set; }

		public Factura NotaDeCargoFactura { get; set; }

		[Required]
		[ForeignKey("NotaDeCargoFactura")]
		public string NotaDeCargoFacturaClave { get; set; }

		public Agente NotaDeCargoAgente { get; set; }

		[ForeignKey("NotaDeCargoAgente")]
		public string NotaDeCargoAgenteClave { get; set; }

		public string NotaDeCargoDescripcion { get; set; }

		public decimal NotaDeCargoIVA { get; set; }

		public decimal NotaDeCargoSubtotal { get; set; }

		public decimal NotaDeCargoCantIva { get; set; }

		public decimal NotaDeCargoTotal { get; set; }

		public NotasEstado NotaDeCargoEstado { get; set; }

		public Moneda NotaDeCargoMoneda { get; set; }

		public decimal NotaDeCargoTipoDeCambio { get; set;}

		public string NotaDeCargoCFDIVersion { get; set; }

		public string NotaDeCargoCFDIFormaDePago { get; set; }
		
		public string NotaDeCargoCFDIMetodoDePago { get; set; }

		public string NotaDeCargoUsoCFDI { get; set; }
	}
}
