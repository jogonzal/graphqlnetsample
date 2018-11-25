using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class Usuario : ModeloBase
	{
		[Key]
		public string UsuarioClave { get; set; }

		public string UsuarioNombre { get; set; }

		public bool UsuarioAccesoAdmin { get; set; }

		public bool Usuario_H_M	{ get; set; }

		public int UsuarioPermisoAgentes { get; set; }

		public int UsuarioPermisoConsignatarios { get; set; }

		public int UsuarioPermisoClientes { get; set; }

		public int UsuarioPermisoCortadores { get; set;}

		public int UsuarioPermisoFormatos { get; set; }

		public int UsuarioPermisoSuajes { get; set; }

		public int UsuarioPermisoZonas { get; set; }

		public int UsuarioPermisoEtiquetas { get; set; }

		public int UsuarioPermisoProveedores { get; set; }

		public int UsuarioPermisoMateriales { get; set; }

		public int UsuarioPermisoFacturas { get; set; }

		public int UsuarioPermisoPedidos { get; set; }

		public int UsuarioPermisoCompras { get; set; }

		public int UsuarioPermisoPagos { get; set; }

		public int UsuarioPermisoCheques { get; set; }

		public int UsuarioPermisoNotasCredito { get; set; }

		public int UsuarioPermisoNotasCargo { get; set; }

		public bool UsuarioInventario { get; set; }

		public int UsuarioPermisoInventario { get; set; }

		public int UsuarioPermisoSalidas { get; set; }

		public bool UsuarioEtiquetasAprobacion { get; set; }

		public bool UsuarioVendedor { get; set; }

		public Agente UsuarioAgente { get; set; }

		[ForeignKey("UsuarioAgente")]
		public string UsuarioAgenteClave { get; set; }
	}
}

