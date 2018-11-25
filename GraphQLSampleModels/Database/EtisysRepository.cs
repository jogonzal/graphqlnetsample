//using System;
//using System.Collections.Generic;

//using System.Linq;
//using DataRepositories.Entities;
//using EtisysCore.Clases;

//namespace DataRepositories.Database
//{
//	public class EtisysRepository
//	{
//		public static EtisysRepository GetInstance(Empresa empresa)
//		{
//			return new EtisysRepository(empresa);
//		}

//		private Empresa Empresa { get; }

//		public EtisysRepository(Empresa empresa)
//		{
//			Empresa = empresa;
//		}

//		public List<Agente> GetAgentes()
//		{
//			using (var context = new EtisysContext(Empresa))
//			{
//				return context.Agentes.ToList();
//			}
//		}

//		public List<string> GetCheques2()
//		{
//			using (var context = new EtisysContext(Empresa))
//			{
//				return context.Cheques.Select(c => c.ChequeProveedor.ProveedorNombre).ToList();
//			}
//		}

//		public abstract class ModeloParaCaptura
//		{
//		}

//		public class ChequeEnCaptura : ModeloParaCaptura
//		{
//			public string Clave { get; set; }
//			public DateTime Fecha { get; set; }
//			public string ClaveProveedor { get; set; }
//			public string NombreProveedor { get; set; }

//			public ChequeEnCaptura()
//			{
				
//			}

//			public ChequeEnCaptura(string clave, DateTime fecha, string claveProveedor, string nombreProveedor)
//			{
//				Clave = clave;
//				Fecha = fecha;
//				ClaveProveedor = claveProveedor;
//				NombreProveedor = nombreProveedor;
//			}
//		}

//		public IEnumerable<ChequeEnCaptura> GetCheques()
//		{
//			using (var context = new EtisysContext(Empresa))
//			{
//				// TODO: Donde esta include?
//				return context.Cheques.Select(s => new ChequeEnCaptura()
//				{
//					Clave = s.ChequeClave,
//					ClaveProveedor = s.ChequeProveedorClave,
//					Fecha = s.ChequeFecha,
//					NombreProveedor = s.ChequeProveedor.ProveedorNombre,
//				}).ToList();
//			}
//		}


//		//public List<Proveedor> GetProveedores()
//		//{
//		//	using (var context = new EtisysContext(Empresa))
//		//	{
//		//		return context.Proveedores.ToList();
//		//	}
//		//}

//		public Usuario GetUsuarioByClave(string clave)
//		{
//			using (var context = new EtisysContext(Empresa))
//			{
//				return context.Usuarios.FirstOrDefault(u => u.UsuarioClave == clave);
//			}
//		}

//		public Cheque GetCheque(string clave)
//		{
//			using (var context = new EtisysContext(Empresa))
//			{
//				return context.Cheques.FirstOrDefault(u => u.ChequeClave == clave);
//			}
//		}
//	}
//}
