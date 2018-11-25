using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum PedidoEstado
	{
		Cancelado,
		Pendiente,
		Surtido,
	}
	public static class PedidoEstadoConverter
	{
		public static PedidoEstado Convertir(string input)
		{
			if(input=="0")
			{
				return PedidoEstado.Cancelado;
			}
			else if(input=="1")
			{
				return PedidoEstado.Pendiente;
			}
			else
			{
				return PedidoEstado.Surtido;
			}
		}
	}
}
