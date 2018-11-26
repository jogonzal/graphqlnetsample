using DataRepositories.Database;
using DataRepositories.Entities;

using GraphQL.Types;
using System.Linq;

namespace GraphQLSample.GraphQLUtils
{
	public class CuentaGastoType : ObjectGraphType<CuentaGasto>
	{
		public CuentaGastoType(EtisysContext etisysContext)
		{
			Field(x => x.CuentaGastoClave);
			Field(x => x.CuentaGastoDescripcion);
			Field<ListGraphType<ProveedorType>>("proveedores",
				//arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = "CuentaGastoClave" }),
				resolve: context => etisysContext.Proveedores.Where(p => p.ProveedorCuentaGastoClave == context.Source.CuentaGastoClave).ToList(), description: "Proveedores de esta cuenta de gasto");
		}
	}
}
