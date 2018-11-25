using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class Estacion : ModeloBase
	{
		[Key]
		public string EstacionClave { get; set; }

		public string EstacionMarca { get; set; }

		public string EstacionBlade { get; set; }

		public decimal EstacionAnilox { get; set; }

		public string EstacionRodillo { get; set; }

		public string EstacionComentarios { get; set; }

		public int EstacionPosicion { get; set; }

		public Pantone EstacionPantone { get; set; }

		//[Required]
		// Este campo no es requerido
		[ForeignKey("EstacionPantone")]
		public string EstacionPantoneClave { get; set;}

		public Etiqueta EstacionEtiqueta { get; set; }

		[Required]
		[ForeignKey("EstacionEtiqueta")]
		public string EstacionEtiquetaClave { get; set; }
	}
}
