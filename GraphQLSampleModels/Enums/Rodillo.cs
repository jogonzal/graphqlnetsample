using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum Rodillo
	{
		Pulgadas7,
		Pulgadas8,
		Pulgadas10,
		Pulgadas13yMedia,
		Pulgadas9
	}
	public static class RodilloConverter
	{
		public static Rodillo Convertir(byte input)
		{
			if (input == 1)
			{
				return Rodillo.Pulgadas7;
			}
			else if (input == 2)
			{
				return Rodillo.Pulgadas8;
			}
			else if(input==3)
			{
				return Rodillo.Pulgadas10;
			}
			else if(input==4)
			{
				return Rodillo.Pulgadas13yMedia;
			}
			else
			{
				return Rodillo.Pulgadas9;
			}
		}
	}
}
