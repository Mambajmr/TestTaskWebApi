using System.ComponentModel.DataAnnotations;

namespace TestTaskWebApi.Dtos
{
    public class ProductCreateDto
    { 
      //Клиент может создавать новые данные из модели Product. Тут нет свойства id так как база данных создает их автоматически.    
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
