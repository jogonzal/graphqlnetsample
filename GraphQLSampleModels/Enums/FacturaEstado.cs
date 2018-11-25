using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum FacturaEstado
	{
		Cancelada,
		Pendiente,
		Pagada
	}
	public static class FacturaEstadoConverter
	{
		public static FacturaEstado Convertir(byte input)
		{
			if(input==0)
			{
				return FacturaEstado.Cancelada;
			}
			else if(input==1)
			{
				return FacturaEstado.Pendiente;
			}
			else
			{
				return FacturaEstado.Pagada;
			}
		}
	}
}
