using System;
using DataRepositories.Entities;
using EtisysCore.Clases;
using Microsoft.EntityFrameworkCore;

namespace DataRepositories.Database
{
	public class EtisysContext : DbContext
	{
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CortadorEtiqueta>()
				.HasKey(t => new { t.CortadorClave, t.EtiquetaClave });

			modelBuilder.Entity<SuajeEtiqueta>()
				.HasKey(t => new { t.SuajeClave, t.EtiquetaClave });
		}

		// NOTA: Si estas agregando campos o haciendo modificationes a la base de datos, tienes que insertar una de estas lineas:

		// public EtisysContext() : base(GetConnectionString(Empresa.LocalTest))
		//public EtisysContext() : base(GetConnectionString(Empresa.Ct))
		//public EtisysContext() : base(GetConnectionString(Empresa.Etiprint))
		//public EtisysContext() : base()
		//{
		//	// This should never be used other than for Entity framework migrations
		//}

		public EtisysContext(DbContextOptions<EtisysContext> options) : base(options)
		{
		}

		private static string GetConnectionString(Empresa empresa)
		{
			if (empresa == Empresa.LocalTest)
			{
				return "Server=localhost;Database=specialTest;Trusted_Connection=True;";
			}

			throw new NotImplementedException();
			//return string.Format(PrivateKeys.DbConnectionStringTemplate, GetDbNameFromEmpresa(empresa));
		}

		private static string GetDbNameFromEmpresa(Empresa empresa)
		{
			switch (empresa)
			{
				case Empresa.Etiprint:
					return "EtisysEtiprint";
				case Empresa.Ct:
					return "EtisysCt";
				case Empresa.Apitsa:
					return "EtisysApitsa";
				default:
					throw new ArgumentOutOfRangeException(nameof(empresa), empresa, null);
			}
		}

		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Agente> Agentes { get; set; }
		public DbSet<Cheque> Cheques { get; set; }
		public DbSet<Formato> Formatos { get; set; }
		public DbSet<CuentaGasto> CuentasGasto { get; set; }
		public DbSet<Zona> Zonas { get; set; }
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Consignatario> Consignatarios { get; set; }
		public DbSet<Material> Materiales { get; set; }
		public DbSet<Proveedor> Proveedores { get; set; }

		public DbSet<Etiqueta> Etiquetas { get; set; }
		public DbSet<Suaje> Suajes { get; set; }
		public DbSet<Cortador> Cortadores { get; set; }
		public DbSet<Estacion> Estaciones { get; set; }
		public DbSet<Pantone> Pantones { get; set; }
		public DbSet<ExistenciaInventario> Existencias { get; set; }
		public DbSet<InventarioSalida> Salidas { get; set; }

		public DbSet<Pedido> Pedidos { get; set; }
		public DbSet<ConceptoPedido> ConceptoPedido { get; set; }
		public DbSet<Factura> Facturas { get; set; }
		public DbSet<ConceptoFactura> ConceptoFactura { get; set; }
		public DbSet<Compra> Compras { get; set; }
		public DbSet<ConceptoCompra> ConceptoCompra { get; set; }
		public DbSet<Pago> Pagos { get; set; }
		public DbSet<NotaDeCredito> NotasCred { get; set; }
		public DbSet<NotaDeCargo> NotasCargo { get; set; }
	}
}
