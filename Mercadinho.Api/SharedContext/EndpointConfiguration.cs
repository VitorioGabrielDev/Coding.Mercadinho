using Mercadinho.Api.EmployeeContext.Endpoints;
using Mercadinho.Api.ProductContext.Endpoints;

namespace Mercadinho.Api.SharedContext;

public static class EndpointConfiguration
{
    extension(IEndpointRouteBuilder endpoints)
    {
        public void MapEndpoints()
        {
            endpoints.MapProductEndpoints();
            endpoints.MapEmployeeEndpoints();
        } 
    }
}