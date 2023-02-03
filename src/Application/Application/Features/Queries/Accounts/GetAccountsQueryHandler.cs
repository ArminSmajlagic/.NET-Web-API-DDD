using Domain.Models;
using Domain.Services.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
