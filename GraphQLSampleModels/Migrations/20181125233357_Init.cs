using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQLSampleModels.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agentes",
                columns: table => new
                {
                    AgenteClave = table.Column<string>(nullable: false),
                    AgenteNombre = table.Column<string>(nullable: true),
                    AgenteDireccion = table.Column<string>(nullable: true),
                    AgenteCD_EDO_PAIS = table.Column<string>(nullable: true),
                    AgenteCP = table.Column<string>(nullable: true),
                    AgenteTelefono = table.Column<string>(nullable: true),
                    AgenteFax = table.Column<string>(nullable: true),
                    AgenteComision = table.Column<decimal>(nullable: false),
                    AgenteEstado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agentes", x => x.AgenteClave);
                });

            migrationBuilder.CreateTable(
                name: "Cortadores",
                columns: table => new
                {
                    CortadorClave = table.Column<string>(nullable: false),
                    CortadorDescripcion = table.Column<string>(nullable: true),
                    CortadorMedidaPulg = table.Column<decimal>(nullable: false),
                    CortadorEngrane = table.Column<short>(nullable: false),
                    CortadorRodillo = table.Column<byte>(nullable: false),
                    CortadorTipo = table.Column<byte>(nullable: false),
                    CortadorEstado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cortadores", x => x.CortadorClave);
                });

            migrationBuilder.CreateTable(
                name: "CuentasGasto",
                columns: table => new
                {
                    CuentaGastoClave = table.Column<string>(nullable: false),
                    CuentaGastoDescripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentasGasto", x => x.CuentaGastoClave);
                });

            migrationBuilder.CreateTable(
                name: "Formatos",
                columns: table => new
                {
                    FormatoClave = table.Column<string>(nullable: false),
                    FormatoDescripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formatos", x => x.FormatoClave);
                });

            migrationBuilder.CreateTable(
                name: "Pantones",
                columns: table => new
                {
                    PantoneClave = table.Column<string>(nullable: false),
                    PantoneDescripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pantones", x => x.PantoneClave);
                });

            migrationBuilder.CreateTable(
                name: "Suajes",
                columns: table => new
                {
                    SuajeClave = table.Column<string>(nullable: false),
                    SuajeDescripcion = table.Column<string>(nullable: true),
                    SuajeAncho_p = table.Column<decimal>(nullable: false),
                    SuajeAncho_mm = table.Column<decimal>(nullable: false),
                    SuajeLargo_p = table.Column<decimal>(nullable: false),
                    SuajeLargo_mm = table.Column<decimal>(nullable: false),
                    SuajeSepejep = table.Column<decimal>(nullable: false),
                    SuajeSepdesap = table.Column<decimal>(nullable: false),
                    SuajeAlpaso = table.Column<decimal>(nullable: false),
                    SuajeAldesarrollo = table.Column<decimal>(nullable: false),
                    SuajeCavidades = table.Column<int>(nullable: false),
                    SuajeEngrane = table.Column<int>(nullable: false),
                    SuajeMxmillar = table.Column<decimal>(nullable: false),
                    SuajeCinta_p = table.Column<decimal>(nullable: false),
                    SuajeCinta_mm = table.Column<decimal>(nullable: false),
                    SuajeTipo = table.Column<int>(nullable: false),
                    SuajeEstado = table.Column<bool>(nullable: false),
                    SuajeCalcularMxMillar = table.Column<bool>(nullable: false),
                    SuajeCalcularAnchoCinta = table.Column<bool>(nullable: false),
                    SuajeRadio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suajes", x => x.SuajeClave);
                });

            migrationBuilder.CreateTable(
                name: "Zonas",
                columns: table => new
                {
                    ZonaClave = table.Column<string>(nullable: false),
                    ZonaNombre = table.Column<string>(nullable: true),
                    ZonaDescripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonas", x => x.ZonaClave);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioClave = table.Column<string>(nullable: false),
                    UsuarioNombre = table.Column<string>(nullable: true),
                    UsuarioAccesoAdmin = table.Column<bool>(nullable: false),
                    Usuario_H_M = table.Column<bool>(nullable: false),
                    UsuarioPermisoAgentes = table.Column<int>(nullable: false),
                    UsuarioPermisoConsignatarios = table.Column<int>(nullable: false),
                    UsuarioPermisoClientes = table.Column<int>(nullable: false),
                    UsuarioPermisoCortadores = table.Column<int>(nullable: false),
                    UsuarioPermisoFormatos = table.Column<int>(nullable: false),
                    UsuarioPermisoSuajes = table.Column<int>(nullable: false),
                    UsuarioPermisoZonas = table.Column<int>(nullable: false),
                    UsuarioPermisoEtiquetas = table.Column<int>(nullable: false),
                    UsuarioPermisoProveedores = table.Column<int>(nullable: false),
                    UsuarioPermisoMateriales = table.Column<int>(nullable: false),
                    UsuarioPermisoFacturas = table.Column<int>(nullable: false),
                    UsuarioPermisoPedidos = table.Column<int>(nullable: false),
                    UsuarioPermisoCompras = table.Column<int>(nullable: false),
                    UsuarioPermisoPagos = table.Column<int>(nullable: false),
                    UsuarioPermisoCheques = table.Column<int>(nullable: false),
                    UsuarioPermisoNotasCredito = table.Column<int>(nullable: false),
                    UsuarioPermisoNotasCargo = table.Column<int>(nullable: false),
                    UsuarioInventario = table.Column<bool>(nullable: false),
                    UsuarioPermisoInventario = table.Column<int>(nullable: false),
                    UsuarioPermisoSalidas = table.Column<int>(nullable: false),
                    UsuarioEtiquetasAprobacion = table.Column<bool>(nullable: false),
                    UsuarioVendedor = table.Column<bool>(nullable: false),
                    UsuarioAgenteClave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioClave);
                    table.ForeignKey(
                        name: "FK_Usuarios_Agentes_UsuarioAgenteClave",
                        column: x => x.UsuarioAgenteClave,
                        principalTable: "Agentes",
                        principalColumn: "AgenteClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    ProveedorClave = table.Column<string>(nullable: false),
                    ProveedorNombre = table.Column<string>(nullable: true),
                    ProveedorDireccion = table.Column<string>(nullable: true),
                    ProveedorCiudad = table.Column<string>(nullable: true),
                    ProveedorCP = table.Column<string>(nullable: true),
                    ProveedorTelefono = table.Column<string>(nullable: true),
                    ProveedorFax = table.Column<string>(nullable: true),
                    ProveedorRFC = table.Column<string>(nullable: true),
                    ProveedorEncargado = table.Column<string>(nullable: true),
                    ProveedorEstado = table.Column<bool>(nullable: false),
                    ProveedorANombreDe = table.Column<string>(nullable: true),
                    ProveedorAutorizadoIso = table.Column<bool>(nullable: false),
                    ProveedorCuentaGastoClave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ProveedorClave);
                    table.ForeignKey(
                        name: "FK_Proveedores_CuentasGasto_ProveedorCuentaGastoClave",
                        column: x => x.ProveedorCuentaGastoClave,
                        principalTable: "CuentasGasto",
                        principalColumn: "CuentaGastoClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteClave = table.Column<string>(nullable: false),
                    ClienteActivo = table.Column<bool>(nullable: false),
                    ClienteRFC = table.Column<string>(nullable: true),
                    ClienteCalle = table.Column<string>(nullable: true),
                    ClienteNumeroExterior = table.Column<string>(nullable: true),
                    ClienteNumeroInterior = table.Column<string>(nullable: true),
                    ClienteColonia = table.Column<string>(nullable: true),
                    ClienteLocalidad = table.Column<string>(nullable: true),
                    ClienteMunicipio = table.Column<string>(nullable: true),
                    ClienteEstado = table.Column<string>(nullable: true),
                    ClientePais = table.Column<string>(nullable: true),
                    ClienteCP = table.Column<string>(nullable: true),
                    ClienteTelefono = table.Column<string>(nullable: true),
                    ClienteFax = table.Column<string>(nullable: true),
                    ClienteMail = table.Column<string>(nullable: true),
                    ClienteComprador = table.Column<string>(nullable: true),
                    ClienteAgenteClave = table.Column<string>(nullable: false),
                    ClienteZonaClave = table.Column<string>(nullable: false),
                    ClientePagos = table.Column<string>(nullable: true),
                    ClientePlazo = table.Column<int>(nullable: false),
                    ClienteCondicionesDePago = table.Column<string>(nullable: true),
                    ClienteRevision = table.Column<string>(nullable: true),
                    ClienteCreditoMaximo = table.Column<decimal>(nullable: false),
                    ClientePesos = table.Column<int>(nullable: false),
                    ClienteFlete = table.Column<bool>(nullable: false),
                    ClienteTransporte = table.Column<string>(nullable: true),
                    ClienteDescuento = table.Column<string>(nullable: true),
                    ClienteLeyenda = table.Column<string>(nullable: true),
                    ClienteRazonSocial = table.Column<string>(nullable: true),
                    ClienteAddenda = table.Column<int>(nullable: false),
                    ClienteNumeroProveedor = table.Column<string>(nullable: true),
                    ClienteExtranjero = table.Column<bool>(nullable: false),
                    ClienteNombreCompras = table.Column<string>(nullable: true),
                    ClienteMailCompras = table.Column<string>(nullable: true),
                    ClienteNombrePagos = table.Column<string>(nullable: true),
                    ClienteMailPagos = table.Column<string>(nullable: true),
                    ClienteNombreFacturas = table.Column<string>(nullable: true),
                    ClienteMailFacturas = table.Column<string>(nullable: true),
                    ClienteMedotoDePago = table.Column<string>(nullable: true),
                    ClienteNumCtaPagoNuevo = table.Column<string>(nullable: true),
                    ClienteInformacionImprimir = table.Column<string>(nullable: true),
                    ClienteCantidadEnMillares = table.Column<bool>(nullable: false),
                    ClienteRequisitosEmbarque = table.Column<string>(nullable: true),
                    ClienteRequisitosFacturacion = table.Column<string>(nullable: true),
                    ClienteCFDIFormaDePago = table.Column<string>(nullable: true),
                    ClienteCFDIMetodoDePago = table.Column<string>(nullable: true),
                    ClienteUsoCFDI = table.Column<string>(nullable: true),
                    ClienteCFDINumRegIdTrip = table.Column<string>(nullable: true),
                    ClienteCFDIPais = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteClave);
                    table.ForeignKey(
                        name: "FK_Clientes_Agentes_ClienteAgenteClave",
                        column: x => x.ClienteAgenteClave,
                        principalTable: "Agentes",
                        principalColumn: "AgenteClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_Zonas_ClienteZonaClave",
                        column: x => x.ClienteZonaClave,
                        principalTable: "Zonas",
                        principalColumn: "ZonaClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cheques",
                columns: table => new
                {
                    ChequeClave = table.Column<string>(nullable: false),
                    ChequeFecha = table.Column<DateTime>(nullable: false),
                    ChequeNumeroDeCheque = table.Column<string>(nullable: true),
                    ChequeProveedorClave = table.Column<string>(nullable: false),
                    ChequeANombreDe = table.Column<string>(nullable: true),
                    ChequeDescripcion = table.Column<string>(nullable: true),
                    ChequeFacturaPagada = table.Column<string>(nullable: true),
                    ChequeCuentaDeGasto = table.Column<string>(nullable: true),
                    ChequeTotalAPagar = table.Column<decimal>(nullable: false),
                    ChequeCantIva = table.Column<decimal>(nullable: false),
                    ChequePesos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheques", x => x.ChequeClave);
                    table.ForeignKey(
                        name: "FK_Cheques_Proveedores_ChequeProveedorClave",
                        column: x => x.ChequeProveedorClave,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materiales",
                columns: table => new
                {
                    MaterialClave = table.Column<string>(nullable: false),
                    MaterialNombre = table.Column<string>(nullable: true),
                    MaterialProveedorClave = table.Column<string>(nullable: true),
                    MaterialFormatoClave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiales", x => x.MaterialClave);
                    table.ForeignKey(
                        name: "FK_Materiales_Formatos_MaterialFormatoClave",
                        column: x => x.MaterialFormatoClave,
                        principalTable: "Formatos",
                        principalColumn: "FormatoClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materiales_Proveedores_MaterialProveedorClave",
                        column: x => x.MaterialProveedorClave,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consignatarios",
                columns: table => new
                {
                    ConsignatarioClave = table.Column<string>(nullable: false),
                    ConsignatarioNombre = table.Column<string>(nullable: true),
                    ConsignatarioDireccion = table.Column<string>(nullable: true),
                    ConsignatarioCiudad = table.Column<string>(nullable: true),
                    ConsignatarioCP = table.Column<string>(nullable: true),
                    ConsignatarioTelefono = table.Column<string>(nullable: true),
                    ConsignatarioFax = table.Column<string>(nullable: true),
                    ConsignatarioClienteClave = table.Column<string>(nullable: false),
                    ConsignatarioEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consignatarios", x => x.ConsignatarioClave);
                    table.ForeignKey(
                        name: "FK_Consignatarios_Clientes_ConsignatarioClienteClave",
                        column: x => x.ConsignatarioClienteClave,
                        principalTable: "Clientes",
                        principalColumn: "ClienteClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etiquetas",
                columns: table => new
                {
                    EtiquetaClave = table.Column<string>(nullable: false),
                    EtiquetaNombre = table.Column<string>(nullable: true),
                    EtiquetaClienteClave = table.Column<string>(nullable: true),
                    EtiquetaFormatoClave = table.Column<string>(nullable: true),
                    EtiquetaEstado = table.Column<bool>(nullable: false),
                    EtiquetaPrecio = table.Column<decimal>(nullable: false),
                    EtiquetaCosto = table.Column<decimal>(nullable: false),
                    EtiquetaPesos = table.Column<int>(nullable: false),
                    EtiquetaPrecioAnterior = table.Column<decimal>(nullable: false),
                    EtiquetaFechaCambio = table.Column<DateTime>(nullable: false),
                    EtiquetaPeso = table.Column<decimal>(nullable: false),
                    EtiquetaMinimo = table.Column<decimal>(nullable: false),
                    EtiquetaClavePro = table.Column<string>(nullable: true),
                    EtiquetaAncho = table.Column<decimal>(nullable: false),
                    EtiquetaLargo = table.Column<decimal>(nullable: false),
                    EtiquetaMaterialClave = table.Column<string>(nullable: true),
                    EtiquetaLaminado = table.Column<bool>(nullable: false),
                    EtiquetaBarnizado = table.Column<bool>(nullable: false),
                    EtiquetaObservaProduccion = table.Column<string>(nullable: true),
                    EtiquetaMaquina = table.Column<int>(nullable: false),
                    EtiquetaPasoRollo = table.Column<int>(nullable: false),
                    EtiquetaTipoAcabado = table.Column<int>(nullable: false),
                    EtiquetaSeparacion = table.Column<decimal>(nullable: false),
                    EtiquetaEtiquetasPorRollo = table.Column<decimal>(nullable: false),
                    EtiquetaAnchoCent = table.Column<decimal>(nullable: false),
                    EtiquetaDiametro = table.Column<decimal>(nullable: false),
                    EtiquetaSalida = table.Column<int>(nullable: false),
                    EtiquetaPuntosXRollo = table.Column<decimal>(nullable: false),
                    EtiquetaBultos = table.Column<decimal>(nullable: false),
                    EtiquetaEtiquetasPorDoblez = table.Column<int>(nullable: false),
                    EtiquetaObservaD = table.Column<string>(nullable: true),
                    EtiquetaBolsa = table.Column<bool>(nullable: false),
                    EtiquetaCaja = table.Column<bool>(nullable: false),
                    EtiquetaMedBolsa = table.Column<string>(nullable: true),
                    EtiquetaMedCaja = table.Column<string>(nullable: true),
                    EtiquetaRxBolsa = table.Column<int>(nullable: false),
                    EtiquetaRxCaja = table.Column<int>(nullable: false),
                    EtiquetaObervaEmpaque = table.Column<string>(nullable: true),
                    EtiquetaObservacionesDeCalidad = table.Column<string>(nullable: true),
                    EtiquetaSKU = table.Column<string>(nullable: true),
                    EtiquetaProveedorClave = table.Column<string>(nullable: true),
                    EtiquetaDobleRevisado = table.Column<bool>(nullable: false),
                    EtiquetaEtiquetadoAutomatico = table.Column<bool>(nullable: false),
                    EtiquetaCertificadoCalidad = table.Column<bool>(nullable: false),
                    EtiquetaBarnizadoDesc = table.Column<string>(nullable: true),
                    EtiquetaLaminadoDesc = table.Column<string>(nullable: true),
                    EtiquetaUnidad = table.Column<string>(nullable: true),
                    EtiquetaClienteCritico = table.Column<bool>(nullable: false),
                    EtiquetaComision = table.Column<decimal>(nullable: false),
                    EtiquetaMonedaCosto = table.Column<int>(nullable: false),
                    EtiquetaAprobado = table.Column<bool>(nullable: false),
                    EtiquetaFechaAlta = table.Column<DateTime>(nullable: false),
                    EtiquetaMinimoInventario = table.Column<decimal>(nullable: false),
                    EtiquetaContarComoRollo = table.Column<bool>(nullable: false),
                    EtiquetaObservacionesGeneral = table.Column<string>(nullable: true),
                    EtiquetaFraccionArancelaria = table.Column<string>(nullable: true),
                    EtiquetaCFDIClaveProdServ = table.Column<string>(nullable: true),
                    EtiquetaCFDIClaveUnidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etiquetas", x => x.EtiquetaClave);
                    table.ForeignKey(
                        name: "FK_Etiquetas_Clientes_EtiquetaClienteClave",
                        column: x => x.EtiquetaClienteClave,
                        principalTable: "Clientes",
                        principalColumn: "ClienteClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Etiquetas_Formatos_EtiquetaFormatoClave",
                        column: x => x.EtiquetaFormatoClave,
                        principalTable: "Formatos",
                        principalColumn: "FormatoClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Etiquetas_Materiales_EtiquetaMaterialClave",
                        column: x => x.EtiquetaMaterialClave,
                        principalTable: "Materiales",
                        principalColumn: "MaterialClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Etiquetas_Proveedores_EtiquetaProveedorClave",
                        column: x => x.EtiquetaProveedorClave,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraClave = table.Column<string>(nullable: false),
                    CompraUsuarioClave = table.Column<string>(nullable: true),
                    CompraProveedorClave = table.Column<string>(nullable: false),
                    CompraTransporte = table.Column<string>(nullable: true),
                    CompraDescuentoPorcentaje = table.Column<decimal>(nullable: false),
                    CompraConsignatarioClave = table.Column<string>(nullable: true),
                    CompraIVA = table.Column<decimal>(nullable: false),
                    CompraSubtotal = table.Column<decimal>(nullable: false),
                    CompraDescuento = table.Column<decimal>(nullable: false),
                    CompraFlete = table.Column<decimal>(nullable: false),
                    CompraTotal = table.Column<decimal>(nullable: false),
                    CompraFecha = table.Column<DateTime>(nullable: false),
                    CompraCantMill = table.Column<decimal>(nullable: false),
                    CompraComentarios = table.Column<string>(nullable: true),
                    CompraTipoCambio = table.Column<decimal>(nullable: false),
                    CompraMoneda = table.Column<int>(nullable: false),
                    CompraEstado = table.Column<int>(nullable: false),
                    CompraAprobado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraClave);
                    table.ForeignKey(
                        name: "FK_Compras_Consignatarios_CompraConsignatarioClave",
                        column: x => x.CompraConsignatarioClave,
                        principalTable: "Consignatarios",
                        principalColumn: "ConsignatarioClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compras_Proveedores_CompraProveedorClave",
                        column: x => x.CompraProveedorClave,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Usuarios_CompraUsuarioClave",
                        column: x => x.CompraUsuarioClave,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoClave = table.Column<string>(nullable: false),
                    PedidoUsuarioClave = table.Column<string>(nullable: true),
                    PedidoClienteClave = table.Column<string>(nullable: false),
                    PedidoAgenteClave = table.Column<string>(nullable: true),
                    PedidoComision = table.Column<decimal>(nullable: false),
                    PedidoPlazo = table.Column<int>(nullable: false),
                    PedidoTransporte = table.Column<string>(nullable: true),
                    PedidoDescuentoPorcentaje = table.Column<decimal>(nullable: false),
                    PedidoPedCliente = table.Column<string>(nullable: true),
                    PedidoConsignatarioClave = table.Column<string>(nullable: true),
                    PedidoFechaCancelacion = table.Column<DateTime>(nullable: false),
                    PedidoIVA = table.Column<decimal>(nullable: false),
                    PedidoSubtotal = table.Column<decimal>(nullable: false),
                    PedidoDescuento = table.Column<decimal>(nullable: false),
                    PedidoFlete = table.Column<decimal>(nullable: false),
                    PedidoCantIVA = table.Column<decimal>(nullable: false),
                    PedidoTotal = table.Column<decimal>(nullable: false),
                    PedidoFecha = table.Column<DateTime>(nullable: false),
                    PedidoFechaOrdenCompra = table.Column<DateTime>(nullable: false),
                    PedidoCantMill = table.Column<decimal>(nullable: false),
                    PedidoEstado = table.Column<int>(nullable: false),
                    PedidoTipoDeCambio = table.Column<decimal>(nullable: false),
                    PedidoMoneda = table.Column<int>(nullable: false),
                    PedidoCalcularComision = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoClave);
                    table.ForeignKey(
                        name: "FK_Pedidos_Agentes_PedidoAgenteClave",
                        column: x => x.PedidoAgenteClave,
                        principalTable: "Agentes",
                        principalColumn: "AgenteClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_PedidoClienteClave",
                        column: x => x.PedidoClienteClave,
                        principalTable: "Clientes",
                        principalColumn: "ClienteClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Consignatarios_PedidoConsignatarioClave",
                        column: x => x.PedidoConsignatarioClave,
                        principalTable: "Consignatarios",
                        principalColumn: "ConsignatarioClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Usuarios_PedidoUsuarioClave",
                        column: x => x.PedidoUsuarioClave,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CortadorEtiqueta",
                columns: table => new
                {
                    EtiquetaClave = table.Column<string>(nullable: false),
                    CortadorClave = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CortadorEtiqueta", x => new { x.CortadorClave, x.EtiquetaClave });
                    table.ForeignKey(
                        name: "FK_CortadorEtiqueta_Cortadores_CortadorClave",
                        column: x => x.CortadorClave,
                        principalTable: "Cortadores",
                        principalColumn: "CortadorClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CortadorEtiqueta_Etiquetas_EtiquetaClave",
                        column: x => x.EtiquetaClave,
                        principalTable: "Etiquetas",
                        principalColumn: "EtiquetaClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estaciones",
                columns: table => new
                {
                    EstacionClave = table.Column<string>(nullable: false),
                    EstacionMarca = table.Column<string>(nullable: true),
                    EstacionBlade = table.Column<string>(nullable: true),
                    EstacionAnilox = table.Column<decimal>(nullable: false),
                    EstacionRodillo = table.Column<string>(nullable: true),
                    EstacionComentarios = table.Column<string>(nullable: true),
                    EstacionPosicion = table.Column<int>(nullable: false),
                    EstacionPantoneClave = table.Column<string>(nullable: true),
                    EstacionEtiquetaClave = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estaciones", x => x.EstacionClave);
                    table.ForeignKey(
                        name: "FK_Estaciones_Etiquetas_EstacionEtiquetaClave",
                        column: x => x.EstacionEtiquetaClave,
                        principalTable: "Etiquetas",
                        principalColumn: "EtiquetaClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estaciones_Pantones_EstacionPantoneClave",
                        column: x => x.EstacionPantoneClave,
                        principalTable: "Pantones",
                        principalColumn: "PantoneClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Existencias",
                columns: table => new
                {
                    ExistenciaInventarioClave = table.Column<string>(nullable: false),
                    ExistenciaInventarioEtiquetaClave = table.Column<string>(nullable: true),
                    ExistenciaInventarioArea = table.Column<short>(nullable: false),
                    ExisgtenciaInventarioEnBodega = table.Column<bool>(nullable: false),
                    ExistenciaInventarioFactura = table.Column<string>(nullable: true),
                    ExistenciaInventarioFechaEntrada = table.Column<DateTime>(nullable: false),
                    ExistenciaInventarioPedido = table.Column<string>(nullable: true),
                    ExistenciaInventarioFechaSalida = table.Column<DateTime>(nullable: false),
                    ExistenciaInventarioObservaciones = table.Column<string>(nullable: true),
                    ExistenciaInventarioLote = table.Column<string>(nullable: true),
                    ExistenciaInventarioUsuarioClave = table.Column<string>(nullable: true),
                    ExistenciaInventarioCantidadInicial = table.Column<decimal>(nullable: false),
                    ExistenciaInventarioCantidadActual = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Existencias", x => x.ExistenciaInventarioClave);
                    table.ForeignKey(
                        name: "FK_Existencias_Etiquetas_ExistenciaInventarioEtiquetaClave",
                        column: x => x.ExistenciaInventarioEtiquetaClave,
                        principalTable: "Etiquetas",
                        principalColumn: "EtiquetaClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Existencias_Usuarios_ExistenciaInventarioUsuarioClave",
                        column: x => x.ExistenciaInventarioUsuarioClave,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuajeEtiqueta",
                columns: table => new
                {
                    EtiquetaClave = table.Column<string>(nullable: false),
                    SuajeClave = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuajeEtiqueta", x => new { x.SuajeClave, x.EtiquetaClave });
                    table.ForeignKey(
                        name: "FK_SuajeEtiqueta_Etiquetas_EtiquetaClave",
                        column: x => x.EtiquetaClave,
                        principalTable: "Etiquetas",
                        principalColumn: "EtiquetaClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuajeEtiqueta_Suajes_SuajeClave",
                        column: x => x.SuajeClave,
                        principalTable: "Suajes",
                        principalColumn: "SuajeClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConceptoCompra",
                columns: table => new
                {
                    ConceptoCompraClave = table.Column<string>(nullable: false),
                    ConceptoCompraEtiquetaClave = table.Column<string>(nullable: true),
                    ConceptoCompraCantidad = table.Column<decimal>(nullable: false),
                    ConceptoCompraPrecio = table.Column<decimal>(nullable: false),
                    ConceptoCompraSurtido = table.Column<bool>(nullable: false),
                    ConceptoCompraRecibido = table.Column<decimal>(nullable: false),
                    ConceptoCompraSubtotal = table.Column<decimal>(nullable: false),
                    ConceptoCompraCompraClave = table.Column<string>(nullable: false),
                    ConceptoCompraMoneda = table.Column<int>(nullable: false),
                    ConceptoCompraDiferencia = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptoCompra", x => x.ConceptoCompraClave);
                    table.ForeignKey(
                        name: "FK_ConceptoCompra_Compras_ConceptoCompraCompraClave",
                        column: x => x.ConceptoCompraCompraClave,
                        principalTable: "Compras",
                        principalColumn: "CompraClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConceptoCompra_Etiquetas_ConceptoCompraEtiquetaClave",
                        column: x => x.ConceptoCompraEtiquetaClave,
                        principalTable: "Etiquetas",
                        principalColumn: "EtiquetaClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConceptoPedido",
                columns: table => new
                {
                    ConceptoPedidoClave = table.Column<string>(nullable: false),
                    ConceptoPedidoEtiquetaClave = table.Column<string>(nullable: true),
                    ConceptoPedidoCantidad = table.Column<decimal>(nullable: false),
                    ConceptoPedidoPrecio = table.Column<decimal>(nullable: false),
                    ConceptoPedidoSurtido = table.Column<bool>(nullable: false),
                    ConceptoPedidoCantSurtida = table.Column<decimal>(nullable: false),
                    ConceptoPedidoSubtotal = table.Column<decimal>(nullable: false),
                    ConceptoPedidoPedidoClave = table.Column<string>(nullable: false),
                    ConceptoPedidoMoneda = table.Column<int>(nullable: false),
                    ConceptoPedidoSeleccionar = table.Column<bool>(nullable: false),
                    ConceptoPedidoDiferencia = table.Column<decimal>(nullable: false),
                    ConceptoPedidoComision = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptoPedido", x => x.ConceptoPedidoClave);
                    table.ForeignKey(
                        name: "FK_ConceptoPedido_Etiquetas_ConceptoPedidoEtiquetaClave",
                        column: x => x.ConceptoPedidoEtiquetaClave,
                        principalTable: "Etiquetas",
                        principalColumn: "EtiquetaClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConceptoPedido_Pedidos_ConceptoPedidoPedidoClave",
                        column: x => x.ConceptoPedidoPedidoClave,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    FacturaClave = table.Column<string>(nullable: false),
                    FacturaEstado = table.Column<int>(nullable: false),
                    FacturaFecha = table.Column<DateTime>(nullable: false),
                    FacturaPedidoClave = table.Column<string>(nullable: true),
                    FacturaClienteClave = table.Column<string>(nullable: false),
                    FacturaAgenteClave = table.Column<string>(nullable: true),
                    FacturaComision = table.Column<decimal>(nullable: false),
                    FacturaPlazo = table.Column<decimal>(nullable: false),
                    FacturaTransporte = table.Column<string>(nullable: true),
                    FacturaGuia = table.Column<string>(nullable: true),
                    FacturaLeyenda = table.Column<string>(nullable: true),
                    FacturaDescuento = table.Column<decimal>(nullable: false),
                    FacturaPedCliente = table.Column<string>(nullable: true),
                    FacturaConsignatarioClave = table.Column<string>(nullable: true),
                    FacturaIVA = table.Column<decimal>(nullable: false),
                    FacturaSubtotal = table.Column<decimal>(nullable: false),
                    FacturaSubtotalDescuento = table.Column<decimal>(nullable: false),
                    FacturaFlete = table.Column<decimal>(nullable: false),
                    FacturaCantIva = table.Column<decimal>(nullable: false),
                    FacturaTotal = table.Column<decimal>(nullable: false),
                    FacturaCantidadTotal = table.Column<decimal>(nullable: false),
                    FacturaUsuarioClave = table.Column<string>(nullable: true),
                    FacturaAbonos = table.Column<decimal>(nullable: false),
                    FacturaTotnCre = table.Column<decimal>(nullable: false),
                    FacturaTipoCambio = table.Column<decimal>(nullable: false),
                    FacturaSerie = table.Column<string>(nullable: true),
                    FacturaFechaHora = table.Column<DateTime>(nullable: false),
                    FacturaFechaVencimiento = table.Column<DateTime>(nullable: false),
                    FacturaSaldo = table.Column<decimal>(nullable: false),
                    FacturaMoneda = table.Column<int>(nullable: false),
                    FacturaMetodoDePago = table.Column<string>(nullable: true),
                    FacturaClientesNumCtaDePagoNuevo = table.Column<string>(nullable: true),
                    FacturaInformacionImprimir = table.Column<string>(nullable: true),
                    FacturaGenerada = table.Column<bool>(nullable: false),
                    FacturaEnviada = table.Column<bool>(nullable: false),
                    FacturaCalcularComision = table.Column<bool>(nullable: false),
                    FacturaCFDI = table.Column<bool>(nullable: false),
                    FacturaFolioFiscal = table.Column<string>(nullable: true),
                    FacturaFechaTimbrado = table.Column<DateTime>(nullable: false),
                    FacturaSelloSAT = table.Column<string>(nullable: true),
                    FacturaSelloCFDI = table.Column<string>(nullable: true),
                    FacturaCFDIVersion = table.Column<string>(nullable: true),
                    FacturaCFDIFormaDePago = table.Column<string>(nullable: true),
                    FacturaCFDIMetodoDePago = table.Column<string>(nullable: true),
                    FacturaUsoCFDI = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.FacturaClave);
                    table.ForeignKey(
                        name: "FK_Facturas_Agentes_FacturaAgenteClave",
                        column: x => x.FacturaAgenteClave,
                        principalTable: "Agentes",
                        principalColumn: "AgenteClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Clientes_FacturaClienteClave",
                        column: x => x.FacturaClienteClave,
                        principalTable: "Clientes",
                        principalColumn: "ClienteClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_Consignatarios_FacturaConsignatarioClave",
                        column: x => x.FacturaConsignatarioClave,
                        principalTable: "Consignatarios",
                        principalColumn: "ConsignatarioClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Pedidos_FacturaPedidoClave",
                        column: x => x.FacturaPedidoClave,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Usuarios_FacturaUsuarioClave",
                        column: x => x.FacturaUsuarioClave,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salidas",
                columns: table => new
                {
                    InventarioSalidaClave = table.Column<string>(nullable: false),
                    InventarioSalidaExistenciaInventarioClave = table.Column<string>(nullable: false),
                    InventarioSalidaCantidad = table.Column<decimal>(nullable: false),
                    InventarioSalidaFecha = table.Column<DateTime>(nullable: false),
                    InventarioSalidaComentarios = table.Column<string>(nullable: true),
                    InventarioSalidaSalida = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salidas", x => x.InventarioSalidaClave);
                    table.ForeignKey(
                        name: "FK_Salidas_Existencias_InventarioSalidaExistenciaInventarioClave",
                        column: x => x.InventarioSalidaExistenciaInventarioClave,
                        principalTable: "Existencias",
                        principalColumn: "ExistenciaInventarioClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConceptoFactura",
                columns: table => new
                {
                    ConceptoFacturaClave = table.Column<string>(nullable: false),
                    ConceptoFacturaCantidad = table.Column<decimal>(nullable: false),
                    ConceptoFacturaEtiquetaClave = table.Column<string>(nullable: true),
                    ConceptoFacturaPrecio = table.Column<decimal>(nullable: false),
                    ConceptoFacturaRevisada = table.Column<bool>(nullable: false),
                    ConceptoFacturaFacturaClave = table.Column<string>(nullable: false),
                    ConceptoFacturaSeleccionar = table.Column<bool>(nullable: false),
                    ConceptoFacturaMoneda = table.Column<int>(nullable: false),
                    ConceptoFacturaSubtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptoFactura", x => x.ConceptoFacturaClave);
                    table.ForeignKey(
                        name: "FK_ConceptoFactura_Etiquetas_ConceptoFacturaEtiquetaClave",
                        column: x => x.ConceptoFacturaEtiquetaClave,
                        principalTable: "Etiquetas",
                        principalColumn: "EtiquetaClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConceptoFactura_Facturas_ConceptoFacturaFacturaClave",
                        column: x => x.ConceptoFacturaFacturaClave,
                        principalTable: "Facturas",
                        principalColumn: "FacturaClave",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotasCargo",
                columns: table => new
                {
                    NotaDeCargoClave = table.Column<string>(nullable: false),
                    NotaDeCargoUsuarioClave = table.Column<string>(nullable: true),
                    NotaDeCargoFecha = table.Column<DateTime>(nullable: false),
                    NotaDeCargoFacturaClave = table.Column<string>(nullable: false),
                    NotaDeCargoAgenteClave = table.Column<string>(nullable: true),
                    NotaDeCargoDescripcion = table.Column<string>(nullable: true),
                    NotaDeCargoIVA = table.Column<decimal>(nullable: false),
                    NotaDeCargoSubtotal = table.Column<decimal>(nullable: false),
                    NotaDeCargoCantIva = table.Column<decimal>(nullable: false),
                    NotaDeCargoTotal = table.Column<decimal>(nullable: false),
                    NotaDeCargoEstado = table.Column<int>(nullable: false),
                    NotaDeCargoMoneda = table.Column<int>(nullable: false),
                    NotaDeCargoTipoDeCambio = table.Column<decimal>(nullable: false),
                    NotaDeCargoCFDIVersion = table.Column<string>(nullable: true),
                    NotaDeCargoCFDIFormaDePago = table.Column<string>(nullable: true),
                    NotaDeCargoCFDIMetodoDePago = table.Column<string>(nullable: true),
                    NotaDeCargoUsoCFDI = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasCargo", x => x.NotaDeCargoClave);
                    table.ForeignKey(
                        name: "FK_NotasCargo_Agentes_NotaDeCargoAgenteClave",
                        column: x => x.NotaDeCargoAgenteClave,
                        principalTable: "Agentes",
                        principalColumn: "AgenteClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotasCargo_Facturas_NotaDeCargoFacturaClave",
                        column: x => x.NotaDeCargoFacturaClave,
                        principalTable: "Facturas",
                        principalColumn: "FacturaClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotasCargo_Usuarios_NotaDeCargoUsuarioClave",
                        column: x => x.NotaDeCargoUsuarioClave,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotasCred",
                columns: table => new
                {
                    NotaDeCreditoClave = table.Column<string>(nullable: false),
                    NotaDeCreditoUsuarioClave = table.Column<string>(nullable: true),
                    NotaDeCreditoFecha = table.Column<DateTime>(nullable: false),
                    NotaDeCreditoFacturaClave = table.Column<string>(nullable: false),
                    NotaDeCreditoAgenteClave = table.Column<string>(nullable: true),
                    NotaDeCreditoDescripcion = table.Column<string>(nullable: true),
                    NotaDeCreditoSubtotal = table.Column<decimal>(nullable: false),
                    NotaDeCreditoIVA = table.Column<decimal>(nullable: false),
                    NotaDeCreditoTotal = table.Column<decimal>(nullable: false),
                    NotaDeCreditoEstado = table.Column<int>(nullable: false),
                    NotaDeCreditoSerie = table.Column<string>(nullable: true),
                    NotaDeCreditoAprobacion = table.Column<string>(nullable: true),
                    NotaDeCreditoTipoDeCambio = table.Column<decimal>(nullable: false),
                    NotaDeCreditoMoneda = table.Column<int>(nullable: false),
                    NotaDeCreditoFechaTimbrado = table.Column<DateTime>(nullable: false),
                    NotaDeCreditoSelloSAT = table.Column<string>(nullable: true),
                    NotaDeCreditoSelloCFDI = table.Column<string>(nullable: true),
                    NotaDeCreditoFolioFiscal = table.Column<string>(nullable: true),
                    NotaDeCreditoCFDI = table.Column<bool>(nullable: false),
                    NotaDeCreditoTimbrada = table.Column<bool>(nullable: false),
                    NotaDeCreditoCFDIVersion = table.Column<string>(nullable: true),
                    NotaDeCreditoCFDIFormaDePago = table.Column<string>(nullable: true),
                    NotaDeCreditoCFDIMetodoDePago = table.Column<string>(nullable: true),
                    NotaDeCreditoUsoCFDI = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasCred", x => x.NotaDeCreditoClave);
                    table.ForeignKey(
                        name: "FK_NotasCred_Agentes_NotaDeCreditoAgenteClave",
                        column: x => x.NotaDeCreditoAgenteClave,
                        principalTable: "Agentes",
                        principalColumn: "AgenteClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotasCred_Facturas_NotaDeCreditoFacturaClave",
                        column: x => x.NotaDeCreditoFacturaClave,
                        principalTable: "Facturas",
                        principalColumn: "FacturaClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotasCred_Usuarios_NotaDeCreditoUsuarioClave",
                        column: x => x.NotaDeCreditoUsuarioClave,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    PagoClave = table.Column<string>(nullable: false),
                    PagoUsuarioClave = table.Column<string>(nullable: true),
                    PagoFecha = table.Column<DateTime>(nullable: false),
                    PagoFacturaClave = table.Column<string>(nullable: false),
                    PagoAgenteClave = table.Column<string>(nullable: true),
                    PagoTipo = table.Column<int>(nullable: false),
                    PagoDescripcion = table.Column<string>(nullable: true),
                    PagoCantidad = table.Column<decimal>(nullable: false),
                    PagoComisionPagada = table.Column<bool>(nullable: false),
                    PagoComNew = table.Column<decimal>(nullable: false),
                    PagoCantComision = table.Column<decimal>(nullable: false),
                    PagoFechaComision = table.Column<DateTime>(nullable: false),
                    PagoNeto = table.Column<decimal>(nullable: false),
                    PagoComision = table.Column<decimal>(nullable: false),
                    PagoMoneda = table.Column<int>(nullable: false),
                    PagoTipoDeCambio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.PagoClave);
                    table.ForeignKey(
                        name: "FK_Pagos_Agentes_PagoAgenteClave",
                        column: x => x.PagoAgenteClave,
                        principalTable: "Agentes",
                        principalColumn: "AgenteClave",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagos_Facturas_PagoFacturaClave",
                        column: x => x.PagoFacturaClave,
                        principalTable: "Facturas",
                        principalColumn: "FacturaClave",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_Usuarios_PagoUsuarioClave",
                        column: x => x.PagoUsuarioClave,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioClave",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cheques_ChequeProveedorClave",
                table: "Cheques",
                column: "ChequeProveedorClave");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteAgenteClave",
                table: "Clientes",
                column: "ClienteAgenteClave");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteZonaClave",
                table: "Clientes",
                column: "ClienteZonaClave");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_CompraConsignatarioClave",
                table: "Compras",
                column: "CompraConsignatarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_CompraProveedorClave",
                table: "Compras",
                column: "CompraProveedorClave");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_CompraUsuarioClave",
                table: "Compras",
                column: "CompraUsuarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_ConceptoCompra_ConceptoCompraCompraClave",
                table: "ConceptoCompra",
                column: "ConceptoCompraCompraClave");

            migrationBuilder.CreateIndex(
                name: "IX_ConceptoCompra_ConceptoCompraEtiquetaClave",
                table: "ConceptoCompra",
                column: "ConceptoCompraEtiquetaClave");

            migrationBuilder.CreateIndex(
                name: "IX_ConceptoFactura_ConceptoFacturaEtiquetaClave",
                table: "ConceptoFactura",
                column: "ConceptoFacturaEtiquetaClave");

            migrationBuilder.CreateIndex(
                name: "IX_ConceptoFactura_ConceptoFacturaFacturaClave",
                table: "ConceptoFactura",
                column: "ConceptoFacturaFacturaClave");

            migrationBuilder.CreateIndex(
                name: "IX_ConceptoPedido_ConceptoPedidoEtiquetaClave",
                table: "ConceptoPedido",
                column: "ConceptoPedidoEtiquetaClave");

            migrationBuilder.CreateIndex(
                name: "IX_ConceptoPedido_ConceptoPedidoPedidoClave",
                table: "ConceptoPedido",
                column: "ConceptoPedidoPedidoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Consignatarios_ConsignatarioClienteClave",
                table: "Consignatarios",
                column: "ConsignatarioClienteClave");

            migrationBuilder.CreateIndex(
                name: "IX_CortadorEtiqueta_EtiquetaClave",
                table: "CortadorEtiqueta",
                column: "EtiquetaClave");

            migrationBuilder.CreateIndex(
                name: "IX_Estaciones_EstacionEtiquetaClave",
                table: "Estaciones",
                column: "EstacionEtiquetaClave");

            migrationBuilder.CreateIndex(
                name: "IX_Estaciones_EstacionPantoneClave",
                table: "Estaciones",
                column: "EstacionPantoneClave");

            migrationBuilder.CreateIndex(
                name: "IX_Etiquetas_EtiquetaClienteClave",
                table: "Etiquetas",
                column: "EtiquetaClienteClave");

            migrationBuilder.CreateIndex(
                name: "IX_Etiquetas_EtiquetaFormatoClave",
                table: "Etiquetas",
                column: "EtiquetaFormatoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Etiquetas_EtiquetaMaterialClave",
                table: "Etiquetas",
                column: "EtiquetaMaterialClave");

            migrationBuilder.CreateIndex(
                name: "IX_Etiquetas_EtiquetaProveedorClave",
                table: "Etiquetas",
                column: "EtiquetaProveedorClave");

            migrationBuilder.CreateIndex(
                name: "IX_Existencias_ExistenciaInventarioEtiquetaClave",
                table: "Existencias",
                column: "ExistenciaInventarioEtiquetaClave");

            migrationBuilder.CreateIndex(
                name: "IX_Existencias_ExistenciaInventarioUsuarioClave",
                table: "Existencias",
                column: "ExistenciaInventarioUsuarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_FacturaAgenteClave",
                table: "Facturas",
                column: "FacturaAgenteClave");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_FacturaClienteClave",
                table: "Facturas",
                column: "FacturaClienteClave");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_FacturaConsignatarioClave",
                table: "Facturas",
                column: "FacturaConsignatarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_FacturaPedidoClave",
                table: "Facturas",
                column: "FacturaPedidoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_FacturaUsuarioClave",
                table: "Facturas",
                column: "FacturaUsuarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_Materiales_MaterialFormatoClave",
                table: "Materiales",
                column: "MaterialFormatoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Materiales_MaterialProveedorClave",
                table: "Materiales",
                column: "MaterialProveedorClave");

            migrationBuilder.CreateIndex(
                name: "IX_NotasCargo_NotaDeCargoAgenteClave",
                table: "NotasCargo",
                column: "NotaDeCargoAgenteClave");

            migrationBuilder.CreateIndex(
                name: "IX_NotasCargo_NotaDeCargoFacturaClave",
                table: "NotasCargo",
                column: "NotaDeCargoFacturaClave");

            migrationBuilder.CreateIndex(
                name: "IX_NotasCargo_NotaDeCargoUsuarioClave",
                table: "NotasCargo",
                column: "NotaDeCargoUsuarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_NotasCred_NotaDeCreditoAgenteClave",
                table: "NotasCred",
                column: "NotaDeCreditoAgenteClave");

            migrationBuilder.CreateIndex(
                name: "IX_NotasCred_NotaDeCreditoFacturaClave",
                table: "NotasCred",
                column: "NotaDeCreditoFacturaClave");

            migrationBuilder.CreateIndex(
                name: "IX_NotasCred_NotaDeCreditoUsuarioClave",
                table: "NotasCred",
                column: "NotaDeCreditoUsuarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_PagoAgenteClave",
                table: "Pagos",
                column: "PagoAgenteClave");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_PagoFacturaClave",
                table: "Pagos",
                column: "PagoFacturaClave");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_PagoUsuarioClave",
                table: "Pagos",
                column: "PagoUsuarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PedidoAgenteClave",
                table: "Pedidos",
                column: "PedidoAgenteClave");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PedidoClienteClave",
                table: "Pedidos",
                column: "PedidoClienteClave");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PedidoConsignatarioClave",
                table: "Pedidos",
                column: "PedidoConsignatarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PedidoUsuarioClave",
                table: "Pedidos",
                column: "PedidoUsuarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_ProveedorCuentaGastoClave",
                table: "Proveedores",
                column: "ProveedorCuentaGastoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_InventarioSalidaExistenciaInventarioClave",
                table: "Salidas",
                column: "InventarioSalidaExistenciaInventarioClave");

            migrationBuilder.CreateIndex(
                name: "IX_SuajeEtiqueta_EtiquetaClave",
                table: "SuajeEtiqueta",
                column: "EtiquetaClave");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioAgenteClave",
                table: "Usuarios",
                column: "UsuarioAgenteClave");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cheques");

            migrationBuilder.DropTable(
                name: "ConceptoCompra");

            migrationBuilder.DropTable(
                name: "ConceptoFactura");

            migrationBuilder.DropTable(
                name: "ConceptoPedido");

            migrationBuilder.DropTable(
                name: "CortadorEtiqueta");

            migrationBuilder.DropTable(
                name: "Estaciones");

            migrationBuilder.DropTable(
                name: "NotasCargo");

            migrationBuilder.DropTable(
                name: "NotasCred");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Salidas");

            migrationBuilder.DropTable(
                name: "SuajeEtiqueta");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Cortadores");

            migrationBuilder.DropTable(
                name: "Pantones");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Existencias");

            migrationBuilder.DropTable(
                name: "Suajes");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Etiquetas");

            migrationBuilder.DropTable(
                name: "Consignatarios");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Materiales");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Formatos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Agentes");

            migrationBuilder.DropTable(
                name: "Zonas");

            migrationBuilder.DropTable(
                name: "CuentasGasto");
        }
    }
}
