using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum NotasEstado
	{
		Activa,
		Cancelada
	}
	public static class NotasEstadoConverter
	{
		public static NotasEstado Convertir(bool input)
		{
			if(input)
			{
				return NotasEstado.Cancelada;
			}
			else
			{
				return NotasEstado.Activa;
			}
		}
		public static NotasEstado ConvertirString(string input)
		{
			if(input=="0")
			{
				return NotasEstado.Cancelada;
			}
			else
			{
				return NotasEstado.Activa;
			}
		}
	}
}
