using Shop.Order.Shared;
using System.Web.Http;

namespace Shop.Order.UI.API
{
    public abstract class BaseApiController : ApiController
    {
        public ICommandHandler<T> GetCommandHandler<T>() where T : ICommand
        {
            return (ICommandHandler<T>)WebApiApplication.ServiceProvider.GetService(typeof(ICommandHandler<T>));
        }

        public IQueryHandler<Request,Response> GetQueryHandler<Request,Response>() where Request : IQuery where Response : IQueryResult
        {
            return (IQueryHandler<Request,Response>)WebApiApplication.ServiceProvider.GetService(typeof(IQueryHandler<Request,Response>));
        }
    }
}