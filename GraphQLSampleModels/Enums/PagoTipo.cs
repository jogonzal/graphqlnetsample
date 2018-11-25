using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum PagoTipo
	{
		Cheque,
		PagoInterbancario,
		DolaresInterbancario,
		DiferenciaTC,
		Otros,
		Efectivo
	}
	public static class PagoTipoConverter
	{
		public static PagoTipo Convertir(string input)
		{
			if(input=="0")
			{
				return PagoTipo.Cheque;
			}
			else if(input=="1")
			{
				return PagoTipo.PagoInterbancario;
			}
			else if(input=="2")
			{
				return PagoTipo.DolaresInterbancario;
			}
			else if(input=="3")
			{
				return PagoTipo.DiferenciaTC;
			}
			else if(input=="4")
			{
				return PagoTipo.Otros;
			}
			else
			{
				return PagoTipo.Efectivo;
			}
		}
	}
}
