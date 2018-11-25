using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class InventarioSalida : ModeloBase
	{
		[Key]
		public string InventarioSalidaClave { get; set; }

		public ExistenciaInventario InventarioSalidaExistenciaInventario { get; set; }

		[Required]
		[ForeignKey("InventarioSalidaExistenciaInventario")]
		public string InventarioSalidaExistenciaInventarioClave { get; set; }

		public decimal InventarioSalidaCantidad { get; set; }

		public DateTime InventarioSalidaFecha { get; set; }

		public string InventarioSalidaComentarios { get; set; }

		public string InventarioSalidaSalida { get; set; }
	}
}
