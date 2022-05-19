using System.Threading.Tasks;

namespace LearningCenter.API.Learning.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}