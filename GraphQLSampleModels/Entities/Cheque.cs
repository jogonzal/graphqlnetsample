using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class Cheque : ModeloBase
	{
		[Key]
		public string ChequeClave { get; set; }

		public DateTime ChequeFecha { get; set; }

		public string ChequeNumeroDeCheque { get; set; }

		public Proveedor ChequeProveedor { get; set; }

		[Required]
		[ForeignKey("ChequeProveedor")]
		public string ChequeProveedorClave { get; set; }

		public string ChequeANombreDe { get; set; }

		public string ChequeDescripcion { get; set; }

		public string ChequeFacturaPagada { get; set; }

		public string ChequeCuentaDeGasto { get; set; }

		public decimal ChequeTotalAPagar { get; set;}

		public decimal ChequeCantIva { get; set; }

		public Moneda ChequePesos { get; set; }
	}
}
