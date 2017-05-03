namespace Shop.Order.Shared
{
    public interface IQueryHandler<Request, Response> where Request : IQuery where Response : IQueryResult
    {
        Response Handle(Request query);
    }
}
