namespace TestTaskWebApi.Dtos
{
    public class ProductReadDTO
    {

        // здесь устанавливаем то что должно показать клиенту. Если убрать одно из свойств, то в бд будет, но клиенту оно не покажет.
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
