using System;
using System.Threading;
using System.Threading.Tasks;
using Mediator.App.Core;

namespace Mediator.App.Infrastructure
{
    public class OrganizationDb : GenericDb<Organization, int>
    {
        public override Task<Organization> Handle(GetQuery<Organization> request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new Organization
            {
                Name = $"hello {DateTime.Now.Ticks}"
            });
        }
    }
}
