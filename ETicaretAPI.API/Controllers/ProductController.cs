using AutoMapper;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.DTOs;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return  Ok(  _productReadRepository.GetAll());
        }


        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            var mappedProduct=_mapper.Map<Product>(createProductDto);
            await _productWriteRepository.AddAsync(mappedProduct);
            await _productWriteRepository.SaveAsync();
            return Ok( );
        }

    }
}
