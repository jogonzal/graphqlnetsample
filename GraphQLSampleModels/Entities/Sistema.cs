using System.ComponentModel.DataAnnotations;
using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class Sistema : ModeloBase
	{
		[Key]
		public int SistemaClave { get; set; }

		public string SistemaEmpresa { get; set; }

		public string SistemaRFC { get; set; }

		public string SistemaCalle { get; set; }

		public string SistemaNumeroExt { get; set; }

		public string SistemaNumeroInt { get; set; }

		public string SistemaColonia { get; set; }

		public string SistemaLocalidad { get; set; }

		public string SistemaMunicipio { get; set; }

		public string SistemaEstado { get; set; }

		public string SistemaPais { get; set; }

		public string SistemaReferencia { get; set; }

		public string SistemaCP { get; set; }

		public string SistemaLeyenda { get; set; }

		public decimal SistemaIVA { get; set; }

		public decimal SistemaDolar { get; set; }

		public string SistemaEmpDat { get; set; }

		public short SistemaLogo { get; set; }

		public string SistemaSerieFacturas { get; set; }

		public string SistemaSerieNotasDeCredito { get; set; }

		public string SistemaSerieCargos { get; set; }

		public int SistemaAñoFacturacion { get; set; }

		public int SistemaAñoNotasDeCredito { get; set; }

		public int SistemaAñoCargos { get; set; }

		public string SistemaAprobacionFacturas { get; set; }

		public string SistemaAprobacionNotasDeCreditos { get; set; }

		public string SistemaAprobacionCargos { get; set; }

		public int SistemaFolioFacturacion { get; set; }

		public int SistemaFolioNotasDeCredito { get; set; }

		public int SistemaFolioCargos { get; set; }

		public string SistemaCertificado { get; set; }

		public string SistemaDirKey { get; set; }

		public string SistemaDirCertificado { get; set; }

		public string SistemaPass { get; set; }

		public string SistemaDirXML { get; set; }

		public string SistemaDirExcel { get; set; }

		public string SistemaDirPDF { get; set; }

		public string SistemaRFCExtranjero { get; set; }

		public string SistemaTelefono { get; set; }

		public string SistemaMailFacturas { get; set; }

		public string SistemaPasswordMailFacturas { get; set; }

		public bool SistemaMailSSL { get; set; }

		public int SistemaMailPuerto { get; set; }

		public bool SistemaEnviarCopia { get; set; }

		public string SistemaServidorSMTP { get; set; }

		public bool SistemaCalcularComision { get; set; }

		public string SistemaCorreo { get; set; }

		public string SistemaPagina { get; set; }

		public bool SistemaCFDI { get; set; }

		public string SistemaCFDILugarExpedicion { get; set; }

		public string SistemaCFDIRegimenFiscal { get; set; }

		public bool SistemaCFDI33 { get; set; }
	}
}
