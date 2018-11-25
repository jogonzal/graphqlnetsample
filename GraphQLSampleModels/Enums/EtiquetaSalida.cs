using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum EtiquetaSalida
	{
		DeCabeza,
		DePatas,
		SaleDerecha,
		SaleIzquierda,
		DeCabezaPorDentro,
		DePatasPorDentro,
		DerechaPorDentro,
		IzquierdaPorDentro,
		SalidaEspecial,
	}
	public static class EtiquetaSalidaConverter
	{
		public static EtiquetaSalida Convertir(byte input)
		{
			if(input==1)
			{
				return EtiquetaSalida.DeCabeza;
			}
			else if(input==2)
			{
				return EtiquetaSalida.DePatas;
			}
			else if (input == 3)
			{
				return EtiquetaSalida.SaleDerecha;
			}
			else if (input == 4)
			{
				return EtiquetaSalida.SaleIzquierda;
			}
			else if (input == 5)
			{
				return EtiquetaSalida.DeCabezaPorDentro;
			}
			else if (input == 6)
			{
				return EtiquetaSalida.DePatasPorDentro;
			}
			else if (input == 7)
			{
				return EtiquetaSalida.DerechaPorDentro;
			}
			else if (input == 8)
			{
				return EtiquetaSalida.IzquierdaPorDentro;
			}
			else
			{
				return EtiquetaSalida.SalidaEspecial;
			}
		}
	}
}
