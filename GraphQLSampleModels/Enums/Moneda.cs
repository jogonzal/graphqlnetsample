using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum Moneda
	{
		Pesos,
		Dolares
	}
	public static class MonedaConverter
	{
		public static Moneda Convertir(string input)
		{
			if (input.ToLowerInvariant() == "d")
			{
				return Moneda.Pesos;
			}
			else
			{
				return Moneda.Dolares;
			}
		}
		public static Moneda ConvertirBooleano(bool input)
		{
			if(input)
			{
				return Moneda.Pesos;
			}
			else
			{
				return Moneda.Dolares;
			}
		}
	}
}
