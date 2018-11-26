using GraphQL.Types;

namespace GraphQLSample.GraphQLUtils
{
	public class AgenteInputType : InputObjectGraphType
	{
		public AgenteInputType()
		{
			Name = "AgenteInputType";
			Field<NonNullGraphType<StringGraphType>>("AgenteClave");
			Field<NonNullGraphType<StringGraphType>>("AgenteNombre");
			Field<NonNullGraphType<StringGraphType>>("AgenteDireccion");
			Field<NonNullGraphType<StringGraphType>>("AgenteCD_EDO_PAIS");
			Field<NonNullGraphType<StringGraphType>>("AgenteCP");
			Field<NonNullGraphType<StringGraphType>>("AgenteTelefono");
			Field<NonNullGraphType<StringGraphType>>("AgenteFax");
			Field<NonNullGraphType<DecimalGraphType>>("AgenteComision");
			Field<NonNullGraphType<BooleanGraphType>>("AgenteEstado");
		}
	}
}
