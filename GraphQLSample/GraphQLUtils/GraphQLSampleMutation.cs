using DataRepositories.Database;
using DataRepositories.Entities;
using GraphQL.Types;

namespace GraphQLSample.GraphQLUtils
{
	public class GraphQLSampleMutation : ObjectGraphType
	{
		public GraphQLSampleMutation(EtisysContext playerRepository)
		{
			Name = "CreateAgenteMutation";

			Field<AgenteType>(
				"createAgente",
				arguments: new QueryArguments(
					new QueryArgument<NonNullGraphType<AgenteInputType>> { Name = "player" }
				),
				resolve: context =>
				{
					var player = context.GetArgument<Agente>("agente");
					return playerRepository.Agentes.Add(player);
				});
		}
	}
}
