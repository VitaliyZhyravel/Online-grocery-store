using MediatR;
using Product.Domain.Dtos;

namespace Product.Application.Handlers.Product.Queries.GetByCategory;

record GetByCategoryQuery(Guid categoryId) : IRequest<List<ProductDto>>;

