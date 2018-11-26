using DataRepositories.Database;
using GraphQL.Types;
using System.Linq;

namespace GraphQLSample.GraphQLUtils
{
	public class GraphQLSampleQuery : ObjectGraphType
	{
		public GraphQLSampleQuery(EtisysContext etisysContext)
		{
			//Field<PlayerType>(
			//	"player",
			//	arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
			//	resolve: context => playerRepository.Get(context.GetArgument<int>("id")));

			//Field<PlayerType>(
			//	"randomPlayer",
			//	resolve: context => playerRepository.GetRandom());

			Field<ListGraphType<AgenteType>>(
				"agentes",
				resolve: context => etisysContext.Agentes.ToList());
		}
	}
}


