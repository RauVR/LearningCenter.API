using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Services;
using LearningCenter.API.Learning.Resources;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Learning.Controllers
{   //Por buenas practicas el nombre de esta clase debe ser plural
    //ControllerBase es una clase del framework que esta ya integrado
    
    [Route("/api/v1/[controller]")]
    public class CategoriesControllers : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesControllers(ICategoryService categoryService, IMapper mapper)
        {   //Esto es inyeccion por constructor
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);

            return resources;
        }
    }
}