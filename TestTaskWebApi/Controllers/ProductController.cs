using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestTaskWebApi.Data;
using TestTaskWebApi.Dtos;
using TestTaskWebApi.Models;

namespace TestTaskWebApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _repository;
        private readonly IMapper _mapper;

        public ProductController(IProduct product, IMapper mapper)
        {
            _repository = product;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDTO>> Get()
        {
            var productsAll = _repository.GetAllProduct();
            return Ok(_mapper.Map<IEnumerable<ProductReadDTO>>(productsAll));
        }

        [HttpGet("{id}", Name = "GetProductID")]

        public ActionResult<ProductReadDTO> GetProductID(int id)
        {
            var productId = _repository.GetProductById(id);

            if (productId != null)
            {
                return Ok(_mapper.Map<ProductReadDTO>(productId));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ProductCreateDto> CreateProduct(ProductCreateDto productCreateDto)
        {
            var productCreate = _mapper.Map<Product>(productCreateDto);
            _repository.CreateProduct(productCreate);

            _repository.SaveChanges();

            var productReadDto = _mapper.Map<ProductReadDTO>(productCreate);

            return CreatedAtRoute(nameof(GetProductID), new { id = productReadDto.id }, productReadDto); //возвращает созданные данные через url/id
        }

        [HttpPut("{id}")]

        public ActionResult UpdateProduct(int id, ProductUpDateDto productUpdateDto)
        {
            var productFromRepo = _repository.GetProductById(id);
            
            if (productFromRepo is null)
            {
                return NotFound();
            }

            _mapper.Map(productUpdateDto, productFromRepo);

            _repository.UpdateProduct(productFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var productFromRepo = _repository.GetProductById(id);

            if (productFromRepo is null)
            {
                return NotFound();
            }

            _repository.DeleteProduct(productFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

    }
}
