using System.Collections;
using System.Collections.Generic;

namespace LearningCenter.API.Learning.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //RelationShips 
        public IList<Tutorial> Tutorials { get; set; } = new List<Tutorial>();
    }
}