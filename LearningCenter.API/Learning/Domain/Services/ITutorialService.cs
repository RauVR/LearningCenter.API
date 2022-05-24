using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Services.Communication;

namespace LearningCenter.API.Learning.Domain.Services
{
    public interface ITutorialService
    {
        Task<IEnumerable<Tutorial>> ListAsync();
        Task<IEnumerable<Tutorial>> ListByCategoryIdAsync(int categoryId);
        Task<TutorialResponse> SaveAsync(Tutorial tutorial);
        Task<TutorialResponse> UpdateAsync(int id, Tutorial tutorial);
        Task<TutorialResponse> DeleteAsync(int id);
        
    }
}