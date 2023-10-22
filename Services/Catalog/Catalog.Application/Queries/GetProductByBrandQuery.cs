using Catalog.Application.Responses;
using MediatR;

namespace Catalog.Application.Queries;

public class GetProductByBrandQuery : IRequest<IList<ProductResponse>>
{
    public GetProductByBrandQuery(string brandname)
    {
        Brandname = brandname;
    }

    public string Brandname { get; set; }
}