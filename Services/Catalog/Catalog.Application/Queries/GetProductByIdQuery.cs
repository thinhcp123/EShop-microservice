using Catalog.Application.Responses;
using MediatR;

namespace Catalog.Application.Queries;

public class GetProductByIdQuery : IRequest<ProductResponse>
{
    public GetProductByIdQuery(string id)
    {
        id = id;
    }

    public string Id { get; set; }
}