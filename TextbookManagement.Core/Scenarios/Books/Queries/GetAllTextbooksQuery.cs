using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TextbookManagement.Core.Interfaces;
using TextbookManagement.Domain;

namespace TextbookManagement.Core.Scenarios.Books.Queries
{
    public class GetAllTextbooksQuery : IRequest<List<Textbook>>
    {
        private GetAllTextbooksQuery()
        {
            
        }
        
        public static GetAllTextbooksQuery Empty()
        {
            return new GetAllTextbooksQuery();
        }
    }

    internal class GetAllTextbooksQueryHandler : IRequestHandler<GetAllTextbooksQuery, List<Textbook>>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetAllTextbooksQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<List<Textbook>> Handle(GetAllTextbooksQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
            return await _dbContext.Textbooks.ToListAsync(cancellationToken);
        }
    }
}