using AutoMapper;
using TestTaskWebApi.Dtos;
using TestTaskWebApi.Models;

namespace TestTaskWebApi.Profiles
{
    public class ProductsProfiles : Profile
    {
        public ProductsProfiles()
        {
            CreateMap<Product, ProductReadDTO>();
        }
    }
}
