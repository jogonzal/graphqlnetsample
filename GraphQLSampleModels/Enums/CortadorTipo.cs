using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum CortadorTipo
	{
		Precorte,
		MedioCorte,
		CorteCompleto,
		NavajasCirculares,
		Otros
	}
	public static class CortadorTipoConverter
	{
		public static CortadorTipo Convertir(byte input)
		{
			if(input==1)
			{
				return CortadorTipo.Precorte;
			}
			else if(input==2)
			{
				return CortadorTipo.MedioCorte;
			}
			else if(input==3)
			{
				return CortadorTipo.CorteCompleto;
			}
			else if(input==4)
			{
				return CortadorTipo.NavajasCirculares;
			}
			else
			{
				return CortadorTipo.Otros;
			}
		}
	}

}
