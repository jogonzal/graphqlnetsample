using DataRepositories.Database;
using DataRepositories.Entities;

using GraphQL.Types;

namespace GraphQLSample.GraphQLUtils
{
	public class AgenteType : ObjectGraphType<Agente>
	{
		public AgenteType(EtisysContext etisysContext)
		{
			Field(x => x.AgenteClave);
			Field(x => x.AgenteNombre);
			Field(x => x.AgenteComision);
			//Field<StringGraphType>("birthDate", resolve: context => context.Source.BirthDate.ToShortDateString());
			//Field<ListGraphType<SkaterStatisticType>>("skaterSeasonStats",
			//	arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
			//	resolve: context => skaterStatisticRepository.Get(context.Source.Id), description: "Player's skater stats");
		}
	}
}
