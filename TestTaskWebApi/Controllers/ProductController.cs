using AutoMapper;
using Microsoft.AspNetCore.Http;
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
        private readonly IProduct _product;
        private readonly IMapper _mapper;

        public ProductController(IProduct product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDTO>> Get()
        {
            var productsAll = _product.GetAllProduct();
            return Ok(_mapper.Map<IEnumerable<ProductReadDTO>>(productsAll));
        }

        [HttpGet("{id}")]

        public ActionResult<ProductReadDTO> GetProductID(int id)
        {
            var productId = _product.GetProductById(id);

            if (productId != null)
            {
                return Ok(_mapper.Map <ProductReadDTO>(productId));
            }
            return NotFound();
        }
    }
}
