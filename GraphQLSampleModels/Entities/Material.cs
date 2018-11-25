using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class Material : ModeloBase
	{
		[Key]
		public string MaterialClave { get; set; }

		public string MaterialNombre { get; set; }

		public Proveedor MaterialProveedor { get; set; }

		// [Required]
		// TODO Rehabilitar esto, hay algunos materiales sin proveedor
		[ForeignKey("MaterialProveedor")]
		public string MaterialProveedorClave { get; set; }

		public Formato MaterialFormato { get; set; }

		//[Required]
		// TODO: Rehabilitar esto - hay algunos materiales sin formato, pero deben de tenerlo
		[ForeignKey("MaterialFormato")]
		public string MaterialFormatoClave { get; set; }
	}
}
