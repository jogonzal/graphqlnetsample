using GraphQL.Types;

namespace GraphQLSample.GraphQLUtils
{
	public class AgenteInputType : InputObjectGraphType
	{
		public AgenteInputType()
		{
			Name = "PlayerInput";
			Field<NonNullGraphType<StringGraphType>>("AgenteClave");
			//Field<StringGraphType>("birthPlace");
			//Field<StringGraphType>("height");
			//Field<IntGraphType>("weightLbs");
			//Field<DateGraphType>("birthDate");
		}
	}
}
