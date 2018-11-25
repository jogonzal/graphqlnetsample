using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataRepositories.Entities.Base;
using EtisysCore.Enums;

namespace DataRepositories.Entities
{
	public class Etiqueta : ModeloBase
	{
		[Key]
		public string EtiquetaClave { get; set; }

		public string EtiquetaNombre { get; set; }

		public Cliente EtiquetaCliente { get; set; }

		[ForeignKey("EtiquetaCliente")]
		public string EtiquetaClienteClave { get; set; }

		public Formato EtiquetaFormato { get; set; }

		[ForeignKey("EtiquetaFormato")]
		public string EtiquetaFormatoClave { get; set; }

		public bool EtiquetaEstado { get; set; }

		public decimal EtiquetaPrecio { get; set; }

		public decimal EtiquetaCosto { get; set; }

		public Moneda EtiquetaPesos { get; set; }

		public decimal EtiquetaPrecioAnterior { get; set; }

		public DateTime EtiquetaFechaCambio { get; set; }

		public decimal EtiquetaPeso { get; set; }

		public decimal EtiquetaMinimo { get; set; }

		public string EtiquetaClavePro { get; set; }

		public decimal EtiquetaAncho { get; set; }

		public decimal EtiquetaLargo { get; set; }

		public Material EtiquetaMaterial { get; set; }

		[ForeignKey("EtiquetaMaterial")]
		public string EtiquetaMaterialClave { get; set; }

		public bool EtiquetaLaminado { get; set; }

		public bool EtiquetaBarnizado { get; set; }

		public List<Suaje> EtiquetaListaSuajes { get; set; }

		public List<Cortador> EtiquetaListaCortadores { get; set; }

		public string EtiquetaObservaProduccion { get; set; }

		public Maquina EtiquetaMaquina { get; set; }

		public int EtiquetaPasoRollo { get; set; }

		public EtiquetaTipoAcabado EtiquetaTipoAcabado { get; set; }

		public decimal EtiquetaSeparacion { get; set; }

		public decimal EtiquetaEtiquetasPorRollo { get; set; }

		public decimal EtiquetaAnchoCent { get; set; }

		public decimal EtiquetaDiametro { get; set; }

		public EtiquetaSalida EtiquetaSalida { get; set; }

		public decimal EtiquetaPuntosXRollo { get; set; }

		public decimal EtiquetaBultos { get; set; }

		public int EtiquetaEtiquetasPorDoblez { get; set; }

		public string EtiquetaObservaD { get; set; }

		public bool EtiquetaBolsa { get; set; }

		public bool EtiquetaCaja { get; set; }

		public string EtiquetaMedBolsa { get; set; }

		public string EtiquetaMedCaja { get; set; }

		public int EtiquetaRxBolsa { get; set; }

		public int EtiquetaRxCaja { get; set; }

		public string EtiquetaObervaEmpaque { get; set; }

		public List<Estacion> EtiquetaListaEstaciones { get; set; }

		public string EtiquetaObservacionesDeCalidad { get; set; }

		public string EtiquetaSKU { get; set; }

		public Proveedor EtiquetaProveedor { get; set; }

		[ForeignKey("EtiquetaProveedor")]
		public string EtiquetaProveedorClave { get; set; }

		public bool EtiquetaDobleRevisado { get; set; }

		public bool EtiquetaEtiquetadoAutomatico { get; set; }

		public bool EtiquetaCertificadoCalidad { get; set; }

		public string EtiquetaBarnizadoDesc { get; set; }

		public string EtiquetaLaminadoDesc { get; set; }

		public string EtiquetaUnidad { get; set; }

		public bool EtiquetaClienteCritico { get; set; }

		public decimal EtiquetaComision { get; set; }

		public Moneda EtiquetaMonedaCosto { get; set; }

		public bool EtiquetaAprobado { get; set; }

		public DateTime EtiquetaFechaAlta { get; set; }

		public decimal EtiquetaMinimoInventario { get; set; }

		public bool EtiquetaContarComoRollo { get; set; }

		public string EtiquetaObservacionesGeneral { get; set; }

		public string EtiquetaFraccionArancelaria { get; set; }

		public string EtiquetaCFDIClaveProdServ { get; set; }

		public string EtiquetaCFDIClaveUnidad { get; set; }
	}
}
