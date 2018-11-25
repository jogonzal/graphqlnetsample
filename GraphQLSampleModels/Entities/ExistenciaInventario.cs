using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepositories.Entities
{
	public class ExistenciaInventario
	{
		[Key]
		public string ExistenciaInventarioClave { get; set; }

		public Etiqueta ExistenciaInventarioEtiqueta { get; set; }

		// [Required]
		// TODO: rehabilitar esto ya que este arreglada la base de datos
		[ForeignKey("ExistenciaInventarioEtiqueta")]
		public string ExistenciaInventarioEtiquetaClave { get; set; }

		public short ExistenciaInventarioArea { get; set; }

		public bool ExisgtenciaInventarioEnBodega { get; set; }

		public string ExistenciaInventarioFactura { get; set; }

		public DateTime ExistenciaInventarioFechaEntrada { get; set; }

		public string ExistenciaInventarioPedido { get; set; }

		public DateTime ExistenciaInventarioFechaSalida { get; set; }

		public string ExistenciaInventarioObservaciones { get; set; }

		public string ExistenciaInventarioLote { get; set; }

		public Usuario ExistenciaInventarioUsuario { get; set; }

		[ForeignKey("ExistenciaInventarioUsuario")]
		public string ExistenciaInventarioUsuarioClave { get; set; }

		public decimal ExistenciaInventarioCantidadInicial { get; set; }

		public decimal ExistenciaInventarioCantidadActual { get; set; }
	}
}
