using GraphQL;
using GraphQL.Types;

namespace GraphQLSample.GraphQLUtils
{
	public class GraphQLSampleSchema: Schema
	{
		public GraphQLSampleSchema(IDependencyResolver resolver) : base(resolver)
		{
			Query = resolver.Resolve<GraphQLSampleQuery>();
			//Mutation = resolver.Resolve<NHLStatsMutation>();
		}
	}
}
