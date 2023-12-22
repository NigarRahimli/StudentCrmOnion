using E = StudentCrm.Domain.Entities;
namespace StudentCrm.Application.Repositories
{
    public interface IEventReadRepository:IReadRepository<E.Event>
    {
    }
}
