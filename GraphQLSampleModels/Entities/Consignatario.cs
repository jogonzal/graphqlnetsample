using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class Consignatario : ModeloBase
	{
		[Key]
		public string ConsignatarioClave { get; set; }

		public string ConsignatarioNombre { get; set; }

		public string ConsignatarioDireccion { get; set; }

		public string ConsignatarioCiudad { get; set; }

		public string ConsignatarioCP { get; set; }

		public string ConsignatarioTelefono { get; set; }

		public string ConsignatarioFax { get; set; }

		public Cliente ConsignatarioCliente { get; set; }

		[Required]
		[ForeignKey("ConsignatarioCliente")]
		public string ConsignatarioClienteClave { get; set; }

		public string ConsignatarioEstado { get; set; }
	}
}
