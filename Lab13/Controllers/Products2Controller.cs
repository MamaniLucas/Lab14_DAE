using Lab13.Models;
using Lab13.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Lab13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products2Controller : ControllerBase
    {
        private readonly EnterpriseContext _dbContext;

        public Products2Controller(EnterpriseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("insert")]
        public IActionResult Insert([FromBody] ProductoInsertRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var product = new Product
                {
                    Name = request.Name,
                    Price = request.Price,
                    activo = request.activo
                };

                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();

                return Ok(new { productId = product.ProductId });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Error interno del servidor: {ex.Message}" });
            }
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromBody] ProductoDeleteRequest request)
        {
            try
            {
                var product = _dbContext.Products.FirstOrDefault(p => p.ProductId == request.ProductId);

                if (product == null)
                {
                    return NotFound(new { message = $"Producto con ID {request.ProductId} no encontrado" });
                }

                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();

                return Ok(new { message = $"Producto con ID {request.ProductId} eliminado exitosamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Error interno del servidor: {ex.Message}" });
            }
        }
    }
}
