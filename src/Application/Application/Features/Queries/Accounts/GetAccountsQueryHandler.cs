using Domain.DomainServices.Contracts;
using Domain.Models;
using MediatR;

namespace Application.Features.Queries.Accounts
{
    public class GetAccountsQueryHandler : IRequestHandler<GetAccountsQuery, IEnumerable<Account>>
    {
        private readonly IAccountService service;

        public GetAccountsQueryHandler(IAccountService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<Account>> Handle(GetAccountsQuery request, CancellationToken cancellationToken)
        {
            var result = service.GetAll();
            return result;
        }
    }
}