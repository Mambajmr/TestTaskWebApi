using System.ComponentModel.DataAnnotations;

namespace TestTaskWebApi.Dtos
{
    public class ProductUpDateDto
    {
        /*
         * Клиент может создавать новые данные из модели Product. Тут нет свойства id так как база данных создает их автоматически.
         * Класс дублируется для возможного расширения. Если нам понадобиться новая логика изменения или добавления данных, то
         * реализация этой логики будет в разных классах ProductUpdateDtop или ProductCreatDto.
        */
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
