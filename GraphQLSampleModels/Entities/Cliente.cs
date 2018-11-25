using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class Cliente : ModeloBase
	{
		[Key]
		public string ClienteClave { get; set; }

		public bool ClienteActivo { get; set; }

		public string ClienteRFC { get; set; }

		public string ClienteCalle { get; set; }

		public string ClienteNumeroExterior { get; set; }

		public string ClienteNumeroInterior { get; set; }

		public string ClienteColonia { get; set; }

		public string ClienteLocalidad { get; set; }

		public string ClienteMunicipio { get; set; }

		public string ClienteEstado { get; set; }

		public string ClientePais { get; set; }

		public string ClienteCP { get; set; }

		public string ClienteTelefono { get; set; }

		public string ClienteFax { get; set; }

		public string ClienteMail { get; set; }

		public string ClienteComprador { get; set; }

		public Agente ClienteAgente { get; set; }

		[Required]
		[ForeignKey("ClienteAgente")]
		public string ClienteAgenteClave { get; set; }

		public Zona ClienteZona { get; set; }

		[Required]
		[ForeignKey("ClienteZona")]
		public string ClienteZonaClave { get; set; }

		public string ClientePagos { get; set; }

		public int ClientePlazo { get; set; }

		public string ClienteCondicionesDePago { get; set; }

		public string ClienteRevision { get; set; }

		public decimal ClienteCreditoMaximo { get; set; }

		public Moneda ClientePesos { get; set; }

		public bool ClienteFlete { get; set; }

		public string ClienteTransporte { get; set; }

		public string ClienteDescuento { get; set; }

		public string ClienteLeyenda { get; set; }

		public string ClienteRazonSocial { get; set; }

		public int ClienteAddenda { get; set; }

		public string ClienteNumeroProveedor { get; set; }

		public bool ClienteExtranjero { get; set; }

		public string ClienteNombreCompras { get; set; }

		public string ClienteMailCompras { get; set; }

		public string ClienteNombrePagos { get; set; }

		public string ClienteMailPagos { get; set; }

		public string ClienteNombreFacturas { get; set; }

		public string ClienteMailFacturas { get; set; }

		public string ClienteMedotoDePago { get; set; }

		public string ClienteNumCtaPagoNuevo { get; set; }

		public string ClienteInformacionImprimir { get; set; }

		public bool ClienteCantidadEnMillares { get; set; }

		public string ClienteRequisitosEmbarque { get; set; }

		public string ClienteRequisitosFacturacion { get; set; }

		public string ClienteCFDIFormaDePago { get; set; }

		public string ClienteCFDIMetodoDePago { get; set; }

		public string ClienteUsoCFDI { get; set; }

		public string ClienteCFDINumRegIdTrip { get; set; }

		public string ClienteCFDIPais { get;set;}
	}
}
