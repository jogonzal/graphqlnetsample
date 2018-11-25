using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class Suaje : ModeloBase
	{
		[Key]
		public string SuajeClave { get; set; }

		public string SuajeDescripcion { get; set; }

		public decimal SuajeAncho_p { get; set; }

		public decimal SuajeAncho_mm { get; set; }

		public decimal SuajeLargo_p { get; set; }

		public decimal SuajeLargo_mm { get; set; }

		public decimal SuajeSepejep { get; set; }

		public decimal SuajeSepdesap { get; set; }

		public decimal SuajeAlpaso { get; set; }

		public decimal SuajeAldesarrollo { get; set; }

		public int SuajeCavidades { get; set; }

		public int SuajeEngrane { get; set; }

		public decimal SuajeMxmillar { get; set; }

		public decimal SuajeCinta_p { get; set; }

		public decimal SuajeCinta_mm { get; set; }

		public TipoSuaje SuajeTipo { get; set; }

		public bool SuajeEstado { get; set; }

		public bool SuajeCalcularMxMillar { get; set; }

		public bool SuajeCalcularAnchoCinta { get; set; }

		public decimal SuajeRadio { get; set; }

		public ICollection<SuajeEtiqueta> SuajeEtiquetas { get; set; }
	}
}
