using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtisysCore.Enums
{
	public enum Maquina
	{
		Maquina820,
		Maquina830,
		MaquinaALLIED,
		MaquinaCOMCO,
		Maquina2200,
		Maquina800,
		Maquina2100,
	}
	public static class MaquinaConverter
	{
		public static Maquina Convertir(byte input)
		{
			if(input==1)
			{
				return Maquina.Maquina820;
			}
			else if(input==2)
			{
				return Maquina.Maquina830;
			}
			else if(input==3)
			{
				return Maquina.MaquinaALLIED;
			}
			else if(input==4)
			{
				return Maquina.MaquinaCOMCO;
			}
			else if(input==5)
			{
				return Maquina.Maquina2200;
			}
			else if(input==6)
			{
				return Maquina.Maquina800;
			}
			else
			{
				return Maquina.Maquina2100;
			}
		}
	}
}
