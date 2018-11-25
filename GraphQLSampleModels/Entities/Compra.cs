using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class Compra : ModeloBase
	{
		[Key]
		public string CompraClave { get; set; }

		public Usuario CompraUsuario { get; set; }

		[ForeignKey("CompraUsuario")]
		public string CompraUsuarioClave { get; set; }

		public Proveedor CompraProveedor { get; set; }

		[Required]
		[ForeignKey("CompraProveedor")]
		public string CompraProveedorClave { get; set; }

		public string CompraTransporte { get; set; }

		public decimal CompraDescuentoPorcentaje { get; set; }

		public Consignatario CompraConsignatario { get; set; }

		[ForeignKey("CompraConsignatario")]
		public string CompraConsignatarioClave { get; set; }

		public decimal CompraIVA { get; set; }

		public decimal CompraSubtotal { get; set; }

		public decimal CompraDescuento { get; set; }

		public decimal CompraFlete { get; set; }

		public decimal CompraTotal { get; set; }

		public DateTime CompraFecha { get; set;}

		public decimal CompraCantMill { get; set; }

		public string CompraComentarios { get; set; }

		public decimal CompraTipoCambio { get; set; }

		public Moneda CompraMoneda { get; set; }

		public EstadoCompra CompraEstado { get; set; }

		public bool CompraAprobado { get; set; }
	}
}
