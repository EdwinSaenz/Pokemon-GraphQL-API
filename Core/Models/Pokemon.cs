using System.Collections.Generic;

namespace GraphQLPlayground.Core.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Type> Types { get; set; }
    }
}