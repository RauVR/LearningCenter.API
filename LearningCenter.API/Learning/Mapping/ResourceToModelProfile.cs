using AutoMapper;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Resources;

namespace LearningCenter.API.Learning.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {  //Origen es SaveCategoryResource y el destino es Category
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}