using MediatR;
using TechBuddyMediatrExample.Entities;

namespace TechBuddyMediatrExample.Med.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }

    }
}
