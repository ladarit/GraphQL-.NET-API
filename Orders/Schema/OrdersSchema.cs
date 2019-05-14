using GraphQL;

namespace Orders.Schema
{
    public class OrdersSchema : GraphQL.Types.Schema
    {
        public OrdersSchema(OrdersQuery query, IDependencyResolver resolver, OrdersMutation mutation)
        {
            Query = query;
            Mutation = mutation;
            DependencyResolver = resolver;
        }
    }
}
