using AutoMapper;
using TestTaskWebApi.Dtos;
using TestTaskWebApi.Models;

namespace TestTaskWebApi.Profiles
{
    public class ProductsProfiles : Profile
    {
        public ProductsProfiles()
        {
            //источник --> цель
            CreateMap<Product, ProductReadDTO>(); //Создаем маршрут для automapper сопоставлем из product и то что покажет клиенту из ProductReadDTO
            CreateMap<ProductCreateDto, Product>(); //Создаем маршрут для automapper спостовляем с данными из ProductCreateDto которые должны добавить в базу Product
            CreateMap<ProductUpDateDto, Product>(); //Создаем маршрут для automapper спостовляем с данными из ProductUpDateDto которые должны изменить указанные данные в базе Product
        }
    }
}
