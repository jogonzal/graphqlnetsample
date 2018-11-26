using DataRepositories.Database;
using DataRepositories.Entities;

using GraphQL.Types;

namespace GraphQLSample.GraphQLUtils
{
	public class ProveedorType : ObjectGraphType<Proveedor>
	{
		public ProveedorType(EtisysContext etisysContext)
		{
			Field(x => x.ProveedorClave);
			Field(x => x.ProveedorNombre);
			//Field<StringGraphType>("birthDate", resolve: context => context.Source.BirthDate.ToShortDateString());
			//Field<ListGraphType<ProveedorType>>("skaterSeasonStats",
			//	arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
			//	resolve: context => skaterStatisticRepository.Get(context.Source.Id), description: "Player's skater stats");
		}
	}
}
