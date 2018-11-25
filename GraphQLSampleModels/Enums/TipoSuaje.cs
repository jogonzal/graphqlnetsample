using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum TipoSuaje
	{
		Regular,
		Irregular,
		Ovalado,
		Circular,
		Magnetico,
		Virtual
	}
	public static class TipoSuajeConverter
	{
		public static TipoSuaje Convertir(byte input)
		{
			if(input==0)
			{
				return TipoSuaje.Regular;
			}
			else if(input==1)
			{
				return TipoSuaje.Irregular;
			}
			else if(input==2)
			{
				return TipoSuaje.Ovalado;
			}
			else if(input==3)
			{
				return TipoSuaje.Circular;
			}
			else if(input==4)
			{
				return TipoSuaje.Magnetico;
			}
			else
			{
				return TipoSuaje.Virtual;
			}
		}
	}
}
