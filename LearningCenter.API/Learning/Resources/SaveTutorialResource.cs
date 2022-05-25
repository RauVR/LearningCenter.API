using System.ComponentModel.DataAnnotations;

namespace LearningCenter.API.Learning.Resources
{
    public class SaveTutorialResource
    {
        /*Esta seccion es lo que recivo de los usuarios para 
        crear un tutorial, por ello es que se hace uso de conostrains
        que son los requisitos que estan entre corchetes*/
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [MaxLength(120)]
        public string Description { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
        
    }
}