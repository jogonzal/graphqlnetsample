using System.ComponentModel.DataAnnotations;
using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class Agente : ModeloBase
	{
		[Key]
		public string AgenteClave { get; set; }

		public string AgenteNombre { get; set; }

		public string AgenteDireccion { get; set; }

		public string AgenteCD_EDO_PAIS { get; set; }

		public string AgenteCP { get; set; }

		public string AgenteTelefono {get;set;}

		public string AgenteFax { get; set; }

		public decimal AgenteComision { get; set; }

		public bool AgenteEstado { get; set; }
	}
}

