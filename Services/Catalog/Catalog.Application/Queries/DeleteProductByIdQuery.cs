using MediatR;

namespace Catalog.Application.Queries;

public class DeleteProductByIdQuery : IRequest<bool>
{
    public DeleteProductByIdQuery(string id)
    {
        Id = id;
    }

    public string Id { get; set; }
}