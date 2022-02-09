using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TextbookManagement.Core.Interfaces;
using TextbookManagement.Domain;

namespace TextbookManagement.Core.Scenarios.Orders.Queries
{
    public class GetOrdersByUserIdQuery : IRequest<List<Order>>
    {
        private GetOrdersByUserIdQuery()
        {
        }

        public static GetOrdersByUserIdQuery Empty()
        {
            return new GetOrdersByUserIdQuery();
        }
    }

    internal class GetOrdersByUserIdQueryHandler : IRequestHandler<GetOrdersByUserIdQuery, List<Order>>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetOrdersByUserIdQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<List<Order>> Handle(GetOrdersByUserIdQuery request, CancellationToken cancellationToken)
        {
            // TODO: get from current user provider
            var currentUserId = Guid.Empty;
            
            return await _dbContext.Orders
                .Include(order => order.OrderedBy)
                //.Where(order => order.OrderedBy.Id == currentUserId)
                .ToListAsync(cancellationToken);
        }
    }
}