using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class Proveedor : ModeloBase
	{
		[Key]
		public string ProveedorClave { get; set; }

		public string ProveedorNombre { get; set; }

		public string ProveedorDireccion { get; set; }

		public string ProveedorCiudad { get; set; }

		public string ProveedorCP { get; set; }

		public string ProveedorTelefono { get; set; }

		public string ProveedorFax { get; set; }

		public string ProveedorRFC { get; set; }

		public string ProveedorEncargado { get; set; }

		public bool ProveedorEstado { get; set; }

		public string ProveedorANombreDe { get; set; }

		public bool ProveedorAutorizadoIso { get; set; }

		public CuentaGasto ProveedorCuentaGasto { get; set; }

		[ForeignKey("ProveedorCuentaGasto")]
		public string ProveedorCuentaGastoClave { get; set; }
	}
}

