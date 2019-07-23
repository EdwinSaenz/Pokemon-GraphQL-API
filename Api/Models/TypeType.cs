using GraphQL.Types;
using GraphQLPlayground.Core.Models;

namespace GraphQLPlayground.Api.Models
{
    public class TypeType : ObjectGraphType<Type>
    {
        public TypeType()
        {
            Name = "Type";

            Field(p => p.Id).Description("Type ID");
            Field(p => p.Name).Description("Type name");
        }
    }
}