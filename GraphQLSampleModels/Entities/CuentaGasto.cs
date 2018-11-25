using System.ComponentModel.DataAnnotations;
using DataRepositories.Entities.Base;

namespace DataRepositories.Entities
{
	public class CuentaGasto : ModeloBase
	{
		[Key]
		public string CuentaGastoClave { get; set; }

		public string CuentaGastoDescripcion { get; set; }
	}
}
