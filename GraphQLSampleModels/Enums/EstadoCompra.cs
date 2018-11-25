using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum EstadoCompra
	{
		Pendiente,
		Surtida
	}
	public static class EstadoCompraConverter
	{
		public static EstadoCompra Convertir(string input)
		{
			if(input.ToLowerInvariant()=="p")
			{
				return EstadoCompra.Pendiente;
			}
			else
			{
				return EstadoCompra.Surtida;
			}
		}
	}
}
