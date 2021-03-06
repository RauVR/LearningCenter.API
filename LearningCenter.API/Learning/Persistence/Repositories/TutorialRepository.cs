using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Repositories;
using LearningCenter.API.Learning.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

//Aqui se esta implementandolo que se hizo en la interface ITutorialRepository

namespace LearningCenter.API.Learning.Persistence.Repositories
{                                   //: BaseRepository, ITutorialRepository     agregamos eso,luego implementamos miembros
    public class TutorialRepository : BaseRepository, ITutorialRepository
    {
        public TutorialRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Tutorial>> ListAsync()
        {
            return await _context.Tutorials
                .Include(p => p.Category)
                .ToListAsync();
        }

        public async Task AddAsync(Tutorial tutorial)
        {
            await _context.Tutorials.AddAsync(tutorial);
        }

        public async Task<Tutorial> FindByIdAsync(int id)
        {
            return await _context.Tutorials
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Tutorial> FindByNameAsync(string name)
        {
            return await _context.Tutorials
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Name == name);
        }

        public async Task<IEnumerable<Tutorial>> FindByCategoryIdAsync(int categoryId)
        {
            return await _context.Tutorials
                .Where(p => p.CategoryId == categoryId)
                .Include(p => p.Category)
                .ToListAsync();
        }

        public void Update(Tutorial tutorial)
        {
            _context.Tutorials.Update(tutorial);
        }

        public void Remove(Tutorial tutorial)
        {
            _context.Tutorials.Remove(tutorial);
        }
    }
}