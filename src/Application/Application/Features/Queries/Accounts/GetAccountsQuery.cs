using Domain.Models;
using MediatR;

namespace Application.Features.Queries.Accounts
{
    public class GetAccountsQuery : IRequest<List<Account>>
    {
    }
}