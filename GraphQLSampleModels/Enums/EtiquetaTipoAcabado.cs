using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum EtiquetaTipoAcabado
	{
		Rebobinado,
		Dobladas,
		FormasContinuas,
		Hojeadas,
	}
	public static class EtiquetaTipoAcabadoConverter
	{
		public static EtiquetaTipoAcabado Convertir(byte input)
		{
			if(input==1)
			{
				return EtiquetaTipoAcabado.Rebobinado;
			}
			else if(input==2)
			{
				return EtiquetaTipoAcabado.Dobladas;
			}
			else if(input==3)
			{
				return EtiquetaTipoAcabado.FormasContinuas;
			}
			else
			{
				return EtiquetaTipoAcabado.Hojeadas;
			}
		}
	}
}
